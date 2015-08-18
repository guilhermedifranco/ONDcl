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
    
    public partial class TBT_MARKETING
    {
        public TBT_MARKETING()
        {
            this.TBT_MARKETING_MODELO = new HashSet<TBT_MARKETING_MODELO>();
        }
    
        public decimal CodMarketing { get; set; }
        public decimal CodTipoMarketing { get; set; }
        public string CodMarca { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public string TipoArquivo { get; set; }
        public string NomeArquivo { get; set; }
        public string CodColecao { get; set; }
        public int IndAtivo { get; set; }
        public int IndDestaque { get; set; }
        public Nullable<System.DateTime> Publicacao { get; set; }
        public decimal ID { get; set; }
        public Nullable<System.DateTime> CtrlDataOperacao { get; set; }
    
        public virtual ICollection<TBT_MARKETING_MODELO> TBT_MARKETING_MODELO { get; set; }
        public virtual TBT_TIPO_MARKETING TBT_TIPO_MARKETING { get; set; }
    }
}