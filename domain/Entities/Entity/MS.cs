using System.Collections.Generic;

namespace domain.Entities
{
    public class MS : Entity
    {
        #region Character Infos
        public string CharacterName { get; set; }
        public int Age { get; set; }
        public string Archetype { get; set; }
        public string Description { get; set; }

        public int WeightCapacity { get; set; } // TODO: calcular a partir de regra do sistema de RPG (mecânica)
        public int HealthPoints { get; set; }

        public string Annotations { get; set; }
        #endregion

        #region Character Progress
        public int Experience { get; set; }
        public int Level { get; set; }
        #endregion

        #region Tests
        public int PhysicalTestDiceQuantity { get; set; }
        public int PhysicalTestDiceFaceQuantity { get; set; }

        public int MentalTestDiceQuantity { get; set; }
        public int MentalTestDiceFaceQuantity { get; set; }

        public string GenericTestDiceLabel { get; set; } = "Mágico";
        public int GenericTestDiceQuantity { get; set; }
        public int GenericTestDiceFaceQuantity { get; set; }
        #endregion

        #region Competences
        public IList<SheetCapabilty> PhysicalCapabilities { get; set; }
        public IList<SheetSkill> MentalSkills { get; set; }
        public string GenericAdvantageLabel { get; set; } = "Primazias Místicas";
        public IList<GenericAdvantage> GenericAdvantages { get; set; }

        public IList<SheetDisadvantage> Disadvantages { get; set; }
        #endregion

        #region Inventory
        public IList<SheetWeapon> Weapons { get; set; }
        public IList<SheetArmor> Armors { get; set; }
        public IList<SheetItem> Items { get; set; }
        #endregion
    }
}
