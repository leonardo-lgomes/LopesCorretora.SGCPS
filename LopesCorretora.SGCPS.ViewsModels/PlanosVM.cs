using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Models;
namespace LopesCorretora.SGCPS.ViewsModels
{
    public class PlanosVM
    {
        public List<PlanoMOD> ListPlanosMOD { get; set; }
        public PlanoMOD planoMOD { get; set; }
    }
}
