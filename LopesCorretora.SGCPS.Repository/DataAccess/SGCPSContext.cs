using LopesCorretora.SGCPS.Models;
using Microsoft.EntityFrameworkCore;
using LopesCorretora.SGCPS.Models.ModelosComplementares;

namespace LopesCorretora.SGCPS.Repository.DataAccess
{
    internal class SGCPSContext : DbContext
    {
        public DbSet<ContatoPessoaFisicaMOD> ContatosPessoasFisicas { get; set; }
        public DbSet<ContatoPessoaJuridicaMOD> ContatosPessoasJuridicas { get; set; }
        public DbSet<DependentePessoaFisicaMOD> DependentesPessoasFisicas { get; set; }
        public DbSet<EnderecoMOD> Enderecos { get; set; }
        public DbSet<PessoaFisicaMOD> PessoasFisicas { get; set; }
        public DbSet<PessoaJuridicaMOD> PessoasJuridicas { get; set; }
        public DbSet<PlanoMOD> Planos { get; set; }
        public DbSet<PlanoPessoaFisicaMOD> PlanoPessoasFisicas { get; set; }
        public DbSet<PlanoPessoaJuridicaMOD> PlanoPessoasJuridicas { get; set; }
        public DbSet<StatusMOD> Status { get; set; }
        public DbSet<UsuarioMOD> Usuarios { get; set; }
        public DbSet<Sexo> Sexo { get; set; }

        public SGCPSContext(DbContextOptions<SGCPSContext> options) : base(options)
        {
        }

        public SGCPSContext()
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
