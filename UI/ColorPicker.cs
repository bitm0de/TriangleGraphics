using System;
using System.Drawing;
using System.Windows.Forms;

namespace PascalsTriangleDisplay.UI
{
    class ColorPicker : PictureBox
    {
        private readonly SolidBrush _sb = new SolidBrush(Color.White);
        private readonly SolidBrush _sbInverse = new SolidBrush(Color.Black);

        public Color DisplayColor { get; set; }

        public ColorPicker()
        {
            DisplayColor = Color.White;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            _sb.Color = DisplayColor;
            e.Graphics.FillRectangle(_sb, Rectangle.FromLTRB(0, 0, Right - 1, Bottom - 1));
            e.Graphics.DrawRectangle(Pens.Gray, new Rectangle(0, 0, Width - 1, Height - 1));
            string hexColor = string.Format("#{0:X2}{1:X2}{2:X2}", DisplayColor.R, DisplayColor.G, DisplayColor.B);
            DrawHexText(e.Graphics, hexColor);
        }

        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            using (ColorDialog cd = new ColorDialog())
            {
                cd.AnyColor = true;
                cd.FullOpen = true;
                if (cd.ShowDialog(this) == DialogResult.OK)
                {
                    DisplayColor = cd.Color;
                    Invalidate();
                    OnColorChanged(new ColorChangedEventArgs(DisplayColor));
                }
            }
        }

        private void DrawHexText(Graphics g, string text)
        {
            SizeF size = g.MeasureString(text, Font);
            _sbInverse.Color = Color.FromArgb((byte) ~DisplayColor.R, (byte) ~DisplayColor.G, (byte) ~DisplayColor.B);
            g.DrawString(text, Font, _sbInverse, Width / 2 - size.Width / 2, Height / 2 - size.Height / 2);
        }

        public event EventHandler<ColorChangedEventArgs> ColorChanged;
        public virtual void OnColorChanged(ColorChangedEventArgs e)
        {
            EventHandler<ColorChangedEventArgs> handler = ColorChanged;
            if (handler != null)
            {
                handler(this, e);
            }
        }

        public class ColorChangedEventArgs : EventArgs
        {
            public ColorChangedEventArgs(Color newColor)
            {
                NewColor = newColor;
            }
            public Color NewColor;
        }
    }
}
