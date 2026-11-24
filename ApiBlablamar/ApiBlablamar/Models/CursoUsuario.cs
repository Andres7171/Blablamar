using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBlablamar.Models
{
    // Tabla del profe. IDCURSOSUSUARIOS es la clave del alumno en todas las tablas propias.
    [Table("CURSOSUSUARIOSTAJAMAR")]
    public class CursoUsuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDCURSOSUSUARIOS")] public int IdCursoUsuario { get; set; }
        [Column("IDCURSO")] public int? IdCurso { get; set; }
        [Column("IDUSUARIO")] public int? IdUsuario { get; set; }
    }
}
