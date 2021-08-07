using domain.Entities;
using Newtonsoft.Json;
using service.IServiceCluster;
using service.Utilities.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace service.Utilities.Implementations
{
    public class ServiceSwitch : IServiceSwitch
    {
        private readonly IServiceProvider serviceProvider;
        private readonly string FullNameEntities = "domain.Entities.{0}, domain";

        public ServiceSwitch(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public Func<object, Task<dynamic>> SetNewAsync { get; private set; }

        public Func<Task<IList<dynamic>>> GetAllAsync { get; private set; }

        public Func<int, Task<dynamic>> GetByIdAsync { get; private set; }

        public Func<string, string, Task<IList<dynamic>>> GetByPropertyAsync { get; private set; }

        public Func<object, Task<dynamic>> AlterAsync { get; private set; }

        public Func<int, Task<bool>> DeleteAsync { get; private set; }

        public IServiceSwitch Case(ServiceType serviceType)
        {
            dynamic service = null;
            switch (serviceType)
            {
                case ServiceType.User: service = serviceProvider.GetService(typeof(IUserService)); break;
                case ServiceType.MS: service = serviceProvider.GetService(typeof(IMSService)); break;
                case ServiceType.SheetCapabilty: service = serviceProvider.GetService(typeof(ISheetCapabiltyService)); break;
                case ServiceType.Capability: service = serviceProvider.GetService(typeof(ICapabilityService)); break;
                case ServiceType.SheetSkill: service = serviceProvider.GetService(typeof(ISheetSkillService)); break;
                case ServiceType.Skill: service = serviceProvider.GetService(typeof(ISkillService)); break;
                case ServiceType.SheetGenericAdvantage: service = serviceProvider.GetService(typeof(ISheetGenericAdvantageService)); break;
                case ServiceType.GenericAdvantage: service = serviceProvider.GetService(typeof(IGenericAdvantageService)); break;
                case ServiceType.SheetDisadvantage: service = serviceProvider.GetService(typeof(ISheetDisadvantageService)); break;
                case ServiceType.Disadvantage: service = serviceProvider.GetService(typeof(IDisadvantageService)); break;
                case ServiceType.SheetWeapon: service = serviceProvider.GetService(typeof(ISheetWeaponService)); break;
                case ServiceType.Weapon: service = serviceProvider.GetService(typeof(IWeaponService)); break;
                case ServiceType.SheetArmor: service = serviceProvider.GetService(typeof(ISheetArmorService)); break;
                case ServiceType.Armor: service = serviceProvider.GetService(typeof(IArmorService)); break;
                case ServiceType.SheetItem: service = serviceProvider.GetService(typeof(ISheetItemService)); break;
                case ServiceType.Item: service = serviceProvider.GetService(typeof(IItemService)); break;
            }

            SetNewAsync = async entity =>
            {
                var typeServiceType = Type.GetType(string.Format(FullNameEntities, serviceType.ToString()));

                dynamic result = null;
                switch(typeServiceType.Name)
                {
                    case "User": result = await service.SetNewAsync(JsonConvert.DeserializeObject<User>(entity.ToString())); break;
                    case "MS": result = await service.SetNewAsync(JsonConvert.DeserializeObject<MS>(entity.ToString())); break;
                    case "SheetCapabilty": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetCapabilty>(entity.ToString())); break;
                    case "Capability": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Capability>(entity.ToString())); break;
                    case "SheetSkill": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetSkill>(entity.ToString())); break;
                    case "Skill": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Skill>(entity.ToString())); break;
                    case "SheetGenericAdvantage": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetGenericAdvantage>(entity.ToString())); break;
                    case "GenericAdvantage": result = await service.SetNewAsync(JsonConvert.DeserializeObject<GenericAdvantage>(entity.ToString())); break;
                    case "SheetDisadvantage": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetDisadvantage>(entity.ToString())); break;
                    case "Disadvantage": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Disadvantage>(entity.ToString())); break;
                    case "SheetWeapon": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetWeapon>(entity.ToString())); break;
                    case "Weapon": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Weapon>(entity.ToString())); break;
                    case "SheetArmor": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetArmor>(entity.ToString())); break;
                    case "Armor": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Armor>(entity.ToString())); break;
                    case "SheetItem": result = await service.SetNewAsync(JsonConvert.DeserializeObject<SheetItem>(entity.ToString())); break;
                    case "Item": result = await service.SetNewAsync(JsonConvert.DeserializeObject<Item>(entity.ToString())); break;
                }

                return result;
            };
            GetAllAsync = async () => ((await service.GetAllAsync()) as IEnumerable<dynamic>).ToList();
            GetByIdAsync = async id => await service.GetByIdAsync(id);
            GetByPropertyAsync = async (propertyName, value) => (await service.GetByPropertyAsync(propertyName, value) as IEnumerable<dynamic>).ToList();
            AlterAsync = async entity =>
            {
                var typeServiceType = Type.GetType(string.Format(FullNameEntities, serviceType.ToString()));

                dynamic result = null;
                switch (typeServiceType.Name)
                {
                    case "User": result = await service.AlterAsync(JsonConvert.DeserializeObject<User>(entity.ToString())); break;
                    case "MS": result = await service.AlterAsync(JsonConvert.DeserializeObject<MS>(entity.ToString())); break;
                    case "SheetCapabilty": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetCapabilty>(entity.ToString())); break;
                    case "Capability": result = await service.AlterAsync(JsonConvert.DeserializeObject<Capability>(entity.ToString())); break;
                    case "SheetSkill": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetSkill>(entity.ToString())); break;
                    case "Skill": result = await service.AlterAsync(JsonConvert.DeserializeObject<Skill>(entity.ToString())); break;
                    case "SheetGenericAdvantage": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetGenericAdvantage>(entity.ToString())); break;
                    case "GenericAdvantage": result = await service.AlterAsync(JsonConvert.DeserializeObject<GenericAdvantage>(entity.ToString())); break;
                    case "SheetDisadvantage": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetDisadvantage>(entity.ToString())); break;
                    case "Disadvantage": result = await service.AlterAsync(JsonConvert.DeserializeObject<Disadvantage>(entity.ToString())); break;
                    case "SheetWeapon": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetWeapon>(entity.ToString())); break;
                    case "Weapon": result = await service.AlterAsync(JsonConvert.DeserializeObject<Weapon>(entity.ToString())); break;
                    case "SheetArmor": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetArmor>(entity.ToString())); break;
                    case "Armor": result = await service.AlterAsync(JsonConvert.DeserializeObject<Armor>(entity.ToString())); break;
                    case "SheetItem": result = await service.AlterAsync(JsonConvert.DeserializeObject<SheetItem>(entity.ToString())); break;
                    case "Item": result = await service.AlterAsync(JsonConvert.DeserializeObject<Item>(entity.ToString())); break;
                }

                return result;
            };
            DeleteAsync = async id => (bool)await service.DeleteAsync(id);

            return this;
        }
    }
}