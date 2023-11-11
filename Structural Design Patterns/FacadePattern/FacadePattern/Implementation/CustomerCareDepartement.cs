using FacadePattern.Interfaces;
using static FacadePattern.Helper.GlobalEnum;

namespace FacadePattern.Implementation
{
    public class CustomerCareDepartement : ICustomerCare
    {
        private readonly IBillingDepartment _billingDepartment;
        private readonly ITechnicalDepartment _technicalDepartment;

        public CustomerCareDepartement()
        {
            _billingDepartment = new BillingDepartment();
            _technicalDepartment = new TechnicalDepartment();
        }

        public void HandleCustomerIssue(string customerName, IssueType issueType)
        {
            if (issueType == IssueType.Technical)
                _technicalDepartment.HandleTechnicalIssue(customerName);

            else if (issueType == IssueType.Billing)
                _billingDepartment.HandleBillingIssue(customerName);

            else
                throw new NotImplementedException();
        }
    }
}
