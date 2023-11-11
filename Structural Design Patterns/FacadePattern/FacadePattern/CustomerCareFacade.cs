using FacadePattern.Implementation;
using FacadePattern.Interfaces;
using static FacadePattern.Helper.GlobalEnum;

namespace FacadePattern
{
    public class CustomerCareFacade: ICustomerCare
    {
        private readonly ICustomerCare _customercareDepartment;
        public CustomerCareFacade()
        {
            _customercareDepartment = new CustomerCareDepartement();
        }

        public void HandleCustomerIssue(string customerName, IssueType issueType)
        {
            _customercareDepartment.HandleCustomerIssue(customerName, issueType);
        }
    }
}
