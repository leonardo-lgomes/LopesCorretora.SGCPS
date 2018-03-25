using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LopesCorretora.SGCPS.Business;
using LopesCorretora.SGCPS.Models;
using LopesCorretora.SGCPS.ViewsModels;
using LopesCorretora.SGCPS.UI;

namespace LopesCorretora.SGCPS.UI.Controllers
{
    public class PessoaJuridicaController : Controller
    {
        public IActionResult Cadastrar()
        {
            return View();
        }

        public IActionResult Alterar()
        {
            return View();
        }

    }
}