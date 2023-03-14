﻿namespace EmployeeManage.Common.DTOs;

public record AddressGet(
    int Id,
    string Street,
    string Zip,
    string City,
    string Email,
    string? Phone
);