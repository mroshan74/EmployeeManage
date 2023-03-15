namespace EmployeeManage.Common.DTOs.Address;

public record AddressUpdate(
    int Id,
    string Street,
    string Zip,
    string City,
    string Email,
    string? Phone
);