using System.ComponentModel.DataAnnotations;

namespace EternaTask.Models
{
    public class Portfolio
    {
        public Guid Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(1000)]
        public string Image { get; set; }

        public string Client { get; set; }

        public string Project_date { get; set; }

        public string ProjectURL { get; set; }

        public int CategoryId { get; set; }
        public Category? Category { get; set; }
    }
}
