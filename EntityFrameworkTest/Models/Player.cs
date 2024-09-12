using System.ComponentModel.DataAnnotations;

namespace EntityFrameworkTest.Models
{
    public class Player
    {
        //make sure the player is registered with a PK
        [Key]
        public int PlayerId { get; set; }

        public string PlayerName { get; set; }

        public string PlayerBio { get; set; }

        public DateTime PlayerDOB { get; set; }

        //a player belongs to one team
        public int TeamId { get; set; }

        public virtual Team Team { get; set; }

    }
}
