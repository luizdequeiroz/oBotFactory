using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class SheetDisadvantage : SheetRelationship
    {
        [ForeignKey("Disadvantage")]
        public int DisadvantageId { get; set; }
        public Disadvantage Disadvantage { get; set; }

        public int? ModifierValue { get; set; }
        public int? TestDiceQuantity { get; set; }
        public int? TestDiceFaceQuantity { get; set; }
    }
}
