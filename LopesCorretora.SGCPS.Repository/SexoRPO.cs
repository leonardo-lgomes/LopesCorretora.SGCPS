using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Repository.DataAccess;
using LopesCorretora.SGCPS.Models;
using LopesCorretora.SGCPS.Models.ModelosComplementares;
using System.Linq;

namespace LopesCorretora.SGCPS.Repository
{
    public class SexoRPO
    {
        public static List<Sexo> Listar()
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    return context.Sexo.ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
