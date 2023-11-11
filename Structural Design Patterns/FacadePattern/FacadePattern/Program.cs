using FacadePattern;
using static FacadePattern.Helper.GlobalEnum;


CustomerCareFacade customercare = new CustomerCareFacade();

customercare.HandleCustomerIssue("Tarikul", IssueType.Technical);
customercare.HandleCustomerIssue("Soikot", IssueType.Billing);
customercare.HandleCustomerIssue("Islam", IssueType.Audit);
