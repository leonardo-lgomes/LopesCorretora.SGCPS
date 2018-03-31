using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using LopesCorretora.SGCPS.Models.ModelosComplementares;

namespace LopesCorretora.SGCPS.Models
{
    public class PessoaFisicaMOD
    {
        public int IdPessoaFisica { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="Titular",Description ="Titular, pessoa fisica")]
        #endregion
        public string Titular { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="CPF",Description = "CPF, pessoa fisica")]
        #endregion
        public string CPF { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="RG",Description = "RG, pessoa fisica")]
        #endregion
        public string RG { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="Estado civil",Description = "Estado civil, pessoa fisica")]
        #endregion
        public string EstadoCivil { get; set; }

        #region DataAnnotations
        [Display(Name ="E-mail",Description = "E-mail, pessoa fisica")]
        #endregion
        public string Email { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="Mae do titular",Description = "Mae do titular. Pessoa fisica")]
        #endregion
        public string MaeDoTitular { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="Responsavel geral",Description = "Responsavel geral,  pessoa fisica")]
        #endregion
        public string ResponsavelGeral { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="Numero do SUS",Description = "Numero do SUS, pessoa fisica")]
        #endregion
        public int NumeroDoSUS { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="Observacoes",Description = "Observacoes, pessoa fisica")]
        #endregion
        public string Observacoes { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="Documentos (anexo)",Description = "Documentos (anexo), pessoa fisica")]
        #endregion
        public string DocumentosAnexo { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="Data de nascimente",Description = "Data de nascimente, fisica")]
        #endregion
        public DateTime DataDeNascimento { get; set; }

        public EnderecoMOD ObjEnderecoMOD { get; set; }

        public PlanoPessoaFisicaMOD ObjPlanoPessoaFisicaMOD { get; set; }

        public StatusMOD ObjStatusMOD { get; set; }

        public Sexo ObjSexo { get; set; }

        public PessoaFisicaMOD()
        {
            ObjEnderecoMOD = new EnderecoMOD();
            ObjPlanoPessoaFisicaMOD = new PlanoPessoaFisicaMOD();
            ObjStatusMOD = new StatusMOD();
            ObjSexo = new Sexo();
        }

    }
}
