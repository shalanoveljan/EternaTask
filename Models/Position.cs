using System.ComponentModel.DataAnnotations;

namespace EternaTask.Models
{
    public class Position
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }

        public IEnumerable<Employee> Employees { get; set;}
        public IEnumerable<Testimonial> Testimonials { get; set; }

    }
}
