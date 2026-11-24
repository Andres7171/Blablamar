using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBlablamar.Models
{
    // Tabla del profe.
    [Table("CURSOSTAJAMAR")]
    public class Curso
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDCURSO")] public int IdCurso { get; set; }
        [Column("NOMBRE")] public string? Nombre { get; set; }
        [Column("FECHAINICIO")] public DateTime? FechaInicio { get; set; }
        [Column("FECHAFIN")] public DateTime? FechaFin { get; set; }
        [Column("ACTIVO")] public bool? Activo { get; set; }
    }
}
