using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LopesCorretora.SGCPS.Models
{
    public class ContatoPessoaFisicaMOD
    {
        public int IdPessoaFisica { get; set; }

        #region DataAnnotations
        [MinLength(10)]
        [MaxLength(12)]
        [Required(ErrorMessage ="Campo obrigatorio")]
        [Display(Name ="Contato", Description ="Numero de contato")]
        #endregion
        public string Contato { get; set; }

        public PessoaFisicaMOD ObjPessoaFisicaMOD { get; set; }

        public ContatoPessoaFisicaMOD(PessoaFisicaMOD pessoaFisicaMOD)
        {
            ObjPessoaFisicaMOD = pessoaFisicaMOD;
        }
        public ContatoPessoaFisicaMOD()
        {

        }
    }
}
