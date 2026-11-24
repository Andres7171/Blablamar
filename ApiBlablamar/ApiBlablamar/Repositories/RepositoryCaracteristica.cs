using ApiBlablamar.Data;
using ApiBlablamar.DTOs;
using Microsoft.EntityFrameworkCore;

namespace ApiBlablamar.Repositories
{
    public class RepositoryCaracteristicas
    {
        private BlaBlaMarContext context;

        public RepositoryCaracteristicas(BlaBlaMarContext context)
        {
            this.context = context;
        }

        public async Task<List<CaracteristicaDto>> GetCaracteristicasAsync()
        {
            return await this.context.Caracteristicas
                .OrderBy(c => c.Nombre)
                .Select(c => new CaracteristicaDto
                {
                    IdCaracteristica = c.IdCaracteristica,
                    Nombre = c.Nombre,
                    Icono = c.Icono
                })
                .ToListAsync();
        }

        public async Task<CaracteristicaDto?> FindCaracteristicaAsync(int idCaracteristica)
        {
            return await this.context.Caracteristicas
                .Where(c => c.IdCaracteristica == idCaracteristica)
                .Select(c => new CaracteristicaDto
                {
                    IdCaracteristica = c.IdCaracteristica,
                    Nombre = c.Nombre,
                    Icono = c.Icono
                })
                .FirstOrDefaultAsync();
        }
    }
}