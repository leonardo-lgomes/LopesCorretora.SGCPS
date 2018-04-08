using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Models;
using LopesCorretora.SGCPS.Models.ModelosComplementares;

namespace LopesCorretora.SGCPS.ViewsModels
{
    public class PesquisaClienteVM
    {
        public List<ModelPesquisa> ListModelPesquisa { get; set; }

        public PesquisaClienteVM()
        {
            ListModelPesquisa = new List<ModelPesquisa>();
        }
    }
}
