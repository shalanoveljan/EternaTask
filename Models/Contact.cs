using System.ComponentModel.DataAnnotations;

namespace EternaTask.Models
{
    public class Contact
    {
        public int Id { get; set; }
        [StringLength(1000)]

        public string Address { get; set; }
        [StringLength(100)]

        public string Email { get; set; }
        [StringLength(1000)]
        public string PhoneNumber { get; set; }

    }
}
