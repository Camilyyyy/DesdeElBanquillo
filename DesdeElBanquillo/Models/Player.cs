using System.ComponentModel.DataAnnotations;

namespace DesdeElBanquillo.Models
{
    public class Player
    {
        [Key]
        public int IdPlayer { get; set; }

        [Required]
        [MaxLength(80)]
        public string Name {  get; set; }

        [Required]
        public int Age {  get; set; }

        [Required]
        public Country Country { get; set; }
        [Required]

        public FTeam Team { get; set; }

        [Required]
        public Position Position { get; set; }
    }
}
