using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Models;
using LopesCorretora.SGCPS.Repository;
using LopesCorretora.SGCPS.ViewsModels;

namespace LopesCorretora.SGCPS.Business
{
    public class PlanoBUS
    {
        public static PlanoMOD CadastrarPlano(PlanoMOD planoMOD)
        {
            try
            {
                PlanoRPO.Cadastrar(planoMOD);
                return planoMOD;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
