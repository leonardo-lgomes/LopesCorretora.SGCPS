using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Models;

//DataAccess possui o contexto da aplicacao, nada mais;

//Nomenclatura: (sugiro) NomeDaModel => no plural por se tratar de uma tabela;

//DataAccess nao tem acesso a nenhuma outra camada;

//Quem tem acesso a DataAccess: apenas Repository;

namespace LopesCorretora.SGCPS.DataAccess
{
    public class SGCPSContext : DbContext
    {
        public DbSet<ClasseMOD> ClassesMOD { get; set; }
        
    }
}
