
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiCliente.Models
{
    public class Cliente
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id_cliente { get; set; }

        [MaxLength(13)]
        public string? CUI { get; set; }

        [Required]
        [MaxLength(15)]
        public string NIT { get; set; } = string.Empty;

        [Required]
        [MaxLength(60)]
        public string Nombres { get; set; } = string.Empty;

        [Required]
        [MaxLength(60)]
        public string Apellidos { get; set; } = string.Empty;

        [MaxLength(150)]
        public string? Direccion { get; set; }

        [MaxLength(12)]
        public string? Telefono { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Fecha_Nacimiento { get; set; }
    }
}
