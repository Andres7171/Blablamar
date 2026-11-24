using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBlablamar.Models
{
    [Table("ASISTENCIASEVENTO")]
    public class Asistencia
    {
        [Key]
        [Column("IDASISTENCIA")] public int IdAsistencia { get; set; }
        [Column("IDEVENTO")] public int IdEvento { get; set; }
        [Column("IDCURSOSUSUARIOS")] public int IdCursoUsuario { get; set; }
        [Column("FECHAINSCRIPCION")] public DateTime FechaInscripcion { get; set; } = DateTime.UtcNow;
    }
}
