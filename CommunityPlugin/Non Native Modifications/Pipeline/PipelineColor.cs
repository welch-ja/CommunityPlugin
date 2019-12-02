using CommunityPlugin.Objects;
using CommunityPlugin.Objects.Interface;
using EllieMae.EMLite.DataEngine;
using EllieMae.EMLite.UI;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunityPlugin.Non_Native_Modifications
{
    public class PipelineColor : Plugin, ITabChanged
    {
        public override bool Authorized()
        {
            return PluginAccess.CheckAccess(nameof(PipelineColor));
        }

        public override void TabChanged(object sender, EventArgs e)
        {
            try
            {
                TabControl tab = sender as TabControl;
                if (tab.SelectedIndex < 0)
                    return;
                TabPage tabPage = tab.TabPages[tab.SelectedIndex];
                if (tabPage == null || !tabPage.Name.Contains("pipeline"))
                    return;

                GridView pipeline = FormWrapper.GetPipeline();
                pipeline.Items.Change += Items_Change;

                CheckRules();
            }
            catch (Exception ex)
            {
                Logger.HandleError(ex, "OpenReadOnly");
            }
        }

        private void Items_Change(object sender, EventArgs e)
        {
            CheckRules(sender as GVItemCollection);
        }

        private void CheckRules(GVItemCollection Items = null)
        {
            foreach(GVItem item in Items)
            {
                PipelineInfo info = item.Tag as PipelineInfo;

                if(info.Info.ContainsKey("Loan.LoanAmount") && info.Info["Loan.LoanAmount"] != null && (((decimal)info.Info["Loan.LoanAmount"]) > 500000))
                {
                    item.BackColor = Color.Green;
                }
            }
        }
    }
}
