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
    
    public partial class TBT_LINHA
    {
        public TBT_LINHA()
        {
            this.TBT_MODELO = new HashSet<TBT_MODELO>();
        }
    
        public string CodMarca { get; set; }
        public string CodLinha { get; set; }
        public string Descricao { get; set; }
        public decimal ID { get; set; }
        public Nullable<System.DateTime> CtrlDataOperacao { get; set; }
    
        public virtual ICollection<TBT_MODELO> TBT_MODELO { get; set; }
        public virtual TBT_MARCA TBT_MARCA { get; set; }
    }
}
