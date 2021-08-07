using System.ComponentModel;

namespace service.Utilities.Enums
{
    public enum ServiceType
    {
        [Description("Usuário")]
        User,
        [Description("Ficha M&S")]
        MS,
        [Description("Capacidade em Ficha")]
        SheetCapabilty,
        [Description("Capacidade")]
        Capability,
        [Description("Habilidade em Ficha")]
        SheetSkill,
        [Description("Habilidade")]
        Skill,
        [Description("Primazia em Ficha")]
        SheetGenericAdvantage,
        [Description("Primazia")]
        GenericAdvantage,
        [Description("Desvantagem em Ficha")]
        SheetDisadvantage,
        [Description("Desvantagem")]
        Disadvantage,
        [Description("Armas em Ficha")]
        SheetWeapon,
        [Description("Arma")]
        Weapon,
        [Description("Armadura em Ficha")]
        SheetArmor,
        [Description("Armadura")]
        Armor,
        [Description("Item em Ficha")]
        SheetItem,
        [Description("Item")]
        Item
    }
}
