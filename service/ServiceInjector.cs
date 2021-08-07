using domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using repository;
using service.Implementations;
using service.Implementations.ServiceCluster;
using service.IServiceCluster;
using service.Utilities;
using service.Utilities.Implementations;

namespace service
{
    public static class ServiceInjector
    {
        public static void InjectServices(this IServiceCollection services)
        {
            services.InjectRespositories();

            services.AddTransient<IUserService, UserService>();
            services.AddTransient<IMSService, MSService>();
            services.AddTransient<ISheetCapabiltyService, SheetCapabiltyService>();
            services.AddTransient<ICapabilityService, CapabilityService>();
            services.AddTransient<ISheetSkillService, SheetSkillService>();
            services.AddTransient<ISkillService, SkillService>();
            services.AddTransient<ISheetGenericAdvantageService, SheetGenericAdvantageService>();
            services.AddTransient<IGenericAdvantageService, GenericAdvantageService>();
            services.AddTransient<ISheetDisadvantageService, SheetDisadvantageService>();
            services.AddTransient<IDisadvantageService, DisadvantageService>();
            services.AddTransient<ISheetWeaponService, SheetWeaponService>();
            services.AddTransient<IWeaponService, WeaponService>();
            services.AddTransient<ISheetArmorService, SheetArmorService>();
            services.AddTransient<IArmorService, ArmorService>();
            services.AddTransient<ISheetItemService, SheetItemService>();
            services.AddTransient<IItemService, ItemService>();

            services.AddTransient<IServiceSwitch, ServiceSwitch>();
        }
    }
}
