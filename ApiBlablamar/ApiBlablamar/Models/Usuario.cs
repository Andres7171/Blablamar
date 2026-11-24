using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiBlablamar.Models
{
    // Tabla del profe. Solo se lee: los usuarios no se crean desde esta API.
    [Table("USUARIOSTAJAMAR")]
    public class Usuario
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Column("IDUSUARIO")] public int IdUsuario { get; set; }
        [Column("NOMBRE")] public string? Nombre { get; set; }
        [Column("APELLIDOS")] public string? Apellidos { get; set; }
        [Column("EMAIL")] public string? Email { get; set; }
        [Column("ESTADO")] public bool? Estado { get; set; }
        [Column("IMAGEN")] public string? Imagen { get; set; }
        [Column("PASSWORD")] public string? Password { get; set; }   // nunca se devuelve al front
        [Column("IDROLE")] public int? IdRole { get; set; }
    }
}
