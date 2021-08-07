using domain.Entities;
using repository;
using service.IServiceCluster;

namespace service.Implementations.ServiceCluster
{
    internal class UserService : GenericService<User>, IUserService
    {
        public UserService(IGenericRepository<User> genericRepository) : base(genericRepository) { }
    }
    internal class MSService : GenericService<MS>, IMSService
    {
        public MSService(IGenericRepository<MS> genericRepository) : base(genericRepository) { }
    }
    internal class SheetCapabiltyService : GenericService<SheetCapabilty>, ISheetCapabiltyService
    {
        public SheetCapabiltyService(IGenericRepository<SheetCapabilty> genericRepository) : base(genericRepository) { }
    }
    internal class CapabilityService : GenericService<Capability>, ICapabilityService
    {
        public CapabilityService(IGenericRepository<Capability> genericRepository) : base(genericRepository) { }
    }
    internal class SheetSkillService : GenericService<SheetSkill>, ISheetSkillService
    {
        public SheetSkillService(IGenericRepository<SheetSkill> genericRepository) : base(genericRepository) { }
    }
    internal class SkillService : GenericService<Skill>, ISkillService
    {
        public SkillService(IGenericRepository<Skill> genericRepository) : base(genericRepository) { }
    }
    internal class SheetGenericAdvantageService : GenericService<SheetGenericAdvantage>, ISheetGenericAdvantageService
    {
        public SheetGenericAdvantageService(IGenericRepository<SheetGenericAdvantage> genericRepository) : base(genericRepository) { }
    }
    internal class GenericAdvantageService : GenericService<GenericAdvantage>, IGenericAdvantageService
    {
        public GenericAdvantageService(IGenericRepository<GenericAdvantage> genericRepository) : base(genericRepository) { }
    }
    internal class SheetDisadvantageService : GenericService<SheetDisadvantage>, ISheetDisadvantageService
    {
        public SheetDisadvantageService(IGenericRepository<SheetDisadvantage> genericRepository) : base(genericRepository) { }
    }
    internal class DisadvantageService : GenericService<Disadvantage>, IDisadvantageService
    {
        public DisadvantageService(IGenericRepository<Disadvantage> genericRepository) : base(genericRepository) { }
    }
    internal class SheetWeaponService : GenericService<SheetWeapon>, ISheetWeaponService
    {
        public SheetWeaponService(IGenericRepository<SheetWeapon> genericRepository) : base(genericRepository) { }
    }
    internal class WeaponService : GenericService<Weapon>, IWeaponService
    {
        public WeaponService(IGenericRepository<Weapon> genericRepository) : base(genericRepository) { }
    }
    internal class SheetArmorService : GenericService<SheetArmor>, ISheetArmorService
    {
        public SheetArmorService(IGenericRepository<SheetArmor> genericRepository) : base(genericRepository) { }
    }
    internal class ArmorService : GenericService<Armor>, IArmorService
    {
        public ArmorService(IGenericRepository<Armor> genericRepository) : base(genericRepository) { }
    }
    internal class SheetItemService : GenericService<SheetItem>, ISheetItemService
    {
        public SheetItemService(IGenericRepository<SheetItem> genericRepository) : base(genericRepository) { }
    }
    internal class ItemService : GenericService<Item>, IItemService
    {
        public ItemService(IGenericRepository<Item> genericRepository) : base(genericRepository) { }
    }
}
