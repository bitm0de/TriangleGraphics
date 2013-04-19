using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.Windows.Forms;
using PascalsTriangleDisplay.UI;

namespace PascalsTriangleDisplay
{
    public sealed partial class Form1 : Form
    {
        private readonly List<Color> _baseColors = new List<Color>(3);

        // Constructor
        public Form1()
        {
            InitializeComponent();

            DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);

            Text += string.Format(" - v{0}", Application.ProductVersion);
            nudBase.Value = 3;
            nudSize.Value = 3;
            pascalsTriangle1.DefaultBaseColor = cpDefBaseColor.DisplayColor;
            pascalsTriangle1.DefaultTransparencyColor = cpTransColor.DisplayColor;
            cbInnerShape.SelectedIndex = 0;
            pascalsTriangle1.LayoutSize = (int)nudImgSize.Value;
        }

        void SyncColors(int baseValue)
        {
            colorListView1.Items.Clear();
            Dictionary<int, Color> colors = new Dictionary<int, Color>();

            int upperBase = baseValue == 1 ? baseValue + 1 : baseValue;
            colorListView1.BeginUpdate();
            for (int i = 0; i < upperBase; i++)
            {
                Color baseColor = Color.Black;
                if (i < _baseColors.Count)
                {
                    baseColor = _baseColors[i];
                }
                colors.Add(i, baseColor);
                ListViewItem lvi = new ListViewItem(new[] { i.ToString(CultureInfo.InvariantCulture), string.Format("RGB: {0}, {1}, {2}", baseColor.R, baseColor.G, baseColor.B) });
                lvi.SubItems[1].BackColor = baseColor;
                colorListView1.Items.Add(lvi);
            }
            colorListView1.EndUpdate();

            pascalsTriangle1.BaseColors = colors;
        }

        // Event Methods
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = @"PNG Image (*.png)|*.png";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (pascalsTriangle1.PngImage != null)
                        pascalsTriangle1.PngImage.Save(sfd.FileName, ImageFormat.Png);
                }
            }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            pascalsTriangle1.Update();
        }

        private void colorListView1_DoubleClick(object sender, EventArgs e)
        {
            if (colorListView1.SelectedItems.Count > 0)
            {
                int selectedIndex = colorListView1.SelectedIndices[0];
                using (ColorDialog cd = new ColorDialog())
                {
                    cd.AnyColor = true;
                    cd.FullOpen = true;
                    if (cd.ShowDialog(this) == DialogResult.OK)
                    {
                        _baseColors[selectedIndex] = cd.Color;
                        SyncColors(pascalsTriangle1.Base);
                    }
                }
                colorListView1.EnsureVisible(selectedIndex);
            }
        }

        private void cbEnTransparency_CheckedChanged(object sender, EventArgs e)
        {
            pascalsTriangle1.EnableTransparency = cbEnTransparency.Checked;
        }

        private void cpTransColor_ColorChanged(object sender, ColorPicker.ColorChangedEventArgs e)
        {
            pascalsTriangle1.DefaultTransparencyColor = e.NewColor;
        }

        private void cpDefBaseColor_ColorChanged(object sender, ColorPicker.ColorChangedEventArgs e)
        {
            pascalsTriangle1.DefaultBaseColor = e.NewColor;
        }

        private void nudBase_Changed(object sender, EventArgs e)
        {
            pascalsTriangle1.Base = (int)nudBase.Value;
            if (_baseColors.Count <= pascalsTriangle1.Base)
            {
                for (int i = 0; i <= pascalsTriangle1.Base - _baseColors.Count + 1; i++)
                {
                    _baseColors.Add(pascalsTriangle1.DefaultBaseColor);
                }
            }
            SyncColors(pascalsTriangle1.Base);
        }

        private void nudSize_Changed(object sender, EventArgs e)
        {
            pascalsTriangle1.ShapeSize = (int)nudSize.Value;
        }

        private void nudImgSize_Changed(object sender, EventArgs e)
        {
            pascalsTriangle1.LayoutSize = (int)nudImgSize.Value;
        }

        private void cbInnerShape_SelectedIndexChanged(object sender, EventArgs e)
        {
            pascalsTriangle1.InnerShape = (PascalsTriangle.ShapeType)cbInnerShape.SelectedIndex;
        }

    }
}
