using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public abstract class SheetRelationship : Testable
    {
        [ForeignKey("MS")]
        public int? MSId { get; set; }
        public MS MS { get; set; }
    }
}
