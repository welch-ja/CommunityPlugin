using CommunityPlugin.Objects;
using CommunityPlugin.Objects.Interface;
using EllieMae.EMLite.ClientServer.Reporting;
using EllieMae.EMLite.Common.UI;
using EllieMae.EMLite.MainUI;
using EllieMae.EMLite.UI;
using System;
using System.Windows.Forms;

namespace CommunityPlugin.Non_Native_Modifications.Pipeline
{
    public class PipelineAdvancedSearch : Plugin, ITabChanged
    {
        public override bool Authorized()
        {
            return PluginAccess.CheckAccess(nameof(PipelineAdvancedSearch));
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

                PipelineScreen s = null;
                GridView pipeline = FormWrapper.GetPipeline();

                FieldFilterList f = new FieldFilterList();
                FieldFilter fff = new FieldFilter();
                //PopUpAdvancedSearchDialog
                //Save to CDO
                //read from CDO
                //Apply each filter

               
                s.SetCurrentFilter(f, 1);

            }
            catch (Exception ex)
            {
                Logger.HandleError(ex, nameof(PipelineAdvancedSearch));
            }
        }
    }
}
