using Microsoft.EntityFrameworkCore;
using SMWebApp.Models;

namespace SMWebApp.Data
{
    public class SMWebDBContext : DbContext
    {
        public SMWebDBContext(DbContextOptions<SMWebDBContext> options) : base(options)
        {             
        }

        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Recibo> Recibos { get; set; }


    }
}
