using domain.Entities;
using System.Threading.Tasks;

namespace service.IServiceCluster
{
    public interface IUserService
    {
        Task<User> GetUserByUsernameAsync(string username);
    }
    public interface IMSService { }
    public interface ISheetCapabiltyService { }
    public interface ICapabilityService { }
    public interface ISheetSkillService { }
    public interface ISkillService { }
    public interface ISheetGenericAdvantageService { }
    public interface IGenericAdvantageService { }
    public interface ISheetDisadvantageService { }
    public interface IDisadvantageService { }
    public interface ISheetWeaponService { }
    public interface IWeaponService { }
    public interface ISheetArmorService { }
    public interface IArmorService { }
    public interface ISheetItemService { }
    public interface IItemService { }
}
