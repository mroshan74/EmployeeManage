using AutoMapper;
using EmployeeManage.Common.DTOs;
using EmployeeManage.Common.Model;

namespace EmployeeManage.Business;

public class DtoEntityMapperProfile : Profile
{
    public DtoEntityMapperProfile()
    {
        CreateMap<AddressCreate, Address>()
            .ForMember(dest => dest.Id, opt => opt.Ignore());
        CreateMap<AddressUpdate, Address>();
        CreateMap<Address, AddressGet>();
    }
}