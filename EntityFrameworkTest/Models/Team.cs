using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityFrameworkTest.Models
{
    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        public string TeamName { get; set; }

        //A team has many players
        public ICollection<Player>? Players { get; set; }

        //A team can have many sponsors
        public ICollection<Sponsor> Sponsors { get; set; }

        //secret practice information - not public!
        public string SecretPractice { get; set; }
        
        public int SchoolId { get; set; }
        public virtual School School { get; set; }
    }

    public class TeamDto
    {
        public int TeamId { get; set; }

        public string TeamName { get; set; }

        //we can extend this later

        //synthesize a team description
        public string TeamDesc { get; set; }

        //flattening
        public string SchoolName { get; set; }
    }
}
