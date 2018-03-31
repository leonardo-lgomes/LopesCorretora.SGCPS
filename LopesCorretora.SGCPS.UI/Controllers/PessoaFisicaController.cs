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
    public class PessoaFisicaController : Controller
    {
        #region Cadastrar Pessoa Fisica
        [HttpGet]
        public IActionResult Cadastrar()
        {
            CadastrarPessoaFisicaVM cadastrarPessoaFisicaVM = PessoaFisicaBUS.CadastrarPessoaFisicaVM();
            if (cadastrarPessoaFisicaVM != null)
            {
                return View(cadastrarPessoaFisicaVM);
            }
            else
            {
                ViewBag.Mensagem = "Erro!";
                ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                ViewBag.Class = "alert alert-danger";
                return View("retornar view de erro 404");
            }
        }

        [HttpPost]
        public IActionResult Cadastrar(CadastrarPessoaFisicaVM cadastrarPessoaFisicaVM)
        {

            if (ModelState.IsValid)
            {
                try
                {
                    PessoaFisicaBUS.ActionCadastrarPessoaFisica(cadastrarPessoaFisicaVM);
                    ViewBag.Mensagem = "Usuario cadastrado com sucesso!";
                    ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                    ViewBag.Class = "alert alert-success";
                    Cadastrar();
                }
                catch (Exception)
                {
                    ViewBag.Mensagem = "Erro: Usuario nao cadastrado!";
                    ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                    ViewBag.Class = "alert alert-danger";
                    return View(cadastrarPessoaFisicaVM);
                }
            }
            else
            {
                CadastrarPessoaFisicaVM ObjCadastrarPessoaFisicaVM = (CadastrarPessoaFisicaVM)PessoaFisicaBUS.CadastrarPessoaFisicaVM();
                ObjCadastrarPessoaFisicaVM.ObjPessoaFisicaMOD = cadastrarPessoaFisicaVM.ObjPessoaFisicaMOD;
                ObjCadastrarPessoaFisicaVM.LisContatoPessoaFisicaMOD = cadastrarPessoaFisicaVM.LisContatoPessoaFisicaMOD;
                ObjCadastrarPessoaFisicaVM.LisDependentePessoaFisicaMOD = cadastrarPessoaFisicaVM.LisDependentePessoaFisicaMOD;
                ViewBag.Mensagem = "Preenchimento invalido!";
                ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                ViewBag.Class = "alert alert-danger";
                return View(ObjCadastrarPessoaFisicaVM);
            }
            return View(cadastrarPessoaFisicaVM);
        }
        #endregion

        #region Alterar Pessoa Fisica
        [HttpGet]
        public IActionResult Alterar(int Id)
        {
            AlterarPessoaFisicaVM alterarPessoaFisicaVM = PessoaFisicaBUS.AlterarPessoaFisicaVM(Id);
            if (alterarPessoaFisicaVM != null)
            {
                if (alterarPessoaFisicaVM.ObjPessoaFisicaMOD != null)
                {
                    return View(alterarPessoaFisicaVM);
                }
                else
                {
                    ViewBag.Mensagem = "Usuario nao encontrado!";
                    ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                    ViewBag.Class = "alert alert-danger";
                    return View(alterarPessoaFisicaVM);
                }
            }
            else
            {
                ViewBag.Mensagem = "Usuario nao encostrado!";
                ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                ViewBag.Class = "alert alert-danger";
                return View("retornar pagina de erro 404");
            }
        }

        [HttpPost]
        public IActionResult Alterar(AlterarPessoaFisicaVM ObjAlterarPessoaFisicaVM)
        {
            if (ModelState.IsValid)
            {
                PessoaFisicaBUS.ActionAlterarPessoaFisica(ObjAlterarPessoaFisicaVM);
                ViewBag.Mensagem = "Pessoa fisica alterada com sucesso!";
                ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                ViewBag.Class = "alert alert-success";
                return View(PessoaFisicaBUS.AlterarPessoaFisicaVM(ObjAlterarPessoaFisicaVM.ObjPessoaFisicaMOD.IdPessoaFisica));
            }
            else
            {
                AlterarPessoaFisicaVM alterarPessoaFisicaVM = PessoaFisicaBUS.AlterarPessoaFisicaVM(ObjAlterarPessoaFisicaVM.ObjPessoaFisicaMOD.IdPessoaFisica);
                alterarPessoaFisicaVM.ObjPessoaFisicaMOD = alterarPessoaFisicaVM.ObjPessoaFisicaMOD;
                ViewBag.Mensagem = "Pessoa fisica alterada com sucesso!";
                ViewBag.Style = "display:block; text-align:center; margin-top: 5%";
                ViewBag.Class = "alert alert-danger";
                return View(alterarPessoaFisicaVM);
            }
        }
        #endregion
    }
}