﻿using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LopesCorretora.SGCPS.Models
{
    public class UsuarioMOD
    {
        #region DataAnnotations
        [Key]
        [Required(ErrorMessage = "* Campo obrigatorio")]
        [Display(Name = "ID Usuario", Description = "ID, usuario")]
        #endregion
        public int Id { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "* Campo obrigatorio")]
        [Display(Name = "Concessionario", Description = "Concessionario, usuario")]
        #endregion
        public string Concessionario { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "* Campo obrigatorio")]
        [Display(Name = "CPF", Description = "CPF, usuario")]
        #endregion
        public string CPF { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "* Campo obrigatorio")]
        [Display(Name = "Nome", Description = "Nome, usuario")]
        #endregion
        public string Nome { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "* Campo obrigatorio")]
        [Display(Name = "Celular", Description = "Celular, usuario")]
        #endregion
        public string Celular { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "* Campo obrigatorio")]
        [Display(Name = "Email", Description = "E-mail, usuario")]
        #endregion
        public string Email { get; set; }

    }
}
