using ApiBlablamar.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiBlablamar.Data
{
    public class BlaBlaMarContext : DbContext
    {
        public BlaBlaMarContext(DbContextOptions<BlaBlaMarContext> options) : base(options) { }

        // ----- Tablas del profe (solo lectura) -----
        public DbSet<Usuario> Usuarios => Set<Usuario>();
        public DbSet<Curso> Cursos => Set<Curso>();
        public DbSet<CursoUsuario> CursosUsuarios => Set<CursoUsuario>();

        // ----- Tablas propias -----
        public DbSet<Evento> Eventos => Set<Evento>();
        public DbSet<Asistencia> Asistencias => Set<Asistencia>();
        public DbSet<Viaje> Viajes => Set<Viaje>();
        public DbSet<Caracteristica> Caracteristicas => Set<Caracteristica>();
        public DbSet<ViajeCaracteristica> ViajesCaracteristicas => Set<ViajeCaracteristica>();
        public DbSet<Solicitud> Solicitudes => Set<Solicitud>();
        public DbSet<Notificacion> Notificaciones => Set<Notificacion>();

        // ----- Vista -----
        public DbSet<VistaViaje> VistaViajes => Set<VistaViaje>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // PK compuesta de la tabla N:M
            modelBuilder.Entity<ViajeCaracteristica>()
                .HasKey(vc => new { vc.IdViaje, vc.IdCaracteristica });

            // La vista no tiene PK y solo se lee
            modelBuilder.Entity<VistaViaje>()
                .HasNoKey()
                .ToView("VW_VIAJES");
        }
    }
}
