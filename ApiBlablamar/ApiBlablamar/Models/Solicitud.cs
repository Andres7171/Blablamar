using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBlablamar.Models
{
    [Table("SOLICITUDESVIAJE")]
    public class Solicitud
    {
        [Key]
        [Column("IDSOLICITUD")] public int IdSolicitud { get; set; }
        [Column("IDVIAJE")] public int IdViaje { get; set; }
        [Column("IDPASAJERO")] public int IdPasajero { get; set; }
        [Column("UBICACION")] public string? Ubicacion { get; set; }
        [Column("ESTADO")] public string Estado { get; set; } = "PENDIENTE";   // PENDIENTE | ACEPTADA | RECHAZADA | CANCELADA
        [Column("MENSAJE")] public string? Mensaje { get; set; }
        [Column("FECHASOLICITUD")] public DateTime FechaSolicitud { get; set; } = DateTime.UtcNow;
        [Column("FECHARESPUESTA")] public DateTime? FechaRespuesta { get; set; }
    }
}
