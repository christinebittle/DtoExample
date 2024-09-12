using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

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
    }
}
