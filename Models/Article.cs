using System.ComponentModel.DataAnnotations;

namespace EternaTask.Models
{
    public class Article
    {
        public int Id { get; set; }
        [StringLength(1000)]


        public string Image { get; set; }
        [StringLength(255)]

        public string? Title { get; set; }
        [StringLength(1000)]
        
        public string Description { get; set; }

    }
}
