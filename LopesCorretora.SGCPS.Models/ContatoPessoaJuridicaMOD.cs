using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using LopesCorretora.SGCPS.Models;

namespace LopesCorretora.SGCPS.Models
{
    public class ContatoPessoaJuridicaMOD
    {
        public int IdContato { get; set; }

        #region DataAnnotations
        [MinLength(10)]
        [MaxLength(12)]
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Contato", Description = "Numero de contato")]
        #endregion
        public string Contato { get; set; }

        public PessoaJuridicaMOD ObjPessoaJuridicaMOD { get; set; }

        public ContatoPessoaJuridicaMOD(PessoaJuridicaMOD pessoaJuridicaMOD)
        {
            ObjPessoaJuridicaMOD = pessoaJuridicaMOD;
        }

        public ContatoPessoaJuridicaMOD()
        {

        }
    }
}
