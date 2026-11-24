using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ApiBlablamar.Models
{
    // Vista VW_VIAJES: solo lectura. Se configura en el DbContext (ToView + HasNoKey).
    public class VistaViaje
    {
        [Column("IDVIAJE")] public int IdViaje { get; set; }
        [Column("IDEVENTO")] public int IdEvento { get; set; }
        [Column("IDCONDUCTOR")] public int IdConductor { get; set; }
        [Column("FECHAHORASALIDA")] public DateTime FechaHoraSalida { get; set; }
        [Column("PLAZASTOTALES")] public byte PlazasTotales { get; set; }
        [Column("PUNTOSALIDA")] public string PuntoSalida { get; set; } = string.Empty;
        [Column("PUNTORECOGIDA")] public string? PuntoRecogida { get; set; }
        [Column("PUNTOLLEGADA")] public string PuntoLlegada { get; set; } = string.Empty;
        [Column("DESCRIPCION")] public string? Descripcion { get; set; }
        [Precision(6, 2)]
        [Column("PRECIO")] public decimal? Precio { get; set; }
        [Column("ESTADO")] public string Estado { get; set; } = string.Empty;
        [Column("FECHACREACION")] public DateTime FechaCreacion { get; set; }
        [Column("PLAZASDISPONIBLES")] public int PlazasDisponibles { get; set; }   // calculada
        [Column("ESTADOREAL")] public string EstadoReal { get; set; } = string.Empty; // PROGRAMADO | FINALIZADO | CANCELADO
    }
}
