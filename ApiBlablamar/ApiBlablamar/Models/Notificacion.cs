using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBlablamar.Models
{
    [Table("NOTIFICACIONES")]
    public class Notificacion
    {
        [Key]
        [Column("IDNOTIFICACION")] public int IdNotificacion { get; set; }
        [Column("IDDESTINATARIO")] public int IdDestinatario { get; set; }
        [Column("TIPO")] public string Tipo { get; set; } = string.Empty;
        // SOLICITUD_NUEVA | SOLICITUD_CANCELADA | SOLICITUD_ACEPTADA | SOLICITUD_RECHAZADA | VIAJE_CANCELADO | EVENTO_CANCELADO
        [Column("IDEVENTO")] public int? IdEvento { get; set; }
        [Column("IDVIAJE")] public int? IdViaje { get; set; }
        [Column("IDSOLICITUD")] public int? IdSolicitud { get; set; }
        [Column("LEIDA")] public bool Leida { get; set; } = false;
        [Column("FECHA")] public DateTime Fecha { get; set; } = DateTime.UtcNow;
    }
}
