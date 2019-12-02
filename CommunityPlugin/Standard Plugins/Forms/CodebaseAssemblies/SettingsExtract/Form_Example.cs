using EllieMae.Encompass.Forms;
using System;

namespace CommunityPlugin.Standard_Plugins.Forms.CodebaseAssemblies.SettingsExtract
{
    public class Form_Example: Form
    {
        public override void CreateControls()
        {
            this.Load += Form_SettingsExtract_Load;
        }

        private void Form_SettingsExtract_Load(object sender, EventArgs e)
        {
            //This is just an example showing how to attach a programatic codebase.
        }
    }
}
