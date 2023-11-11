using FacadePattern.Helper;
using FacadePattern.Interfaces;

namespace FacadePattern.Implementation
{
    public class BillingDepartment : IBillingDepartment
    {
        public void HandleBillingIssue(string customerName)
        {
            Console.WriteLine(string.Format(GlobalMessage.IssueHandledMessage, "Billing", customerName));
        }
    }
}
