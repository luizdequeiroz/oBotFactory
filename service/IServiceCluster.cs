using domain.Entities;
using System.Threading.Tasks;

namespace service.IServiceCluster
{
    public interface IUserService : IGenericService<User>
    {
        Task<User> GetUserByUsernameAsync(string username);
        Task<User> GetByIdWithMSAsync(int userId);
    }
    public interface IMSService : IGenericService<MS> { }
    public interface ISheetCapabiltyService : IGenericService<SheetCapabilty> { }
    public interface ICapabilityService : IGenericService<Capability> { }
    public interface ISheetSkillService : IGenericService<SheetSkill> { }
    public interface ISkillService : IGenericService<Skill> { }
    public interface ISheetGenericAdvantageService : IGenericService<SheetGenericAdvantage> { }
    public interface IGenericAdvantageService : IGenericService<GenericAdvantage> { }
    public interface ISheetDisadvantageService : IGenericService<SheetDisadvantage> { }
    public interface IDisadvantageService : IGenericService<Disadvantage> { }
    public interface ISheetWeaponService : IGenericService<SheetWeapon> { }
    public interface IWeaponService : IGenericService<Weapon> { }
    public interface ISheetArmorService : IGenericService<SheetArmor> { }
    public interface IArmorService : IGenericService<Armor> { }
    public interface ISheetItemService : IGenericService<SheetItem> { }
    public interface IItemService : IGenericService<Item> { }
}
