using System.Drawing;
using System.Windows.Forms;

namespace CommunityPlugin.Non_Native_Modifications.SideMenu.Controls
{
    public class MenuButton : Button
    {
        private StringFormat format = new StringFormat();

        public string VerticalText { get; set; }

        public MenuButton()
        {
            this.format.Alignment = StringAlignment.Center;
            this.format.LineAlignment = StringAlignment.Center;
            this.AutoSize = true;
            this.FlatAppearance.BorderSize = 0;
            this.FlatStyle = FlatStyle.Flat;
            this.Height = 100;
            this.Name = "btnMenuButton";
            this.VerticalText = "Close Menu";
            this.Width = 27;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);
            int num = 2;
            pevent.Graphics.TranslateTransform((float)this.Width, 0.0f);
            pevent.Graphics.RotateTransform(90f);
            pevent.Graphics.DrawString(this.VerticalText, this.Font, Brushes.Black, (RectangleF)new Rectangle(0, 0, this.Height, this.Width), this.format);
            pevent.Graphics.DrawLine(new Pen(Color.FromArgb(76, 138, 147), (float)num), new Point(0, 1), new Point(this.Height, 1));
        }
    }
}
