using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace PascalsTriangleDisplay.UI
{
    sealed class PascalsTriangle : PictureBox
    {
        private const decimal Sqrt2 = 1.4142135623730950488016887242m;

        public Bitmap PngImage { get; set; }
        
        // Base Colors
        public int Base { get; set; }
        public Color DefaultBaseColor { get; set; }
        public Dictionary<int, Color> BaseColors { get; set; }

        // Transparent Inner Shapes
        public bool EnableTransparency { get; set; }
        public Color DefaultTransparencyColor { get; set; }

        // Inner Shape
        private ShapeType _innerShape = ShapeType.Squares;
        public ShapeType InnerShape
        {
            get { return _innerShape; }
            set { _innerShape = value; }
        }

        public enum ShapeType
        {
            Circles = 0,
            Squares,
            Triangles
        }

        // Inner Shape Size
        private int _shapeSize = 2;
        public int ShapeSize
        {
            get { return _shapeSize; }
            set { _shapeSize = value; }
        }

        // Overall Display Size
        private int _layoutSize;
        public int LayoutSize
        {
            get { return _layoutSize; }
            set
            {
                Size = new Size(value, value);
                _layoutSize = value;
            }
        }

        // Constructor
        public PascalsTriangle()
        {
            DoubleBuffered = true;
            Size = new Size(100, 100);
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            BackColor = Color.Transparent;
        }

        // Update Display
        private bool _update;
        public new void Update()
        {
            _update = true;
            Invalidate();
        }

        // Drawing
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            if (_update)
            {
                using (Bitmap bmp = new Bitmap(Width, Height))
                {
                    using (Graphics g = Graphics.FromImage(bmp))
                    {
                        g.Clear(Color.Transparent);
                        g.SmoothingMode = SmoothingMode.HighQuality;

                        int calcRows = Height / (ShapeSize ) / 2 - 1;
                        decimal dy = Sqrt2 * ShapeSize;

                        int[] previousColors = new int[] { };
                        for (int i = 0; i < calcRows; i++)
                        {
                            int[] rowColors = new int[i + 1];
                            for (int j = 0; j <= i; j++)
                            {
                                int colorIndex;
                                if (j == 0 || j == i)
                                {
                                    colorIndex = 1;
                                }
                                else
                                {
                                    int leftColor = previousColors[j - 1];
                                    int rightColor = previousColors[j];
                                    colorIndex = (leftColor + rightColor) % Base;
                                }

                                Color fillColor = BaseColors.ContainsKey(colorIndex)
                                                    ? BaseColors[colorIndex]
                                                    : DefaultBaseColor;

                                DrawShape(g, fillColor, new Point((Width / 2 - ShapeSize) + (ShapeSize * (i - j * 2)) - 1, (int)(dy * i * 1.415m)), ShapeSize * 2);
                                rowColors[j] = colorIndex;
                            }
                            previousColors = rowColors;
                        }

                        if (EnableTransparency)
                        {
                            bmp.MakeTransparent(DefaultTransparencyColor);
                        }
                        Image = Image.FromHbitmap(bmp.GetHbitmap());
                        PngImage = bmp.Clone(new Rectangle(Point.Empty, Size), PixelFormat.Format32bppArgb);
                    }
                }
                _update = false;
            }
        }

        // Draw Inner Shape
        private void DrawShape(Graphics g, Color fill, Point location, int size)
        {
            switch (_innerShape)
            {
                case ShapeType.Circles:
                    g.DrawEllipse(Pens.Black, location.X, location.Y, size, size);
                    using (SolidBrush sb = new SolidBrush(fill))
                        g.FillEllipse(sb, new Rectangle(location.X, location.Y, size, size));
                    break;
                case ShapeType.Squares:
                    g.DrawRectangle(Pens.Black, location.X, location.Y, size, size);
                    using (SolidBrush sb = new SolidBrush(fill))
                        g.FillRectangle(sb, new Rectangle(location.X, location.Y, size, size));
                    break;
                case ShapeType.Triangles:
                    Point[] ptsTriangle = new[]
                        {
                            new Point(location.X + size / 2, location.Y), 
                            new Point(location.X + size, location.Y + size), 
                            new Point(location.X, location.Y + size)
                        };
                    g.DrawPolygon(Pens.Black, ptsTriangle);
                    using (SolidBrush sb = new SolidBrush(fill))
                        g.FillPolygon(sb, ptsTriangle);
                    break;
            }
        }

        // Resizing
        private int _prevSize;
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (Height != _prevSize)
            {
                _prevSize = Width = Height;
            }
            else
            {
                _prevSize = Height = Width;
            }
            Update();
        }
    }
}
