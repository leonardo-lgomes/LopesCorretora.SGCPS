using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace LopesCorretora.SGCPS.Models
{
    public class StatusMOD
    {
        [Required(ErrorMessage ="* Campo obrigatorio")]
        public int IdStatus { get; set; }
        public string Status { get; set; }
    }
}
