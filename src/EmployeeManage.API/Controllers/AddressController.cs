using EmployeeManage.Common.DTOs.Address;
using EmployeeManage.Common.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManage.API.Controllers;

[ApiController]
[Route("/address")]
public class AddressController : ControllerBase
{
    private readonly IAddressService _addressService;

    public AddressController(IAddressService addressService)
    {
        _addressService = addressService;
    }

    [HttpPost]
    [Route("create")]
    public async Task<IActionResult> CreateAddress(AddressCreate addressCreate)
    {
        var id = await _addressService.CreateAddressAsync(addressCreate);
        return Ok(id);
    }

    [HttpPut]
    [Route("update")]
    public async Task<IActionResult> UpdateAddress(AddressUpdate addressUpdate)
    {
        await _addressService.UpdateAddressAsync(addressUpdate);
        return Ok();
    }
    
    [HttpDelete]
    [Route("delete")]
    public async Task<IActionResult> DeleteAddress(AddressDelete addressDelete)
    {
        await _addressService.DeleteAddressAsync(addressDelete);
        return Ok();
    }

    [HttpGet]
    [Route("get/{id}")]
    public async Task<IActionResult> GetAddress(int id)
    {
        var address = await _addressService.GetAddressAsync(id);
        return Ok(address);
    }
    
    [HttpGet]
    [Route("get")]
    public async Task<IActionResult> GetAddresses()
    {
        var addresses = await _addressService.GetAddressesAsync();
        return Ok(addresses);
    }
}