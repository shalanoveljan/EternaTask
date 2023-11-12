using System.ComponentModel.DataAnnotations;

namespace EternaTask.Models
{
    public class Service
    {
        public int Id { get; set; }
        [StringLength(100)]

        public string Name { get; set; }

        public IEnumerable<PricingService>? PricingServices { get; set; }
    }
}
