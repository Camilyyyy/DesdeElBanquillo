using System.ComponentModel.DataAnnotations;

namespace DesdeElBanquillo.Models
{
    public class Match
    {
        [Key]
        public int IdMatch { get; set; }

        [Required]
        public DateTime MatchDate { get; set; }


    }
}
