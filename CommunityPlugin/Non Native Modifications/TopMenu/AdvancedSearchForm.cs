using CommunityPlugin.Objects;
using EllieMae.EMLite.ClientServer.Reporting;
using EllieMae.EMLite.Common.UI;
using EllieMae.EMLite.MainUI;
using System;
using System.Windows.Forms;

namespace CommunityPlugin.Non_Native_Modifications.TopMenu
{
    public class AdvancedSearchForm : MenuItemBase
    {
        public override bool CanRun()
        {
            return PluginAccess.CheckAccess(nameof(AdvancedSearchForm));
        }

        protected override void menuItem_Click(object sender, EventArgs e)
        {
            //Load CDO with filters LoanReportFieldDefs fieldDefs = null;


            //FieldFilterList f = new FieldFilterList();
            //LoanReportFieldDefs fieldDefs = null;


            //PipelineAdvSearchDialog search = new PipelineAdvSearchDialog(fieldDefs, f);

            //if (search.ShowDialog() == DialogResult.OK)
            //{
            //    f = search.GetSelectedFilter();
            //}

            //save cdo
        }
    }
}
