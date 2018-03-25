using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Models;

namespace LopesCorretora.SGCPS.ViewsModels
{
    public class PesquisaClienteVM
    {
        public List<PessoaFisicaMOD> LisPessoaFisicaMOD { get; set; }
        public List<PessoaJuridicaMOD> LisPessoaJuridicaMOD { get; set; }
    }
}
