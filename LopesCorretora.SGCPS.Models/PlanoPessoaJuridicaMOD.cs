using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LopesCorretora.SGCPS.Models
{
    public class PlanoPessoaJuridicaMOD
    {
        #region DataAnnotations
        [Key]
        [Required(ErrorMessage = "* Campo obrigatorio")]
        [Display(Name = "ID Plano Pessoa Juridica", Description = "ID Plano, pessoa juridica")]
        #endregion
        public int Id { get; set; }

        private bool participacao;

        private bool odontologia;

        #region DataAnnotations
        [Required(ErrorMessage = "* Campo obrigatorio")]
        [Display(Name = "Numero do Contrato", Description = "Numero do Contrato, pessoa juridica")]
        #endregion
        public string NumeroContrato { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "* Campo obrigatorio")]
        [Display(Name = "Valor de Entrada", Description = "Valor de Entrada, pessoa juridica")]
        #endregion
        public decimal ValorDeEntrada { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "* Campo obrigatorio")]
        [Display(Name = "Numero de Parcelas", Description = "Numero de Parcelas, pessoa juridica")]
        #endregion
        public int NumeroDeParcelas { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "* Campo obrigatorio")]
        [Display(Name = "Numero Do Beneficiarios", Description = "Numero Do Beneficiarios, pessoa juridica")]
        #endregion
        public int NumeroDoBeneficiarios { get; set; }

        public string Observacoes { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "* Campo obrigatorio")]
        [Display(Name = "Participacao", Description = "Participacao, pessoa juridica")]
        #endregion
        public string Participacao
        {
            get { return participacao == true ? "Com participacao" : "Sem participacao"; }
            set { participacao = Convert.ToBoolean(value); }
        }

        #region DataAnnotations
        [Required(ErrorMessage = "* Campo obrigatorio")]
        [Display(Name = "Odontologia", Description = "Odontologia, pessoa juridica")]
        #endregion
        public string Odontologia
        {
            get { return odontologia == true ? "Com odontologia" : "Sem odontologia"; }
            set { odontologia = Convert.ToBoolean(value); }
        }

        public string QualOdonto { get; set; }

        public PlanoMOD Plano { get; set; }

        public UsuarioMOD Usuario { get; set; }

        public PessoaJuridicaMOD PessoaJuridica { get; set; }

        public PlanoPessoaJuridicaMOD()
        {
            Plano = new PlanoMOD();
            Usuario = new UsuarioMOD();
            PessoaJuridica = new PessoaJuridicaMOD();
        }
    }
}
