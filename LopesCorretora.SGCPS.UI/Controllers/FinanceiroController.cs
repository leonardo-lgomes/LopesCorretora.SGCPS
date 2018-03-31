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
    public class FinanceiroController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BalancoAnual()
        {
            return View();
        }

        [HttpGet]
        public IActionResult BalancoMensal()
        {
            return View();
        }

        [HttpGet]
        public IActionResult ControleDespesas()
        {
            return View();
        }

        [HttpGet]
        public IActionResult DarBaixa()
        {
            return View();
        }
    }
}