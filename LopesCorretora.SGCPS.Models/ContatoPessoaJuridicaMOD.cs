using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using LopesCorretora.SGCPS.Models;

namespace LopesCorretora.SGCPS.Models
{
    public class ContatoPessoaJuridicaMOD
    {
        #region DataAnnotation
        [Key]
        #endregion
        public int Id { get; set; }

        #region DataAnnotations
        [MinLength(10)]
        [MaxLength(12)]
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Contato", Description = "Numero de contato")]
        #endregion
        public string Contato { get; set; }

        public PessoaJuridicaMOD PessoaJuridica { get; set; }

        public ContatoPessoaJuridicaMOD(PessoaJuridicaMOD pessoaJuridicaMOD)
        {
            PessoaJuridica = pessoaJuridicaMOD;
        }

        public ContatoPessoaJuridicaMOD()
        {

        }
    }
}
