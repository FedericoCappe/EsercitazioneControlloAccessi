using Microsoft.EntityFrameworkCore;
using EsercitazioneControlloAccessi.Entities;
namespace EsercitazioneControlloAccessi
{
    public class ControlloAccessiDbContext : DbContext
    {


        public ControlloAccessiDbContext() : base() { }

        public ControlloAccessiDbContext(DbContextOptions<ControlloAccessiDbContext> options)
            : base(options) { }

        public DbSet<Dipendente> Dipendenti { get; set; }
        public DbSet<Ruolo> Ruoli { get; set; }
        public DbSet<AziendaOspite> Aziende { get; set; }

        public DbSet<Visita> Visite { get; set; }

        public DbSet<Wifi> Wifi { get; set; }
        public DbSet<PostoAuto> PostiAuto { get; set; }
        public DbSet<Ospite> Ospiti { get; set; }


    }
}
