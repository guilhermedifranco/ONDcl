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
    
    public partial class TBT_NOTA_FISCAL
    {
        public string CodEmpresa { get; set; }
        public string CodFilial { get; set; }
        public string NumeroNF { get; set; }
        public string SerieNF { get; set; }
        public string CodPessoaCliente { get; set; }
        public Nullable<System.DateTime> DataEmissao { get; set; }
        public Nullable<System.DateTime> DataEntrega { get; set; }
        public int CodSituacaoNotaFiscal { get; set; }
        public Nullable<decimal> QtdTotal { get; set; }
        public Nullable<decimal> ValorTotal { get; set; }
        public decimal ID { get; set; }
        public Nullable<System.DateTime> CtrlDataOperacao { get; set; }
    
        public virtual TBT_PESSOA_CLIENTE TBT_PESSOA_CLIENTE { get; set; }
    }
}