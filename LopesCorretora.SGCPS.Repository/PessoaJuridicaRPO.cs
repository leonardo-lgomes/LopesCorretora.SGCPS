using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Repository.DataAccess;
using LopesCorretora.SGCPS.Models;
using LopesCorretora.SGCPS.Models.ModelosComplementares;
using System.Linq;

namespace LopesCorretora.SGCPS.Repository
{
    public class PessoaJuridicaRPO
    {
        public static void Alterar(PessoaFisicaMOD pessoaJuridicaMOD)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    //context.PessoasJuridicas.Where(x => x. = pessoaJuridicaRPO)
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static void Cadastrar(PlanoPessoaFisicaMOD planoPessoaFisicaMOD)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    context.PlanoPessoasFisicas.Add(planoPessoaFisicaMOD);
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

        public static List<ModelPesquisa> Pesquisa(string q)
        {
            try
            {
                IEnumerable<ModelPesquisa> ListPessoaJuridicas;
                List<ModelPesquisa> list = new List<ModelPesquisa>();
                using (SGCPSContext context = new SGCPSContext())
                {
                    ListPessoaJuridicas = from pj in context.PessoasJuridicas
                                          join ppj in context.PlanoPessoasJuridicas on pj.Id equals ppj.PessoaJuridica.Id
                                          where q.ToLower().Equals(pj.RazaoSocial.ToString().ToLower()) ||
                                          q.ToLower().Equals(ppj.NumeroContrato.ToString().ToLower()) ||
                                          q.ToLower().Equals(pj.CNPJ.ToString().ToLower()) ||
                                          q.ToLower().Equals(ppj.Observacoes.ToString().ToLower())
                                          select new ModelPesquisa
                                          {
                                              Nome = pj.RazaoSocial,
                                              Documento = pj.CNPJ,
                                              Observacoes = ppj.Observacoes,
                                              NumeroContrato = ppj.NumeroContrato,
                                              Id = pj.Id,
                                              Tipo = "PessoaJuridica"
                                          };
                    foreach (var item in ListPessoaJuridicas)
                    {
                        list.Add(item);
                    }
                }
                return list;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
