using ApiBlablamar.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ApiBlablamar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PruebasController : ControllerBase
    {
        private BlaBlaMarContext context;

        // Inyección de dependencias: la app te da el contexto que registraste en Program.cs
        public PruebasController(BlaBlaMarContext context)
        {
            this.context = context;
        }

        // GET /api/pruebas/conexion
        [HttpGet("conexion")]
        public async Task<IActionResult> Conexion()
        {
            // 1) Lee una fila de cada tabla. Si alguna columna de tus Models
            //    no coincide con la BBDD, aquí saltará un error diciendo cuál.
            await this.context.Usuarios.Take(1).ToListAsync();
            await this.context.Cursos.Take(1).ToListAsync();
            await this.context.CursosUsuarios.Take(1).ToListAsync();
            await this.context.Eventos.Take(1).ToListAsync();
            await this.context.Asistencias.Take(1).ToListAsync();
            await this.context.Viajes.Take(1).ToListAsync();
            await this.context.VistaViajes.Take(1).ToListAsync();
            await this.context.Caracteristicas.Take(1).ToListAsync();
            await this.context.ViajesCaracteristicas.Take(1).ToListAsync();
            await this.context.Solicitudes.Take(1).ToListAsync();
            await this.context.Notificaciones.Take(1).ToListAsync();

            // 2) Devuelve cuántas filas hay en cada tabla
            return Ok(new
            {
                conexion = "OK",
                usuarios = await this.context.Usuarios.CountAsync(),
                cursosUsuarios = await this.context.CursosUsuarios.CountAsync(),
                eventos = await this.context.Eventos.CountAsync(),
                viajes = await this.context.Viajes.CountAsync(),
                caracteristicas = await this.context.Caracteristicas.CountAsync(),
                solicitudes = await this.context.Solicitudes.CountAsync(),
                notificaciones = await this.context.Notificaciones.CountAsync()
            });
        }
    }
}