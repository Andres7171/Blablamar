namespace ApiBlablamar.DTOs
{
    public class EventoDto
    {
        public int IdEvento { get; set; }
        public string Nombre { get; set; } = string.Empty;
        public string Descripcion { get; set; } = string.Empty;
        public DateTime FechaHora { get; set; }
        public string Lugar { get; set; } = string.Empty;
        public string Direccion { get; set; } = string.Empty;
        public string? Imagen { get; set; }
        public int? Aforo { get; set; }
        public string Estado { get; set; } = string.Empty;

        // Datos que NO están en la tabla EVENTOS: vienen de otras tablas
        public string NombreCreador { get; set; } = string.Empty;
        public string? ImagenCreador { get; set; }
        public int NumAsistentes { get; set; }
    }
}