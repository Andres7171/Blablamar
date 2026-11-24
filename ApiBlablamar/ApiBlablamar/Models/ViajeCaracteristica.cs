using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBlablamar.Models
{
    // Relación N:M. La PK compuesta (IDVIAJE, IDCARACTERISTICA) se configura en el DbContext.
    [Table("VIAJECARACTERISTICAS")]
    public class ViajeCaracteristica
    {
        [Column("IDVIAJE")] public int IdViaje { get; set; }
        [Column("IDCARACTERISTICA")] public int IdCaracteristica { get; set; }
    }
}
