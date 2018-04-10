using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Models;
using LopesCorretora.SGCPS.Models.ModelosComplementares;
using LopesCorretora.SGCPS.Repository;
using LopesCorretora.SGCPS.ViewsModels;

namespace LopesCorretora.SGCPS.Business
{
    public class PessoaFisicaBUS
    {
        #region Action BUS: Cadastrar Pessoa Fisica
        public static CadastrarPessoaFisicaVM CadastrarPessoaFisicaVM()
        {
            try
            {
                return new CadastrarPessoaFisicaVM()
                {
                    ObjPessoaFisicaMOD = new PessoaFisicaMOD(),
                    LisPlanosMOD = PlanoRPO.Listar(),
                    LisSexo = new Sexo().sexos(),
                    LisStatusMOD = StatusRPO.Listar(),
                };
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void ActionCadastrarPessoaFisica(CadastrarPessoaFisicaVM cadastrarPessoaFisicaVM)
        {
            try
            {
                CadastrarContatoPessoaFisica(cadastrarPessoaFisicaVM);
                CadastrarDependentePessoaFisica(cadastrarPessoaFisicaVM);
                CadastrarPessoaFisica(cadastrarPessoaFisicaVM);
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static void CadastrarContatoPessoaFisica(CadastrarPessoaFisicaVM cadastrarPessoaFisicaVM)
        {
            foreach (var contato in cadastrarPessoaFisicaVM.LisContatoPessoaFisicaMOD)
            {
                if (contato.Contato != null)
                {
                    if (!contato.Contato.ToString().Trim().Equals(""))
                    {
                        contato.PessoaFisica = cadastrarPessoaFisicaVM.ObjPessoaFisicaMOD;
                        ContatoPessoaFisicaRPO.Cadastrar(contato);
                    }
                }
            }
        }

        private static void CadastrarDependentePessoaFisica(CadastrarPessoaFisicaVM cadastrarPessoaFisicaVM)
        {
            foreach (var dependente in cadastrarPessoaFisicaVM.LisDependentePessoaFisicaMOD)
            {
                if (dependente != null && cadastrarPessoaFisicaVM.ObjPessoaFisicaMOD != null)
                {
                    dependente.PessoaFisica = cadastrarPessoaFisicaVM.ObjPessoaFisicaMOD;
                    DependentePessoaFisicaRPO.Cadastrar(dependente);
                }
            }
        }

        private static void CadastrarPessoaFisica(CadastrarPessoaFisicaVM cadastrarPessoaFisicaVM)
        {
            if (cadastrarPessoaFisicaVM.ObjPessoaFisicaMOD != null)
            {
                PessoaFisicaRPO.Cadastrar(cadastrarPessoaFisicaVM.ObjPessoaFisicaMOD);
            }
        }
        #endregion

        #region Action BUS: Alterar Pessoa Fisica
        public static AlterarPessoaFisicaVM AlterarPessoaFisicaVM(int id)
        {
            try
            {
                AlterarPessoaFisicaVM alterarPessoaFisicaVM = new AlterarPessoaFisicaVM()
                {
                    //ObjPessoaFisicaMOD = PessoaFisicaRPO.Consultar(id),
                    LisPlanosMOD = PlanoRPO.Listar(),
                    LisSexo = new Sexo().sexos(),
                    LisStatusMOD = new List<StatusMOD>(),
                    LisNumeroDeParcelas = new List<string>(),
                    LisEstadoCivil = new List<string>(),
                };
                return alterarPessoaFisicaVM;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static void ActionAlterarPessoaFisica(AlterarPessoaFisicaVM alterarPessoaFisicaVM)
        {
            PessoaFisicaRPO.Alterar(alterarPessoaFisicaVM.ObjPessoaFisicaMOD);
        }
        #endregion
    }
}
