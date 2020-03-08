using EllieMae.EMLite.ClientServer;
using EllieMae.EMLite.ContactUI;
using EllieMae.EMLite.DataEngine;
using EllieMae.EMLite.RemotingServices;
using EllieMae.Encompass.Automation;
using EllieMae.Encompass.BusinessObjects.Loans;
using EllieMae.Encompass.BusinessObjects.Users;
using EllieMae.Encompass.Collections;
using EllieMae.Encompass.Reporting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Reflection;
using System.Windows.Forms;

namespace CommunityPlugin.Objects.Helpers
{
    public static class EncompassHelper
    {
        public static bool IsTest()
        {
            return EncompassApplication.Session.ServerURI.Contains(CDOHelper.CDO.CommunitySettings.TestServer);
        }

        public static string FieldDescription(string FieldID)
        {
            return EncompassApplication.Session.Loans.FieldDescriptors[FieldID].Description;
        }

        public static string LastPersona
        {
            get
            {
                return EncompassHelper.User.Personas?.Cast<Persona>().LastOrDefault().Name ?? string.Empty;
            }
        }
        public static string[] GetReportValues(string[] fields, string guid)
        {
            string[] result = new string[fields.Length];
            StringList fieldsToAdd = new StringList();
            foreach (string field in fields)
                fieldsToAdd.Add($"Fields.{field}");
            LoanReportData data = EncompassApplication.Session.Reports.SelectReportingFieldsForLoan(guid, fieldsToAdd);
            for (int i = 0; i < fields.Length; i++)
                result[i] = data[$"Fields.{fields[i]}"].ToString();

            return result;
        }
        public static void SendEmail(MailMessage Message)
        {
            try
            {
                ContactUtils.SendMail(Message);
            }
            catch (Exception ex)
            {
                Logger.HandleError(ex, nameof(SendEmail));
            }
        }

        public static Loan Loan
        {
            get { return EncompassApplication.CurrentLoan; }
        }

        public static LoanDataMgr LoanDataManager {get{ return RemoteSession.LoanDataMgr; }}

        public static string LoanNumber()
        {
            return Loan.LoanNumber;
        }

        public static User User
        {
           get { return EncompassApplication.CurrentUser; }
        }

        public static bool ContainsPersona(List<string> p)
        {
            return p.Any(x => EncompassApplication.CurrentUser.Personas.Contains(PersonaByName(x)));
        }

        public static string Formatted(string FieldID, string Value)
        {
            return EncompassApplication.CurrentLoan.Fields[FieldID].FormattedValue;
        }

        public static bool IsSuper { get { return EncompassApplication.CurrentUser.Personas.Contains(EncompassApplication.Session.Users.Personas.SuperAdministrator); } }
        public static List<FieldDescriptor> GetPrefixedFields(string Prefix)
        {
            return EncompassApplication.Session.Loans.FieldDescriptors.Cast<FieldDescriptor>().Where(x => x.FieldID.StartsWith(Prefix)).ToList<FieldDescriptor>();
        }

        private static Persona PersonaByName(string name)
        {
            return EncompassApplication.Session.Users.Personas.GetPersonaByName(name);
        }

        public static EllieMae.EMLite.RemotingServices.Sessions.Session RemoteSession
        {
            get { return EllieMae.EMLite.RemotingServices.Session.DefaultInstance; }
        }

        public static SessionObjects SessionObjects
        {
            get { return RemoteSession.SessionObjects; }
        }
        public static void ShowOnTop(string Title, string Message)
        {
            MessageBox.Show(Message, Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        public static string Val(string FieldID)
        {
            if (EncompassApplication.CurrentLoan == null)
                return string.Empty;

            if (!EncompassApplication.Session.Loans.FieldDescriptors[FieldID].MultiInstance)
                return EncompassApplication.CurrentLoan.Fields[FieldID].Value?.ToString() ?? string.Empty;
            else
                return string.Empty;
        }

        public static void Set(string FieldID, string Value, string Index = null)
        {
            if (string.IsNullOrEmpty(Index))
                EncompassApplication.CurrentLoan.Fields[FieldID].Value = Value;
            else
                EncompassApplication.CurrentLoan.Fields[Loan.Fields.GetFieldAt(FieldID, Convert.ToInt32(Index)).ID].Value = Value;
        }

        public static void SetBlank(string FieldID, string Index = null)
        {
            if (string.IsNullOrEmpty(Index))
                EncompassApplication.CurrentLoan.Fields[FieldID].Value = string.Empty;
            else
                EncompassApplication.CurrentLoan.Fields[Loan.Fields.GetFieldAt(FieldID, Convert.ToInt32(Index)).ID].Value = string.Empty;
        }


    }
}
