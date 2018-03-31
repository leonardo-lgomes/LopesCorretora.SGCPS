using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Models;

namespace LopesCorretora.SGCPS.ViewsModels
{
    public class CadastrarPessoaJuridicaVM
    {
        public PessoaJuridicaMOD ObjPessoaJuridicaMOD { get; set; }
        public PlanoPessoaJuridicaMOD ObjPlanoPessoaJuridicaMOD { get; set; }
        public UsuarioMOD ObjUsuarioMOD { get; set; }
        public List<ContatoPessoaJuridicaMOD> LisContatoPessoaJuridicaMOD { get; set; }
        public List<PlanoMOD> LisPlanoMOD { get; set; }
        public List<int> LisNumeroDeParcelas { get; set; }


    }
}
