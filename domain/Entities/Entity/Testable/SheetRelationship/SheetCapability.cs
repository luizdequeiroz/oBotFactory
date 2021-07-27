using System.ComponentModel.DataAnnotations.Schema;

namespace domain.Entities
{
    public class SheetCapabilty : SheetRelationship
    {
        [ForeignKey("Capability")]
        public int CapabilityId { get; set; }
        public Capability Capability { get; set; }
    }
}
