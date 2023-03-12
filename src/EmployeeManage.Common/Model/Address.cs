namespace EmployeeManage.Common.Model;

public class Address : BaseEntity
{
    public string Street { get; set; } = default!;
    public string Zip { get; set; } = default!;
    public string City { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string? Phone { get; set; } = default!;
    public List<Employee> Employees { get; set; } = default!;
}