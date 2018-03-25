using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LopesCorretora.SGCPS.Business;
using LopesCorretora.SGCPS.Models;
using LopesCorretora.SGCPS.ViewsModels;


namespace LopesCorretora.SGCPS.UI.Controllers
{
    public class ClienteController : Controller
    {
        public IActionResult Pesquisa()
        {
            return View(new PesquisaClienteVM());
        }
    }
}