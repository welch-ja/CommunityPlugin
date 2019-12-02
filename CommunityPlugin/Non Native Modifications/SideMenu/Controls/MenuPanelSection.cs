using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CommunityPlugin.Non_Native_Modifications.SideMenu.Controls
{
    public class MenuPanelSection
    {
        private FlowLayoutPanel panel = new FlowLayoutPanel();

        public FlowLayoutPanel Panel
        {
            get
            {
                return this.panel;
            }
        }

        public Label Heading { get; set; }

        public bool IsExpandlable { get; set; }

        public List<Control> Controls { get; private set; }

        public MenuPanelSection(
          Label heading,
          bool isExandable,
          bool IsVisible = false,
          params Control[] items)
        {
            this.Controls = new List<Control>();
            this.Panel.WrapContents = false;
            this.Panel.FlowDirection = FlowDirection.TopDown;
            this.Panel.Width = 350;
            this.Panel.AutoSize = true;
            this.Panel.Visible = IsVisible;
            this.Heading = heading;
            this.Heading.Click += new EventHandler(this.ButtonClick);
            this.Heading.MouseLeave += new EventHandler(this.Heading_MouseLeave);
            this.Heading.MouseEnter += new EventHandler(this.Heading_MouseEnter);
            this.IsExpandlable = isExandable;
            this.Controls.AddRange((IEnumerable<Control>)((IEnumerable<Control>)items).ToList<Control>());
            this.panel.Margin = new Padding(5, 0, 0, 0);
            this.Refresh();
        }

        private void Heading_MouseEnter(object sender, EventArgs e)
        {
            this.Heading.BackColor = Color.FromArgb(247, 202, 24);
        }

        private void Heading_MouseLeave(object sender, EventArgs e)
        {
            this.Heading.BackColor = Color.FromArgb(227, 227, 227);
        }

        private void Heading_MouseHover(object sender, EventArgs e)
        {
            this.Heading.BackColor = Color.FromArgb(247, 202, 24);
        }

        private void ButtonClick(object sender, EventArgs e)
        {
            this.Panel.Visible = !this.Panel.Visible;
        }

        public MenuPanelSection SetMargin(Padding padding)
        {
            this.panel.Margin = padding;
            return this;
        }

        public void Refresh()
        {
            foreach (Control control in this.Controls)
                this.panel.Controls.Add(control);
        }
    }
}
