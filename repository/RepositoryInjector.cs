using domain.Entities;
using Microsoft.Extensions.DependencyInjection;
using repository.Implementations;

namespace repository
{
    public static class RepositoryInjector
    {
        public static void InjectRespositories(this IServiceCollection services)
        {
            services.AddTransient<IGenericRepository<User>, GenericRepository<User>>();
            services.AddTransient<IGenericRepository<MS>, GenericRepository<MS>>();
            services.AddTransient<IGenericRepository<SheetCapabilty>, GenericRepository<SheetCapabilty>>();
            services.AddTransient<IGenericRepository<Capability>, GenericRepository<Capability>>();
            services.AddTransient<IGenericRepository<SheetSkill>, GenericRepository<SheetSkill>>();
            services.AddTransient<IGenericRepository<Skill>, GenericRepository<Skill>>();
            services.AddTransient<IGenericRepository<SheetGenericAdvantage>, GenericRepository<SheetGenericAdvantage>>();
            services.AddTransient<IGenericRepository<GenericAdvantage>, GenericRepository<GenericAdvantage>>();
            services.AddTransient<IGenericRepository<SheetDisadvantage>, GenericRepository<SheetDisadvantage>>();
            services.AddTransient<IGenericRepository<Disadvantage>, GenericRepository<Disadvantage>>();
            services.AddTransient<IGenericRepository<SheetWeapon>, GenericRepository<SheetWeapon>>();
            services.AddTransient<IGenericRepository<Weapon>, GenericRepository<Weapon>>();
            services.AddTransient<IGenericRepository<SheetArmor>, GenericRepository<SheetArmor>>();
            services.AddTransient<IGenericRepository<Armor>, GenericRepository<Armor>>();
            services.AddTransient<IGenericRepository<SheetItem>, GenericRepository<SheetItem>>();
            services.AddTransient<IGenericRepository<Item>, GenericRepository<Item>>();
        }
    }
}
