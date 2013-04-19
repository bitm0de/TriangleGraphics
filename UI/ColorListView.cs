using System.Drawing;
using System.Windows.Forms;

namespace PascalsTriangleDisplay.UI
{
    class ColorListView : ListView
    {
        readonly SolidBrush _displayColor = new SolidBrush(Color.Black);
        public ColorListView()
        {
            DoubleBuffered = true;
            OwnerDraw = true;
        }

        protected override sealed bool DoubleBuffered
        {
            get { return base.DoubleBuffered; }
            set { base.DoubleBuffered = value; }
        }

        protected override void OnDrawItem(DrawListViewItemEventArgs e)
        {
            base.OnDrawItem(e);
            e.DrawFocusRectangle();
        }

        protected override void OnDrawColumnHeader(DrawListViewColumnHeaderEventArgs e)
        {
            base.OnDrawColumnHeader(e);
            e.DrawDefault = true;
        }

        protected override void OnDrawSubItem(DrawListViewSubItemEventArgs e)
        {
            base.OnDrawSubItem(e);
            e.SubItem.ForeColor = Color.Black;
            e.DrawText(TextFormatFlags.Default);
            if (e.ColumnIndex == 1)
            {
                _displayColor.Color = e.SubItem.BackColor;
                Rectangle rect = new Rectangle(e.Bounds.X + 5, e.Bounds.Y + 3, 6, 6);
                e.Graphics.DrawRectangle(Pens.Black, rect);
                e.Graphics.FillRectangle(_displayColor, rect);
            }
        }
    }
}
