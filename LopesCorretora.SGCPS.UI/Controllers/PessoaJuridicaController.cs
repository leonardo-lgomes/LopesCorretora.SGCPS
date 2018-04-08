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
        [HttpGet]
        public IActionResult Cadastrar()
        {
            try
            {
                CadastrarPessoaJuridicaVM cadastrarPessoaJuridicaVM = PessoaJuridicaBUS.CadastrarPessoaJuridicaVMGet();
                if (cadastrarPessoaJuridicaVM != null)
                {
                    return View(PessoaJuridicaBUS.CadastrarPessoaJuridicaVMGet());
                }
            }
            catch (Exception)
            {
                return View();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarPessoaJuridicaVM cadastrarPessoaJuridicaVM)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    #region mensagem
                    ViewBag.Mensagem = "Pessoa Juridica cadastrada com sucesso!";
                    ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                    ViewBag.Class = "alert alert-danger";
                    #endregion
                    return View(PessoaJuridicaBUS.CadastrarPessoaJuridicaVMPost(cadastrarPessoaJuridicaVM));
                }
                catch (Exception)
                {
                    #region mensagem
                    ViewBag.Mensagem = "Erro, ao cadastrar pessoa juridica!";
                    ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                    ViewBag.Class = "alert alert-danger";
                    #endregion
                    return View(PessoaJuridicaBUS.CadastrarPessoaJuridicaVMPost(cadastrarPessoaJuridicaVM));
                }
            }
            else
            {
                #region mensagem
                ViewBag.Mensagem = "Campos obrigatorios nao preenchidos!";
                ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                ViewBag.Class = "alert alert-danger";
                #endregion
                return View(PessoaJuridicaBUS.CadastrarPessoaJuridicaVMPost(cadastrarPessoaJuridicaVM));
            }
        }

        [HttpGet]
        public IActionResult Alterar()
        {

            return View();
        }

        [HttpPost]
        public IActionResult Alterar(AlterarPessoaJuridicaVM alterarPessoaJuridicaVM)
        {

            return View();
        }
    }
}