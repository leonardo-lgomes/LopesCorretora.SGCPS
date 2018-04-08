using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Models;
using LopesCorretora.SGCPS.Repository;
using LopesCorretora.SGCPS.ViewsModels;
using LopesCorretora.SGCPS.Models.ModelosComplementares;
using System.Linq;

namespace LopesCorretora.SGCPS.Business
{
    public class ClienteBUS
    {
        public static PesquisaClienteVM Pesquisa(string q)
        {
            PesquisaClienteVM pesquisaClienteVM = new PesquisaClienteVM();

            IEnumerable<ModelPesquisa> iePessoaJuridica = PessoaJuridicaRPO.Pesquisa(q);
            IEnumerable<ModelPesquisa> iePessoaFisica = PessoaFisicaRPO.Pesquisa(q);

            ConverterParaList(pesquisaClienteVM, iePessoaJuridica, iePessoaFisica);

            if (pesquisaClienteVM.ListModelPesquisa.Count > 0)
                pesquisaClienteVM.ListModelPesquisa.OrderBy(x => x.Nome);
            return pesquisaClienteVM;
        }

        private static void ConverterParaList(PesquisaClienteVM pesquisaClienteVM, IEnumerable<ModelPesquisa> iePessoaJuridica, IEnumerable<ModelPesquisa> iePessoaFisica)
        {
            if (iePessoaJuridica != null)
            {
                if (iePessoaJuridica.Count() > 0)
                {
                    foreach (var item in iePessoaJuridica)
                    {
                        pesquisaClienteVM.ListModelPesquisa.Add(item);
                    }
                }
            }
            if (iePessoaFisica != null)
            {
                if (iePessoaFisica.Count() > 0)
                {
                    foreach (var item in iePessoaFisica)
                    {
                        pesquisaClienteVM.ListModelPesquisa.Add(item);
                    }
                }
            }
        }
    }
}
