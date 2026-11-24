using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBlablamar.Models
{
    [Table("CARACTERISTICAS")]
    public class Caracteristica
    {
        [Key]
        [Column("IDCARACTERISTICA")] public int IdCaracteristica { get; set; }
        [Column("NOMBRE")] public string Nombre { get; set; } = string.Empty;
        [Column("ICONO")] public string? Icono { get; set; }
    }
}
