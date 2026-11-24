using ApiBlablamar.Data;
using ApiBlablamar.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ApiBlablamar.Repositories
{
    public class RepositoryEventos
    {
        private BlaBlaMarContext context;

        public RepositoryEventos(BlaBlaMarContext context)
        {
            this.context = context;
        }

        // Consulta base: eventos + datos del creador + nº de asistentes
        private IQueryable<EventoDto> GetConsultaEventos()
        {
            return from e in this.context.Eventos
                   join cu in this.context.CursosUsuarios on e.IdCreador equals cu.IdCursoUsuario
                   join u in this.context.Usuarios on cu.IdUsuario equals (int?)u.IdUsuario
                   select new EventoDto
                   {
                       IdEvento = e.IdEvento,
                       Nombre = e.Nombre,
                       Descripcion = e.Descripcion,
                       FechaHora = e.FechaHora,
                       Lugar = e.Lugar,
                       Direccion = e.Direccion,
                       Imagen = e.Imagen,
                       Aforo = e.Aforo,
                       Estado = e.Estado,
                       NombreCreador = u.Nombre + " " + u.Apellidos,
                       ImagenCreador = u.Imagen,
                       NumAsistentes = this.context.Asistencias.Count(a => a.IdEvento == e.IdEvento)
                   };
        }

        // Todos los eventos publicados, ordenados por fecha
        public async Task<List<EventoDto>> GetEventosAsync()
        {
            return await this.GetConsultaEventos()
                .Where(e => e.Estado == "PUBLICADO")
                .OrderBy(e => e.FechaHora)
                .ToListAsync();
        }

        // Un evento por su id (publicado o cancelado). Si no existe devuelve null
        public async Task<EventoDto?> FindEventoAsync(int idEvento)
        {
            return await this.GetConsultaEventos()
                .FirstOrDefaultAsync(e => e.IdEvento == idEvento);
        }
    }
}