using System.ComponentModel.DataAnnotations;          // para [Key]
using System.ComponentModel.DataAnnotations.Schema;   // para [Table] y [Column]

namespace ApiBlablamar.Models
{
    [Table("EVENTOS")]              // nombre EXACTO de la tabla en SQL Server
    public class Evento
    {
        [Key]                       // esta propiedad es la clave primaria
        [Column("IDEVENTO")]        // nombre EXACTO de la columna
        public int IdEvento { get; set; }

        [Column("IDCREADOR")]
        public int IdCreador { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; } = string.Empty;    // NOT NULL → nunca null

        [Column("DESCRIPCION")]
        public string Descripcion { get; set; } = string.Empty;

        [Column("FECHAHORA")]
        public DateTime FechaHora { get; set; }

        [Column("LUGAR")]
        public string Lugar { get; set; } = string.Empty;

        [Column("DIRECCION")]
        public string Direccion { get; set; } = string.Empty;

        [Column("IMAGEN")]
        public string? Imagen { get; set; }          // admite NULL → lleva "?"

        [Column("AFORO")]
        public int? Aforo { get; set; }              // admite NULL → lleva "?"

        [Column("ESTADO")]
        public string Estado { get; set; } = "PUBLICADO";   // mismo DEFAULT que en la BBDD
    }
}