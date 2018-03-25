using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Models.ModeloDaAplicacao;
using LopesCorretora.SGCPS.Repository.DataAccess;

//Repository contem todos os metodos de acesso a dados (CRUD);

//Nao se deve aplicar regras de negocio aqui;

//Para cada Modelo uma classe de Repository;

//Nomenclatura: NomeDaModelRPO;

//Repository tem acesso a Models e DataAccess;

//Quem tem acesso a Repository: apenas Business;

namespace LopesCorretora.SGCPS.Repository.ModeloDaAplicacao
{
    public class ClasseRPO 
    {
        public static void CadastrarClasse(ClasseMOD ObjClasseMOD)
        {
            using (SGCPSContext contexto = new SGCPSContext())
            {
                contexto.Add(ObjClasseMOD);
            }
        }
    }
}
