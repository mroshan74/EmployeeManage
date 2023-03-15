namespace EmployeeManage.Common.DTOs.Address;

public record AddressCreate(
    string Street, 
    string Zip, 
    string Email, 
    string City,
    string? Phone
);