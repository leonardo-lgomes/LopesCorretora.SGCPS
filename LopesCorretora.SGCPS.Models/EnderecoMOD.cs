using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LopesCorretora.SGCPS.Models
{
    public class EnderecoMOD
    {
        public int IdEndereço { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="UF",Description ="Estado, pessoa fisica")]
        #endregion
        public string UF { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="Cidade", Description = "Cidade, pessoa fisica")]
        #endregion
        public string Cidade { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="Bairro",Description = "Nome do Bairro, pessoa fisica")]
        #endregion
        public string Bairro { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="Rua",Description = "Nome da Rua. Pessoa fisica")]
        #endregion
        public string Rua { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="Numero",Description = "Numero endereco, pessoa fisica")]
        #endregion
        public int Numero { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="Complemento",Description = "Complemento do endereco. Pessoa fisica")]
        #endregion
        public string Complemento { get; set; }

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name ="CEP",Description = "CEP, pessoa fisica")]
        #endregion
        public int CEP { get; set; }
    }
}
