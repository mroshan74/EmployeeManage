namespace EmployeeManage.Common.DTOs;

public record AddressUpdate(
    int Id,
    string Street,
    string Zip,
    string City,
    string Email,
    string? Phone
);