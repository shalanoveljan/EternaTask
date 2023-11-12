using System.ComponentModel.DataAnnotations;

namespace EternaTask.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(255)]

        public string Name { get; set; }

        public IEnumerable<Portfolio> Categories { get; set;}
    }
}
