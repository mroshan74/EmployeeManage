using EmployeeManage.Business.Services;
using EmployeeManage.Common.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace EmployeeManage.Business;

public class DIConfiguration
{
    public static void RegisterServices(IServiceCollection services)
    {
        services.AddAutoMapper(typeof(DtoEntityMapperProfile));
        services.AddScoped<IAddressService, AddressService>();
        services.AddScoped<IJobService, JobService>();
    }
}