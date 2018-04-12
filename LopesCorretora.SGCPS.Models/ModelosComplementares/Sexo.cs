using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LopesCorretora.SGCPS.Models.ModelosComplementares
{
    public class Sexo
    {
        [Key]
        [Required]
        public int IdSexo { get; set; }

        public string StrSexo { get; set; }
    }
}
