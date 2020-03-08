using CommunityPlugin.Objects;
using CommunityPlugin.Objects.Enums;
using CommunityPlugin.Objects.Helpers;
using EllieMae.Encompass.Automation;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace CommunityPlugin.Non_Native_Modifications.SideMenu.Controls
{
    class CustomLinkLabel : LinkLabel
    {
        public string FormName { get; set; }

        public string InternetLink { get; set; }

        public string MailTo { get; set; }

        public string EmailSubject { get; set; }

        public string EmailBody { get; set; }

        public LinkType Type { get; set; }

        public int PopupHeight { get; set; }

        public int PopupWidth { get; set; }

        public bool IsMi { get; set; }

        public CustomLinkLabel()
        {
        }

        public CustomLinkLabel(
          LinkType Type,
          string Text,
          string FormName,
          int PopupWidth,
          int PopupHeight,
          string InternetLink,
          bool IsMi = false)
        {
            if (EncompassHelper.Loan == null)
                return;

            string str = "RE: " + EncompassHelper.Loan.Fields["37"].FormattedValue + ", " + EncompassHelper.Loan.Fields["36"].FormattedValue + ", " + EncompassHelper.Loan.LoanNumber;
            this.Dock = DockStyle.Fill;
            this.AutoSize = true;
            this.Cursor = Cursors.Hand;
            this.Font = new Font("Segoe UI Symbol", 8.25f, FontStyle.Regular, GraphicsUnit.Point, (byte)0);
            this.ForeColor = Color.FromArgb(59, 112, 192);
            this.FormName = FormName;
            this.InternetLink = InternetLink;
            this.MailTo = FormName;
            this.EmailSubject = str;
            this.LinkBehavior = LinkBehavior.NeverUnderline;
            this.Location = new Point(3, 3);
            this.Margin = new Padding(3, 3, 3, 0);
            this.Name = "label2";
            this.Padding = new Padding(2, 3, 0, 3);
            this.PopupHeight = PopupHeight;
            this.PopupWidth = PopupWidth;
            this.Size = new Size(116, 19);
            this.TabIndex = 0;
            this.Text = Text;
            this.TextAlign = ContentAlignment.MiddleLeft;
            this.Type = Type;
            this.IsMi = IsMi;
            this.Click += new EventHandler(this.CustomLinkLabel_Click);
        }

        private void CustomLinkLabel_Click(object sender, EventArgs e)
        {
            try
            {
                switch (this.Type)
                {
                    case LinkType.Internet:
                        Process.Start(this.InternetLink);
                        break;
                    case LinkType.Email:
                        //Email.Send(this.MailTo, this.EmailSubject, this.EmailBody, true, false);
                        break;
                    case LinkType.Print:
                        Macro.SetFieldNoRules(this.FormName, "X");
                        Macro.SendKeys("%lp{ENTER}");
                        break;
                    case LinkType.Popup:
                        try
                        {
                            Macro.Popup(this.FormName, this.FormName, this.PopupWidth, this.PopupHeight);
                            break;
                        }
                        catch (Exception ex)
                        {
                            Logger.HandleError(ex, nameof(CustomLinkLabel));
                            Macro.GoToForm(this.FormName);
                            Macro.Popup(this.FormName, this.FormName, this.PopupWidth, this.PopupHeight);
                            break;
                        }
                    case LinkType.Form:
                        Macro.GoToForm(this.FormName);
                        break;
                    case LinkType.EFolder:
                        EncompassHelper.Set("CX.OPENDOCUMENT", this.FormName);
                        break;
                    case LinkType.Service:
                        Macro.DisplayServices(this.FormName);
                        break;
                    case LinkType.Pricing:
                        Process.Start(this.InternetLink);
                        break;
                }
            }
            catch (Exception ex)
            {
                Logger.HandleError(ex, nameof(CustomLinkLabel));
            }
        }
    }
}
