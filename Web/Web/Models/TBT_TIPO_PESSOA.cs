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
    
    public partial class TBT_TIPO_PESSOA
    {
        public TBT_TIPO_PESSOA()
        {
            this.TBT_PESSOA = new HashSet<TBT_PESSOA>();
        }
    
        public string CodTipoPessoa { get; set; }
        public string Descricao { get; set; }
        public decimal ID { get; set; }
        public Nullable<System.DateTime> CtrlDataOperacao { get; set; }
    
        public virtual ICollection<TBT_PESSOA> TBT_PESSOA { get; set; }
    }
}
