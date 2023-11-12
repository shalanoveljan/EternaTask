using System.ComponentModel.DataAnnotations;

namespace EternaTask.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [StringLength(100)]

        public string Name { get; set; }
        [StringLength(1000)]


        public string Image { get; set; }
        [StringLength(1000)]

        public string Commentary { get; set; }

        public int PositionId { get; set; }
        public Position Position { get; set; }
    }
}
