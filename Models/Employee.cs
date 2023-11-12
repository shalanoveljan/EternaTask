using System.ComponentModel.DataAnnotations;

namespace EternaTask.Models
{
    public class Employee
    {

        public int Id { get; set; }
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]

        public string SurName { get; set; }
        [StringLength(1000)]


        public string Image { get; set; }
        [StringLength(1000)]


        public string Description { get; set; }
        [StringLength(1000)]


        public string TwitterUrl { get; set; }
        [StringLength(1000)]

        public string InstagramUrl { get; set; }
        [StringLength(1000)]

        public string FacebookUrl { get; set; }
        [StringLength(1000)]

        public string LinkedinUrl { get; set; }

        public int PositionID { get; set; }
        public Position position { get; set; }


    }
}
