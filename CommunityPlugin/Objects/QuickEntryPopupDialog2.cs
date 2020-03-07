using EllieMae.EMLite.ClientServer;
using EllieMae.EMLite.Common.UI.Controls;
using EllieMae.EMLite.DataEngine;
using EllieMae.EMLite.InputEngine;
using EllieMae.EMLite.RemotingServices;
using EllieMae.Encompass.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CommunityPlugin.Objects
{
    public class QuickEntryPopupDialog2 : System.Windows.Forms.Form
    {
        private System.Windows.Forms.Panel panelBottom;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel workPanel;
        private TabControl quickTab;
        private TabPage tabVOL;
        private TabPage tabVOM;
        private TabPage tabAdditional;
        private System.Windows.Forms.Panel additionalPanel;
        private System.Windows.Forms.Panel volPanel;
        private System.Windows.Forms.Panel vomPanel;
        private EMHelpLink emHelpLink1;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Panel panelInstruction;
        private System.Windows.Forms.Label labelInstruction;
        private System.Windows.Forms.Panel panelMiddle;

        public QuickEntryPopupDialog2(IHtmlInput inputData, string formTitle, InputFormInfo formInfo, int sizeWidth, int sizeHeight, FieldSource fieldSource, string helpTag, Sessions.Session session)
     : this(inputData, formTitle, formInfo, sizeWidth, sizeHeight, fieldSource, helpTag, session, (object)null)
        {
        }

        public QuickEntryPopupDialog2(IHtmlInput inputData, string formTitle, InputFormInfo formInfo, int sizeWidth, int sizeHeight, FieldSource fieldSource, string helpTag, Sessions.Session session, object property)
        {
            InitializeComponent();
            this.Name = formTitle;
            this.Text = formTitle.Replace("pop","");
            this.Size = new Size(sizeWidth, sizeHeight);
            LoanScreen Screen = new LoanScreen(Session.DefaultInstance);
            this.Controls.Add(Screen);
            Screen.LoadForm(formInfo);
        }

        private void InitializeComponent()
        {
            this.panelBottom = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.emHelpLink1 = new EMHelpLink();
            this.btnClose = new System.Windows.Forms.Button();
            this.workPanel = new System.Windows.Forms.Panel();
            this.quickTab = new TabControl();
            this.tabVOL = new TabPage();
            this.volPanel = new System.Windows.Forms.Panel();
            this.tabVOM = new TabPage();
            this.vomPanel = new System.Windows.Forms.Panel();
            this.tabAdditional = new TabPage();
            this.additionalPanel = new System.Windows.Forms.Panel();
            this.panelInstruction = new System.Windows.Forms.Panel();
            this.labelInstruction = new System.Windows.Forms.Label();
            this.panelMiddle = new System.Windows.Forms.Panel();
            this.panelBottom.SuspendLayout();
            this.quickTab.SuspendLayout();
            this.tabVOL.SuspendLayout();
            this.tabVOM.SuspendLayout();
            this.tabAdditional.SuspendLayout();
            this.panelInstruction.SuspendLayout();
            this.panelMiddle.SuspendLayout();
            this.SuspendLayout();
            this.panelBottom.Controls.Add((System.Windows.Forms.Control)this.btnOK);
            this.panelBottom.Controls.Add((System.Windows.Forms.Control)this.btnClose);
            this.panelBottom.Dock = DockStyle.Bottom;
            this.panelBottom.Location = new Point(0, 439);
            this.panelBottom.Name = "panelBottom";
            this.panelBottom.Size = new Size(682, 48);
            this.panelBottom.TabIndex = 7;
            this.btnOK.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnOK.Location = new Point(513, 12);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new Size(75, 24);
            this.btnOK.TabIndex = 10;
            this.btnOK.Click += BtnOK_Click;
            this.btnOK.Text = "&OK";
            this.emHelpLink1.BackColor = Color.Transparent;
            this.emHelpLink1.Cursor = Cursors.Hand;
            this.emHelpLink1.Font = new Font("Arial", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.emHelpLink1.Location = new Point(12, 12);
            this.emHelpLink1.Name = "emHelpLink1";
            this.emHelpLink1.Size = new Size(90, 16);
            this.emHelpLink1.TabIndex = 9;
            this.btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            this.btnClose.Location = new Point(594, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new Size(75, 24);
            this.btnClose.TabIndex = 8;
            this.btnClose.Text = "&Close";
            this.btnClose.Click += BtnClose_Click;
            this.workPanel.Location = new Point(455, 85);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new Size(120, 84);
            this.workPanel.TabIndex = 6;
            this.quickTab.Controls.Add((System.Windows.Forms.Control)this.tabVOL);
            this.quickTab.Controls.Add((System.Windows.Forms.Control)this.tabVOM);
            this.quickTab.Controls.Add((System.Windows.Forms.Control)this.tabAdditional);
            this.quickTab.Location = new Point(15, 19);
            this.quickTab.Name = "quickTab";
            this.quickTab.SelectedIndex = 0;
            this.quickTab.Size = new Size(404, 272);
            this.quickTab.TabIndex = 8;
            this.tabVOL.Controls.Add((System.Windows.Forms.Control)this.volPanel);
            this.tabVOL.Location = new Point(4, 22);
            this.tabVOL.Name = "tabVOL";
            this.tabVOL.Size = new Size(396, 246);
            this.tabVOL.TabIndex = 0;
            this.tabVOL.Text = "VOL";
            this.volPanel.Dock = DockStyle.Fill;
            this.volPanel.Location = new Point(0, 0);
            this.volPanel.Name = "volPanel";
            this.volPanel.Size = new Size(396, 246);
            this.volPanel.TabIndex = 7;
            this.tabVOM.Controls.Add((System.Windows.Forms.Control)this.vomPanel);
            this.tabVOM.Location = new Point(4, 22);
            this.tabVOM.Name = "tabVOM";
            this.tabVOM.Size = new Size(396, 246);
            this.tabVOM.TabIndex = 1;
            this.tabVOM.Text = "VOM";
            this.vomPanel.Dock = DockStyle.Fill;
            this.vomPanel.Location = new Point(0, 0);
            this.vomPanel.Name = "vomPanel";
            this.vomPanel.Size = new Size(396, 246);
            this.vomPanel.TabIndex = 7;
            this.tabAdditional.Controls.Add((System.Windows.Forms.Control)this.additionalPanel);
            this.tabAdditional.Location = new Point(4, 22);
            this.tabAdditional.Name = "tabAdditional";
            this.tabAdditional.Size = new Size(396, 246);
            this.tabAdditional.TabIndex = 2;
            this.tabAdditional.Text = "Additional";
            this.additionalPanel.Dock = DockStyle.Fill;
            this.additionalPanel.Location = new Point(0, 0);
            this.additionalPanel.Name = "additionalPanel";
            this.additionalPanel.Size = new Size(396, 246);
            this.additionalPanel.TabIndex = 7;
            this.panelMiddle.Controls.Add((System.Windows.Forms.Control)this.quickTab);
            this.panelMiddle.Controls.Add((System.Windows.Forms.Control)this.workPanel);
            this.panelMiddle.Dock = DockStyle.Fill;
            this.panelMiddle.Location = new Point(0, 44);
            this.panelMiddle.Name = "panelMiddle";
            this.panelMiddle.Size = new Size(682, 395);
            this.panelMiddle.TabIndex = 10;
            this.AutoScaleBaseSize = new Size(5, 13);
            this.ClientSize = new Size(682, 487);
            this.Controls.Add((System.Windows.Forms.Control)this.panelMiddle);
            this.Controls.Add((System.Windows.Forms.Control)this.panelBottom);
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.KeyPreview = true;
            this.MinimizeBox = false;
            this.Name = nameof(QuickEntryPopupDialog);
            this.ShowInTaskbar = false;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "Quick Entry";
            this.panelBottom.ResumeLayout(false);
            this.quickTab.ResumeLayout(false);
            this.tabVOL.ResumeLayout(false);
            this.tabVOM.ResumeLayout(false);
            this.tabAdditional.ResumeLayout(false);
            this.panelInstruction.ResumeLayout(false);
            this.panelMiddle.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private void BtnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
