using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CommunityPlugin.Non_Native_Modifications.SideMenu.Controls
{
    public class MenuPanel : UserControl
    {
        private List<MenuPanelSection> _sections = new List<MenuPanelSection>();
        private IContainer components = (IContainer)null;
        private MenuButton _button;
        private Panel _btnParentPanel;
        private FlowLayoutPanel FlowPanelMain;

        public MenuPanel(List<MenuPanelSection> sections, MenuButton button)
        {
            this.InitializeComponent();
            this._button = button;
            this._sections.AddRange((IEnumerable<MenuPanelSection>)sections);
            this.Refresh();
            this._btnParentPanel = button.Parent as Panel;
            this._button.Click += new EventHandler(this._button_Click);
            Panel sectionHeading = MenuPanel.GetSectionHeading("Loan Tools");
            sectionHeading.Name = "MtgPnlFloatPanelHeading";
            this.FlowPanelMain.Controls.Add((Control)sectionHeading);
            this.FlowPanelMain.Controls.SetChildIndex((Control)sectionHeading, 0);
            this.FlowPanelMain.Width = (int)byte.MaxValue;
            this.BackColor = this.FlowPanelMain.BackColor;
            this.HorizontalScroll.Visible = false;
        }

        public new void Refresh()
        {
            foreach (MenuPanelSection section in this._sections)
            {
                if (section.Heading != null)
                    this.FlowPanelMain.Controls.Add((Control)section.Heading);
                this.FlowPanelMain.Controls.Add((Control)section.Panel);
            }
        }

        private void _button_Click(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Right;
            this.Visible = !this.Visible;
            this._button.VerticalText = this.Visible ? "Close Menu" : "Open Menu";
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && this.components != null)
                this.components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.FlowPanelMain = new FlowLayoutPanel();
            this.SuspendLayout();
            this.FlowPanelMain.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            this.FlowPanelMain.AutoScroll = true;
            this.FlowPanelMain.AutoSize = true;
            this.FlowPanelMain.BackColor = Color.FromArgb(246, 246, 246);
            this.FlowPanelMain.FlowDirection = FlowDirection.TopDown;
            this.FlowPanelMain.Location = new Point(0, 0);
            this.FlowPanelMain.Name = "FlowPanelMain";
            this.FlowPanelMain.Size = new Size(350, 84);
            this.FlowPanelMain.TabIndex = 0;
            this.FlowPanelMain.WrapContents = false;
            this.AutoScaleDimensions = new SizeF(6f, 13f);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Padding = new Padding(0, 0, 10, 0);
            this.BackColor = Color.FromArgb(246, 246, 246);
            this.Controls.Add((Control)this.FlowPanelMain);
            this.Name = "Panel";
            this.Size = new Size(350, 86);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private static Panel GetSectionHeading(string text)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.Dock = DockStyle.Left;
            pictureBox.Height = 23;
            pictureBox.Padding = new Padding(1, 0, 0, 0);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox.Width = 28;

            //Logo here
            //pictureBox.Image = (Image)Resources.Logo;

            Label label = new Label();
            label.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label.AutoSize = true;
            label.BackColor = Color.Transparent;
            label.Dock = DockStyle.Left;
            label.Font = new Font("Segoe UI", 9.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            label.ForeColor = Color.White;
            label.Location = new Point(0, 0);
            label.Margin = new Padding(0);
            label.Padding = new Padding(5, 7, 5, 5);
            label.TabIndex = 0;
            label.Text = text;
            label.TextAlign = ContentAlignment.MiddleCenter;
            Panel panel = new Panel();
            panel.BackColor = Color.FromArgb(0, 19, 98);
            panel.Size = new Size(350, 23);
            panel.Margin = new Padding(0);
            panel.Controls.Add((Control)label);
            panel.Controls.Add((Control)pictureBox);
            return panel;
        }
    }
}
