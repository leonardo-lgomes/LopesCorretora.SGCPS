using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

//Models contem apenas props com DataAnotations (para validacao no servidor) e Construtores;

//Nomenclatura: NomeDaModelMOD;

//Models nao tem acesso a nenhuma outra camada;

//Quem tem acesso a Model: Repository, UI, Business, ViewsModels;

namespace LopesCorretora.SGCPS.Models.ModeloDaAplicacao
{
    public class ClasseMOD
    {
        [Required]
        public string Nome { get; set; }
        public int Id { get; set; }
        public string Endereco { get; set; }

        public ClasseMOD(int IntId, string StrNome, string StrEndereco)
        {
            this.Endereco = StrEndereco;
            this.Nome = StrNome;
            this.Id = IntId;
        }
    }
}

