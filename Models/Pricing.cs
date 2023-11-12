using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EternaTask.Models
{
    public class Pricing
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [Column(TypeName = "smallmoney")]

        public double? Price { get; set; }

        public bool IsFeature { get; set; }

        public IEnumerable<PricingService>? PricingServices { get; set; }
    }
}
