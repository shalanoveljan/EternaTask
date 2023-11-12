using System.ComponentModel.DataAnnotations;

namespace EternaTask.Models
{
    public class Client
    {
        public int Id { get; set; }
        [StringLength(1000)]

        public string Image { get; set; }
    }
}
