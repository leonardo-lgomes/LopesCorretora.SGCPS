using LopesCorretora.SGCPS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

//DataAccess possui o contexto da aplicacao, nada mais;

//DataAccess nao tem acesso a nenhuma outra camada;

//Quem tem acesso a DataAccess: apenas Repository;

namespace LopesCorretora.SGCPS.Repository.DataAccess
{
    internal class SGCPSContext : DbContext
    {
        public DbSet<ContatoPessoaFisicaMOD> ContatosPessoasFisicas { get; set; }
        public DbSet<DependentePessoaFisicaMOD> DependentesPessoasFisicas { get; set; }
        public DbSet<EnderecoMOD> Enderecos { get; set; }
        public DbSet<PessoaFisicaMOD> PessoasFisicas { get; set; }
        public DbSet<PlanoPessoaFisicaMOD> PlanoPessoasFisicas { get; set; }
        public DbSet<PlanoMOD> Planos { get; set; }
        public DbSet<StatusMOD> Status { get; set; }
        public DbSet<PessoaJuridicaMOD> PessoasJuridicas { get; set; }
        public DbSet<PlanoPessoaJuridicaMOD> PlanoPessoasJuridicas { get; set; }
        public DbSet<UsuarioMOD> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}
