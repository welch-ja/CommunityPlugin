using CommunityPlugin.Objects.Helpers;
using EllieMae.EMLite.ClientServer;
using EllieMae.EMLite.Common;
using EllieMae.EMLite.Common.UI.Forms;
using EllieMae.EMLite.DataEngine;
using EllieMae.EMLite.RemotingServices;
using EllieMae.Encompass.Automation;
using EllieMae.Encompass.BusinessObjects.Users;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Persona = EllieMae.Encompass.BusinessObjects.Users.Persona;

namespace CommunityPlugin.Non_Native_Modifications.Pipeline
{
    public partial class ReassignmentDialog : Form
    {
        private List<PipelineInfo> Info;

        private RoleInfo[] Roles;

        public ReassignmentDialog()
        {
            InitializeComponent();
        }

        public ReassignmentDialog(List<PipelineInfo> Info)
        {
            InitializeComponent();
            this.Info = Info;
            btnReassign.Text = $"Reassign {Info.Count} Loans";
            cmbPersonas.Items.AddRange(EncompassApplication.Session.Users.Personas.Cast<Persona>().Select(x => x.Name).ToArray());
            cmbPersonas.TextChanged += CmbPersonas_TextChanged;
            cmbPersonas.Text = "Loan Officer";
            Roles = ((WorkflowManager)Session.DefaultInstance.BPM.GetBpmManager(BpmCategory.Workflow)).GetAllRoleFunctions();
            cmbRole.Items.AddRange(Roles.Select(x => x.Name).ToArray());
            cmbRole.Text = "Loan Officer";
        }
        private void CmbPersonas_TextChanged(object sender, EventArgs e)
        {
            ComboBox combo = sender as ComboBox;
            Persona selectedPersona = EncompassApplication.Session.Users.Personas.GetPersonaByName(combo.Text);
            dgvUsers.DataSource = EncompassApplication.Session.Users.GetUsersWithPersona(selectedPersona, true).Cast<User>().Select(x => new EncompassUser() { UserName = x.ID, FullName = x.FullName }).ToList();
            dgvUsers.AutoGenerateColumns = true;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }

        private void cmbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReassign_Click(object sender, EventArgs e)
        {
            string user = dgvUsers.SelectedRows[0].Cells[0].Value.ToString();
            string name = dgvUsers.SelectedRows[0].Cells[1].Value.ToString();
            Persona selectedPersona = EncompassApplication.Session.Users.Personas.GetPersonaByName(cmbPersonas.Text);
            RoleInfo selectedRole = Roles.Where(x => x.Name.Equals(cmbRole.Text)).FirstOrDefault();
            if (MessageBox.Show($"Are you sure want to reassign {this.Info.Count} Loans to {name}", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
            {
                using (ProgressReportDialog progressReportDialog = new ProgressReportDialog("Batch Loan Reassignment Process", null, (object)Info, new string[] { }))
                {
                    for (int i = 0; i < Info.Count; i++)
                    {
                        EncompassHelper.SessionObjects.LoanManager.LoanReassign(i, Info[i], user, selectedRole.RoleID, progressReportDialog);
                    }
                }
            }

            if (MessageBox.Show($"Loans have been reassigned", "Reassign", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                this.Close();
            }
        }
    }

    public class EncompassUser
    {
        public string UserName { get; set; }

        public string FullName { get; set; }
    }
}
