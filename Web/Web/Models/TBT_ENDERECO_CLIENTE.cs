//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Web.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBT_ENDERECO_CLIENTE
    {
        public string CodPessoaCliente { get; set; }
        public int SeqEndereco { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Bairro { get; set; }
        public string Telefone { get; set; }
        public string Fax { get; set; }
        public string CEP { get; set; }
        public int IndComercial { get; set; }
        public int IndResidencial { get; set; }
        public int IndCobranca { get; set; }
        public int IndEntrega { get; set; }
        public int IndContato { get; set; }
        public int IndPrincipal { get; set; }
        public decimal ID { get; set; }
        public Nullable<System.DateTime> CtrlDataOperacao { get; set; }
    
        public virtual TBT_PESSOA_CLIENTE TBT_PESSOA_CLIENTE { get; set; }
    }
}