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
        [HttpGet]
        public IActionResult Pesquisa()
        {
            return View(new PesquisaClienteVM());
        }

        [HttpPost]
        public IActionResult Pesquisa(string q)
        {
            PesquisaClienteVM pesquisaClienteVM = ClienteBUS.Pesquisa(q);
            if (pesquisaClienteVM.ListModelPesquisa.Count == 0)
            {
                #region mensagem
                ViewBag.Mensagem = "Nenhum resultado encontrado!";
                ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                ViewBag.Class = "alert alert-warning";
                #endregion
            }
            else if (pesquisaClienteVM.ListModelPesquisa != null)
            {
                #region mensagem
                ViewBag.Mensagem = "Erro!";
                ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                ViewBag.Class = "alert alert-danger";
                #endregion
            }
            else
            {
                #region mensagem
                ViewBag.Mensagem = pesquisaClienteVM.ListModelPesquisa.Count + "Resultados encontrados!";
                ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                ViewBag.Class = "alert alert-danger";
                #endregion
            }
            return View(pesquisaClienteVM);
        }

        [HttpGet]
        public RedirectToActionResult Redirecionar(int Id, string Tipo)
        {
            if (Tipo.Equals("PessoaJuridica"))
            {
                return RedirectToAction("Alterar", "PessoaJuridica", new { Id = Id });
            }
            else
            {
                return RedirectToAction("Alterar", "PessoaFisica", new { Id = Id });
            }
        }

        [HttpGet]
        public IActionResult Cadastro()
        {
            return View();
        }
    }
}