using CommunityPlugin.Objects;
using System;
using System.Collections.Generic;

namespace CommunityPlugin.Non_Native_Modifications.TopMenu
{
    public class SettingExtract : MenuItemBase
    {
        public override bool CanRun()
        {
            return PluginAccess.CheckAccess(nameof(SettingExtract));
        }

        protected override void menuItem_Click(object sender, EventArgs e)
        {
            SettingExtract_Form form = new SettingExtract_Form();
            form.Show();
        }
    }
}
