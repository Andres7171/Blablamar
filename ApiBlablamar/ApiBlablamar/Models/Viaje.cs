using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ApiBlablamar.Models
{
    [Table("VIAJES")]
    public class Viaje
    {
        [Key]
        [Column("IDVIAJE")] public int IdViaje { get; set; }
        [Column("IDEVENTO")] public int IdEvento { get; set; }
        [Column("IDCONDUCTOR")] public int IdConductor { get; set; }
        [Column("FECHAHORASALIDA")] public DateTime FechaHoraSalida { get; set; }   // UTC
        [Column("PLAZASTOTALES")] public byte PlazasTotales { get; set; }          // tinyint (1 a 8)
        [Column("PUNTOSALIDA")] public string PuntoSalida { get; set; } = string.Empty;
        [Column("PUNTORECOGIDA")] public string? PuntoRecogida { get; set; }       // NULL = se recoge en PUNTOSALIDA
        [Column("PUNTOLLEGADA")] public string PuntoLlegada { get; set; } = string.Empty;
        [Column("DESCRIPCION")] public string? Descripcion { get; set; }
        [Precision(6, 2)]
        [Column("PRECIO")] public decimal? Precio { get; set; }                    // NULL = gratis
        [Column("ESTADO")] public string Estado { get; set; } = "PROGRAMADO";       // PROGRAMADO | CANCELADO
        [Column("FECHACREACION")] public DateTime FechaCreacion { get; set; } = DateTime.UtcNow;
    }
}
