using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace LopesCorretora.SGCPS.Repository
{
    class ContextoContext : DbContext
    {
        public DbSet<ContatoPessoaFisicaMOD> ContatosPessoasFisicas { get; set; }


        public ContextoContext(DbContextOptions<ContextoContext> options) : base(options)
        {
        }

        public ContextoContext()
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=douglasmacha1f7;Initial Catalog=SGCPS;Integrated Security=True");
        }

    }
}
