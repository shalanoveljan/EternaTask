using System.ComponentModel.DataAnnotations;

namespace EternaTask.Models
{
    public class Page_Service
    {
        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }


    }
}
