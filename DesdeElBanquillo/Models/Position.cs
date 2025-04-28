using System.ComponentModel.DataAnnotations;

namespace DesdeElBanquillo.Models
{
    public class Position
    {
        [Key]
        public int IdPosition { get; set; }

        [Required]
        [StringLength(50)]
        public string PositionName { get; set; }

    }
}
