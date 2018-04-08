using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LopesCorretora.SGCPS.Models.ModelosComplementares
{
    public class Sexo
    {
        [Key]
        public int IdSexo { get; set; }

        [Required]
        public bool sexo;

        #region DataAnnotations
        [Required(ErrorMessage = "Campo obrigatorio")]
        [Display(Name = "Sexo", Description = "Sexo, pessoa fisica")]
        #endregion
        public string StrSexo
        {
            get { return sexo == true ? "Masculino" : "Feminino"; }
            set
            {
                sexo = value.ToString().ToLower().Equals("masculino") ? true :
                  value.ToString().ToLower().Equals("feminino") ? false : throw new Exception();
            }
        }

        public Sexo()
        {
                
        }

        public Sexo(string sexo)
        {
            try
            {
                StrSexo = sexo;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Sexo> sexos()
        {
            List<Sexo> sexos = new List<Sexo>() { new Sexo("Masculino"), new Sexo("Feminino") };
            return sexos;
        }
    }
}
