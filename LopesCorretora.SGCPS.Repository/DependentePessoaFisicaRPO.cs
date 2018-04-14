﻿using System;
using System.Collections.Generic;
using System.Text;
using LopesCorretora.SGCPS.Repository.DataAccess;
using LopesCorretora.SGCPS.Models;
using System.Linq;

namespace LopesCorretora.SGCPS.Repository
{
    public class DependentePessoaFisicaRPO
    {
        public static void Alterar(DependentePessoaFisicaMOD dependentePessoaFisicaMOD)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    context.DependentesPessoasFisicas.Update(dependentePessoaFisicaMOD);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Alterar(List<DependentePessoaFisicaMOD> ListDependentePessoaFisicaMOD)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    foreach (var item in ListDependentePessoaFisicaMOD)
                    {
                        DependentePessoaFisicaMOD ObjDependente = context.DependentesPessoasFisicas.Where(x => x.Id == item.Id).First();
                        ObjDependente.CPF = item.CPF;
                        ObjDependente.DataDeNascimento = item.DataDeNascimento;
                        ObjDependente.EstadoCivil = item.EstadoCivil;
                        ObjDependente.GrauDeParentesco = item.GrauDeParentesco;
                        ObjDependente.Nome = item.Nome;
                        ObjDependente.NomeDaMae = item.NomeDaMae;
                        ObjDependente.NumeroDoSUS = item.NumeroDoSUS;
                        ObjDependente.RG = item.RG;

                        context.DependentesPessoasFisicas.Update(ObjDependente);
                        context.SaveChanges();
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public static void Cadastrar(DependentePessoaFisicaMOD dependentePessoaFisicaMOD)
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {
                    context.DependentesPessoasFisicas.Add(dependentePessoaFisicaMOD);
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw;
            }
        }

        public static void Consultar()
        {
            try
            {
                using (SGCPSContext context = new SGCPSContext())
                {

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public static List<DependentePessoaFisicaMOD> Listar(int id)
        {
            try
            {
                IEnumerable<DependentePessoaFisicaMOD> lista;
                List<DependentePessoaFisicaMOD> Dependentes = new List<DependentePessoaFisicaMOD>();
                using (SGCPSContext context = new SGCPSContext())
                {
                    lista = context.DependentesPessoasFisicas.Where(x => x.PessoaFisicaId == id);
                    foreach (var item in lista)
                    {
                        Dependentes.Add(item);
                    }
                }
                return Dependentes;
            }
            catch (Exception e)
            {
                throw;
            }
        }
    }
}
