using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Repository.DataAccess;
using LopesCorretora.SGCPS.Models;
using System.Linq;

namespace LopesCorretora.SGCPS.Repository
{
    public class PlanoRPO
    {
        public static void Alterar(PlanoMOD planoMOD)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    context.Planos.Update(planoMOD);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Cadastrar(PlanoMOD planoMOD)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    context.Planos.Add(planoMOD);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Consultar()
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
