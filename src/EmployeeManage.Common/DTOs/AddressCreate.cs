namespace EmployeeManage.Common.DTOs;

public record AddressCreate(
    string Street, 
    string Zip, 
    string Email, 
    string City,
    string? Phone
);