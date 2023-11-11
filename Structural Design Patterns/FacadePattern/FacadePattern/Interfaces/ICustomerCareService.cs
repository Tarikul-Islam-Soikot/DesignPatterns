using static FacadePattern.Helper.GlobalEnum;

namespace FacadePattern.Interfaces
{
    public interface ICustomerCare
    {
        void HandleCustomerIssue(string customerName, IssueType issueType);
    }
}
