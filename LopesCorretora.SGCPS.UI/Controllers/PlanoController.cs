using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using LopesCorretora.SGCPS.Business;
using LopesCorretora.SGCPS.Models;
using LopesCorretora.SGCPS.ViewsModels;
using LopesCorretora.SGCPS.UI;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LopesCorretora.SGCPS.UI.Controllers
{
    public class PlanoController : Controller
    {
        // GET: /<controller>/
        [HttpGet]
        public IActionResult Cadastrar()
        {
            return View(new PlanoMOD());
        }

        [HttpPost]
        public IActionResult Cadastrar(PlanoMOD planoMOD)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    PlanoBUS.CadastrarPlano(planoMOD);
                    #region mensagem
                    ViewBag.Mensagem = "Plano cadastrado com sucesso!";
                    ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                    ViewBag.Class = "alert alert-success";
                    #endregion
                    return View(planoMOD);
                }
                catch (Exception)
                {
                    #region mensagem
                    ViewBag.Mensagem = "Erro ao cadastrar plano!";
                    ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                    ViewBag.Class = "alert alert-danger";
                    #endregion
                    return View(planoMOD);
                }
            }
            else
            {
                #region mensagem
                ViewBag.Mensagem = "Preenchimento invalido!";
                ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                ViewBag.Class = "alert alert-danger";
                #endregion
                return View(planoMOD);
            }
        }

        public IActionResult Listar()
        {
            return View();
        }
    }
}
