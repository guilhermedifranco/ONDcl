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
    
    public partial class TBT_PRODUTO_TAMANHO
    {
        public string CodProduto { get; set; }
        public string CodDerivacao { get; set; }
        public int IndAtivo { get; set; }
        public decimal ID { get; set; }
        public Nullable<System.DateTime> CtrlDataOperacao { get; set; }
    
        public virtual TBT_DERIVACAO TBT_DERIVACAO { get; set; }
        public virtual TBT_PRODUTO TBT_PRODUTO { get; set; }
    }
}
