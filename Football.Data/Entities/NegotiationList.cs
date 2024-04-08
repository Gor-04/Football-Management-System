
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Football.Data.Entities
{
    public class NegotrationList
    {
        [Key]
        public int NegotrationListID { get; set; }

        [Required]
        public int PlayerID { get; set; }

        [Required]
        [StringLength(100)]
        public string PlayerName { get; set; }

        [Required]
        [StringLength(255)]
        public string PreviousTeam { get; set; }

        [Required]
        [StringLength(255)]
        public string NewTeam { get; set; }

        [ForeignKey("PlayerID")]
        public virtual PlayerList PlayerList { get; set; }
    }
}

