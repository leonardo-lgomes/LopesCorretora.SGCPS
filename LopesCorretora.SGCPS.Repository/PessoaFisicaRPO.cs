using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Repository.DataAccess;
using LopesCorretora.SGCPS.Models;
using System.Linq;

namespace LopesCorretora.SGCPS.Repository
{
    public class PessoaFisicaRPO
    {
        public static void Alterar(PessoaFisicaMOD pessoaFisicaMOD)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    PessoaFisicaMOD ObjPessoaFisicaMOD = context.PessoasFisicas.Where(x => x.IdPessoaFisica == pessoaFisicaMOD.IdPessoaFisica).First();
                    ObjPessoaFisicaMOD = pessoaFisicaMOD;
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Cadastrar(PessoaFisicaMOD pessoaFisicaMOD)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    context.PessoasFisicas.Add(pessoaFisicaMOD);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static PessoaFisicaMOD Consultar(int Id)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    return context.PessoasFisicas.Where(x => x.IdPessoaFisica == Id).First();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<PessoaFisicaMOD> Consultar(string Titular)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    return (List<PessoaFisicaMOD>) context.PessoasFisicas.Where(x => x.Titular == Titular);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
