using CommunityPlugin.Objects.Enums;
using CommunityPlugin.Objects.Factories;
using CommunityPlugin.Objects.Interface;
using System;

namespace CommunityPlugin.Objects.Models
{
    public class MailTrigger : ITask
    {
        public string Name { get; set; }

        public bool Active { get; set; }
        public bool HasRan { get; set; }

        public string ReportFilter { get; set; }

        public FrequencyType Frequency { get; set; }

        public int[] Days { get; set; }

        public DateTime Time { get; set; }
        public DateTime Date { get; set; }

        public string Subject { get; set; }

        public string Body { get; set; }

        public string To { get; set; }

        public string CC { get; set; }

        public string BCC { get; set; }

        public MailTrigger Clone(MailTrigger Original)
        {
            MailTrigger newTrigger = new MailTrigger();
            newTrigger.Name = $"Copy of {Original.Name}";
            newTrigger.Active = Original.Active;
            newTrigger.BCC = Original.BCC;
            newTrigger.Body = Original.Body;
            newTrigger.CC = Original.CC;
            newTrigger.Days = Original.Days;
            newTrigger.Frequency = Original.Frequency;
            newTrigger.ReportFilter = Original.ReportFilter;
            newTrigger.Subject = Original.Subject;
            newTrigger.Time = Original.Time;
            newTrigger.To = Original.To;

            return newTrigger;
        }

        public Action Run()
        {
            return () => EmailFactory.Run(this);
        }
    }
}