using FacadePattern.Helper;
using FacadePattern.Interfaces;

namespace FacadePattern.Implementation
{
    public class TechnicalDepartment : ITechnicalDepartment
    {
        public void HandleTechnicalIssue(string customerName)
        {
            Console.WriteLine(string.Format(GlobalMessage.IssueHandledMessage, "Technical", customerName));
        }
    }
}
