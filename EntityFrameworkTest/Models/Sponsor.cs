using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkTest.Models
{
    public class Sponsor
    {
        [Key]
        public int SponsorId { get; set; }

        public string SponsorName { get; set; }


        //A sponsor can fund many teams
        public ICollection<Team> Teams { get; set; }
    }
}
