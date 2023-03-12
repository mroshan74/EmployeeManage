namespace EmployeeManage.Common.Model;

public class Team : BaseEntity
{
    public string Street { get; set; } = default!;
    public List<Employee> Employees { get; set; } = default!;
}