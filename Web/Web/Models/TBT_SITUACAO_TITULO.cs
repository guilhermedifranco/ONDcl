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
    
    public partial class TBT_SITUACAO_TITULO
    {
        public TBT_SITUACAO_TITULO()
        {
            this.TBT_TITULO = new HashSet<TBT_TITULO>();
        }
    
        public string CodSituacaoTitulo { get; set; }
        public string Descricao { get; set; }
        public decimal ID { get; set; }
        public Nullable<System.DateTime> CtrlDataOperacao { get; set; }
    
        public virtual ICollection<TBT_TITULO> TBT_TITULO { get; set; }
    }
}
