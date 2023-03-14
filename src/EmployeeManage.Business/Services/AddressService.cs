﻿using AutoMapper;
using EmployeeManage.Common.DTOs;
using EmployeeManage.Common.Interfaces;
using EmployeeManage.Common.Model;

namespace EmployeeManage.Business.Services;

public class AddressService : IAddressService
{
    private readonly IMapper _mapper;
    private readonly IGenericRepository<Address> _addressRepository;

    public AddressService(IMapper mapper, IGenericRepository<Address> addressRepository)
    {
        _mapper = mapper;
        _addressRepository = addressRepository;
    }
    public async Task<int> CreateAddressAsync(AddressCreate addressCreate)
    {
        var entity = _mapper.Map<Address>(addressCreate);
        await _addressRepository.InsertAsync(entity);
        await _addressRepository.SaveChangesAsync();
        return entity.Id;
    }

    public async Task UpdateAddressAsync(AddressUpdate addressUpdate)
    {
        var entity = _mapper.Map<Address>(addressUpdate);
        _addressRepository.Update(entity);
        await _addressRepository.SaveChangesAsync();
    }

    public async Task DeleteAddressAsync(AddressDelete addressDelete)
    {
        var entity = await _addressRepository.GetByIdAsync(addressDelete.Id);
        _addressRepository.Delete(entity);
        await _addressRepository.SaveChangesAsync();
    }

    public async Task<AddressGet> GetAddressAsync(int id)
    {
        var entity = await _addressRepository.GetByIdAsync(id);
        return _mapper.Map<AddressGet>(entity);
    }

    public async Task<List<AddressGet>> GetAddressesAsync()
    {
        var entity = await _addressRepository.GetAsync(null, null);
        return _mapper.Map<List<AddressGet>>(entity);
    }
}