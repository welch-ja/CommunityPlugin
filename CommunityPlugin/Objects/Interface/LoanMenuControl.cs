using CommunityPlugin.Objects.Helpers;
using EllieMae.Encompass.Automation;
using EllieMae.Encompass.BusinessObjects;
using EllieMae.Encompass.BusinessObjects.Loans;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace CommunityPlugin.Objects.Interface
{
    [TypeDescriptionProvider(typeof(AbstractControlDescriptionProvider<LoanMenuControl, UserControl>))]
    public abstract class LoanMenuControl : UserControl, ILoanMenuControl
    {
        public abstract bool CanRun();

        public abstract bool CanShow();

        public virtual void RunBase()
        {
            if (!this.CanRun())
                return;
            if (typeof(IFieldChange).IsAssignableFrom(this.GetType()))
            {
                EncompassHelper.Loan.FieldChange +=BaseClass__FieldChange;
            }
            if (typeof(ICommitted).IsAssignableFrom(this.GetType()))
            {
                EncompassHelper.Loan.Committed += Base_Committed;
            }
            if (typeof(IBeforeCommit).IsAssignableFrom(this.GetType()))
            {
                EncompassHelper.Loan.BeforeCommit += Base_BeforeCommit;
            }
            if (!typeof(ILoanClosing).IsAssignableFrom(this.GetType()))
                return;

            EncompassApplication.LoanClosing += this.Base_LoanClosing;
        }

        public virtual void FieldChanged(object sender, FieldChangeEventArgs e)
        {
            throw new ImplementationException(this.GetType().Name, nameof(IFieldChange), nameof(FieldChanged));
        }

        private void BaseClass__FieldChange(object sender, FieldChangeEventArgs e)
        {
            try
            {
                this.FieldChanged(sender, e);
            }
            catch (Exception ex)
            {
                Logger.HandleError(ex, nameof(BaseClass__FieldChange), (object)null);
            }
        }

        public virtual void Committed(object sender, PersistentObjectEventArgs e)
        {
            throw new ImplementationException(this.GetType().Name, "ICommitted", "LoanEvents_Committed");
        }

        private void Base_Committed(object sender, PersistentObjectEventArgs e)
        {
            try
            {
                this.Committed(sender, e);
            }
            catch (Exception ex)
            {
                Logger.HandleError(ex, nameof(Base_Committed), (object)null);
            }
        }

        public virtual void BeforeCommit(object source, CancelableEventArgs e)
        {
            throw new ImplementationException(this.GetType().Name, "IBeforeCommitt", "LoanEvents_BeforeCommitt");
        }

        private void Base_BeforeCommit(object source, CancelableEventArgs e)
        {
            try
            {
                this.BeforeCommit(source, e);
            }
            catch (Exception ex)
            {
                Logger.HandleError(ex, nameof(Base_BeforeCommit), (object)null);
            }
        }

        public virtual void LoanClosing(object source, EventArgs e)
        {
            throw new ImplementationException(this.GetType().Name, "ILoanClosing", "LoanEvents_LoanClosing");
        }

        private void Base_LoanClosing(object source, EventArgs e)
        {
            try
            {
                this.LoanClosing(source, e);
            }
            catch (Exception ex)
            {
                Logger.HandleError(ex, nameof(Base_LoanClosing), (object)null);
            }
        }
    }
}
