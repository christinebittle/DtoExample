using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkTest.Models
{
    public class School
    {
        [Key]
        public int SchoolId { get; set; }

        public string SchoolName { get; set; }

        //year stored as an integer
        public int SchoolFounded { get; set; }

    }
}
