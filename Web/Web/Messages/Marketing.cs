using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web.Models;
using System.ComponentModel.DataAnnotations;

namespace Web.Messages
{
    public class Marketing
    {
        public int CodMarketing { get; set; }
        public int CodTipoMarketing { get; set; }
        public string TipoMarketing { get; set; }
        public string CodMarca { get; set; }
        public string Marca { get; set; }
        [MaxLength(100, ErrorMessage = "O título não pode ultrapassar 100 caracteres")]
        [DisplayFormat(DataFormatString = "{0,20}")]
        public string Titulo { get; set; }
        [MaxLength(200, ErrorMessage = "A descrição não pode ultrapassar 200 caracteres")]
        public string Descricao { get; set; }
        public string TipoArquivo { get; set; }
        public string NomeArquivo { get; set; }
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy hh:mm tt}")]
        public DateTime DataCadastro { get; set; }
        //Não existe tabela de coleção para realizar a associação, coluna será ignorada 
        //public string CodColecao { get; set; }
        public bool Ativo { get; set; }
        public bool Destaque { get; set; }
    }
}