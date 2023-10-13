namespace TapGestureIssue;

public class EmployeeViewModel(Employee employee) : BaseViewModel
{
    readonly Employee Employee = employee;

    public string Id => Employee.Id;
    public string Name => Employee.Name;
    public string ImageUrl => Employee.ImageUrl;
    public string JobTitle => Employee.JobTitle;
}
