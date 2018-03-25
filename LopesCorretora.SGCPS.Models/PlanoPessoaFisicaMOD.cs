using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LopesCorretora.SGCPS.Models
{
    public class PlanoPessoaFisicaMOD
    {
        public int IdPlanoPessoaFisica { get; set; }

        #region DataAnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Numero do contrado", Description = "Numero de contrato, plano pessoa fisica")]
        #endregion
        public int NumeroContrato { get; set; }

        #region DataAnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Status", Description = "Status do cliente, pessoa fisica")]
        #endregion
        public string StatusDoCliente { get; set; }

        #region DataAnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Valor de entrada", Description = "Valor de entrada do plano, pessoa fisica")]
        #endregion
        public decimal ValorDeEntrada { get; set; }

        #region DataAnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Numero de parcelas", Description = "Numero de parcelas do plano, pessoa fisica")]
        #endregion
        public int NumeroDeParcelas { get; set; }

        public PlanoMOD ObjPlanoMOD { get; set; }
    }
}
