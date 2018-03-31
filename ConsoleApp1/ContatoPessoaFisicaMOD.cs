using System.ComponentModel.DataAnnotations;


namespace LopesCorretora.SGCPS.Repository
{
    public class ContatoPessoaFisicaMOD
    {
        #region DataAnnotations
        [MinLength(10)]
        [MaxLength(12)]
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Contato", Description = "Numero de contato")]
        #endregion
        public string Contato { get; set; }

       

        public ContatoPessoaFisicaMOD()
        {

        }
    }
}