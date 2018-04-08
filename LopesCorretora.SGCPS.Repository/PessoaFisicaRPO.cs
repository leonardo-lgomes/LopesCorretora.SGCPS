using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Repository.DataAccess;
using LopesCorretora.SGCPS.Models;
using System.Linq;
using LopesCorretora.SGCPS.Models.ModelosComplementares;

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
                    PessoaFisicaMOD ObjPessoaFisicaMOD = context.PessoasFisicas.Where(x => x.Id == pessoaFisicaMOD.Id).First();
                    ObjPessoaFisicaMOD = pessoaFisicaMOD;
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static List<ModelPesquisa> Pesquisa(string q)
        {
            //try
            //{
                IEnumerable<ModelPesquisa> ListPessoaFisicaMOD;
                List<ModelPesquisa> list = new List<ModelPesquisa>();

                using (SGCPSContext context = new SGCPSContext())
                {
                    ListPessoaFisicaMOD = from pf in context.PessoasFisicas
                                          join ppf in context.PlanoPessoasFisicas on pf.PlanoPessoaFisica.Id equals ppf.Id
                                          where q.Equals(pf.Titular.ToString()) || q.Equals(pf.PlanoPessoaFisica.NumeroContrato.ToString()) || 
                                          q.Equals(pf.CPF.ToString()) || q.Equals(pf.Observacoes.ToString())
                                          select new ModelPesquisa { Nome = pf.Titular, Documento = pf.CPF, Observacoes = pf.Observacoes, NumeroContrato = pf.PlanoPessoaFisica.NumeroContrato };

                    if (ListPessoaFisicaMOD.Count() > 0)
                    {
                        foreach (var item in ListPessoaFisicaMOD)
                        {
                            list.Add(item);
                        }
                    }
                }
                return list;
            //}
            //catch (Exception e)
            //{
            //    throw;
            //}
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
                    return context.PessoasFisicas.Where(x => x.Id == Id).First();
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
                    return (List<PessoaFisicaMOD>)context.PessoasFisicas.Where(x => x.Titular == Titular);
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
