using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Models;
using LopesCorretora.SGCPS.Models.ModeloDaAplicacao;
using LopesCorretora.SGCPS.Repository.ModeloDaAplicacao;
using LopesCorretora.SGCPS.Repository.DataAccess;

//Business contem apenas regras de negocio, 
//implementar aqui metodos que seram usados nos Controllers da camada de UI;

//Para cada Modelo uma classe de Business;

//Nomenclatura: NomeDaModelBUS;

//Business tem acesso apenas as camadas de Models, Repository e ViewsModels;

//Quem tem acesso a Business: apenas a camada de UI;

namespace LopesCorretora.SGCPS.Business.ModeloDaAplicacao
{
    public class ClasseBUS
    {
        public static void FinanceiroIndexGet()
        {
            ClasseRPO.CadastrarClasse(new ClasseMOD(1, "", ""));
        }
    }
}
