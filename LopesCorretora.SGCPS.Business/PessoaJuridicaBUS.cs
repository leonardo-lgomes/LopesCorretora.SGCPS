using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Models;
using LopesCorretora.SGCPS.Repository;
using LopesCorretora.SGCPS.ViewsModels;

namespace LopesCorretora.SGCPS.Business
{
    public class PessoaJuridicaBUS
    {
        #region Cadastrar Pessoa Juridica
        public static CadastrarPessoaJuridicaVM CadastrarPessoaJuridicaVMGet()
        {
            try
            {
                return new CadastrarPessoaJuridicaVM()
                {
                    ObjUsuarioMOD = new UsuarioMOD(),
                    ObjPessoaJuridicaMOD = new PessoaJuridicaMOD(),
                    ObjPlanoPessoaJuridicaMOD = new PlanoPessoaJuridicaMOD(),
                    LisPlanoMOD = new List<PlanoMOD>(),
                    LisNumeroDeParcelas = new List<int>(),
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static CadastrarPessoaJuridicaVM CadastrarPessoaJuridicaVMPost(CadastrarPessoaJuridicaVM cadastrarPessoaJuridicaVM)
        {
            try
            {
                return new CadastrarPessoaJuridicaVM()
                {
                    ObjUsuarioMOD = cadastrarPessoaJuridicaVM.ObjUsuarioMOD,
                    ObjPessoaJuridicaMOD = cadastrarPessoaJuridicaVM.ObjPessoaJuridicaMOD,
                    ObjPlanoPessoaJuridicaMOD = cadastrarPessoaJuridicaVM.ObjPlanoPessoaJuridicaMOD,
                    LisPlanoMOD = new List<PlanoMOD>(),
                    LisNumeroDeParcelas = new List<int>(),
                };
            }
            catch (Exception)
            {
                return null;
            }
        }
        #endregion
    }
}
