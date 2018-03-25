using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Models;
using LopesCorretora.SGCPS.Models.ModelosComplementares;

namespace LopesCorretora.SGCPS.ViewsModels
{
    public class AlterarPessoaFisicaVM
    {
        public PessoaFisicaMOD ObjPessoaFisicaMOD { get; set; }
        public List<PlanoMOD> LisPlanosMOD { get; set; }
        public List<DependentePessoaFisicaMOD> LisDependentePessoaFisicaMOD { get; set; }
        public List<ContatoPessoaFisicaMOD> LisContatoPessoaFisicaMOD { get; set; }
        public List<Sexo> LisSexo { get; set; }
        public List<StatusMOD> LisStatusMOD { get; set; }
        public List<string> LisNumeroDeParcelas { get; set; }
        public List<string> LisEstadoCivil { get; set; }
    }
}
