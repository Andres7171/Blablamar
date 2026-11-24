using ApiBlablamar.DTOs;
using ApiBlablamar.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ApiBlablamar.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CaracteristicasController : ControllerBase
    {
        private RepositoryCaracteristicas repo;

        public CaracteristicasController(RepositoryCaracteristicas repo)
        {
            this.repo = repo;
        }

        // GET /api/caracteristicas
        [HttpGet]
        public async Task<ActionResult<List<CaracteristicaDto>>> GetCaracteristicas()
        {
            return await this.repo.GetCaracteristicasAsync();
        }

        // GET /api/caracteristicas/2
        [HttpGet("{id}")]
        public async Task<ActionResult<CaracteristicaDto>> FindCaracteristica(int id)
        {
            CaracteristicaDto? caracteristica = await this.repo.FindCaracteristicaAsync(id);
            if (caracteristica == null)
            {
                return NotFound();
            }
            return caracteristica;
        }
    }
}