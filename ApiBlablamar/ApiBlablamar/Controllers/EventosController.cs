using ApiBlablamar.DTOs;
using ApiBlablamar.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlablamar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventosController : ControllerBase
    {
        private RepositoryEventos repo;

        public EventosController(RepositoryEventos repo)
        {
            this.repo = repo;
        }

        // GET /api/eventos
        [HttpGet]
        public async Task<ActionResult<List<EventoDto>>> GetEventos()
        {
            return await this.repo.GetEventosAsync();
        }

        // GET /api/eventos/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EventoDto>> FindEvento(int id)
        {
            EventoDto? evento = await this.repo.FindEventoAsync(id);
            if (evento == null)
            {
                return NotFound();      // 404: no existe ese evento
            }
            return evento;              // 200 con el evento en JSON
        }
    }
}