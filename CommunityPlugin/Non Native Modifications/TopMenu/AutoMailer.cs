using CommunityPlugin.Objects;
using System;

namespace CommunityPlugin.Non_Native_Modifications.TopMenu
{
    public class AutoMailer : MenuItemBase
    {
        public override bool CanRun()
        {
            return PluginAccess.CheckAccess(nameof(AutoMailer));
        }

        protected override void menuItem_Click(object sender, EventArgs e)
        {
            AutoMailer_Form f = new AutoMailer_Form();
            f.Show();
        }
    }
}
