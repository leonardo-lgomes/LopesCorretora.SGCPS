﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace LopesCorretora.SGCPS.Models
{
    public class PlanoMOD
    {
        #region DataAnnotation
        [Key]
        #endregion
        public int Id { get; set; }
        
        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [MinLength(10, ErrorMessage = "Telefone invalido")]
        [MaxLength(12, ErrorMessage = "Telefone invalido")]
        [Display(Name = "Telefone do Plano", Description = "Telefone de contato do plano")]
        #endregion
        public string TelefoneDoPlano { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Plano", Description = "Nome do Plano")]
        #endregion
        public string Plano { get; set; }

    }
}
