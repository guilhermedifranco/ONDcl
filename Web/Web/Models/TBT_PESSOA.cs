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
    
    public partial class TBT_PESSOA
    {
        public TBT_PESSOA()
        {
            this.TBT_CARRINHO = new HashSet<TBT_CARRINHO>();
            this.TBT_CARRINHO1 = new HashSet<TBT_CARRINHO>();
            this.TBT_CARTEIRA_CLIENTE = new HashSet<TBT_CARTEIRA_CLIENTE>();
            this.TBT_GERENTE_REPRESENTANTE = new HashSet<TBT_GERENTE_REPRESENTANTE>();
            this.TBT_GERENTE_REPRESENTANTE1 = new HashSet<TBT_GERENTE_REPRESENTANTE>();
            this.TBT_PEDIDO = new HashSet<TBT_PEDIDO>();
            this.TBT_PEDIDO1 = new HashSet<TBT_PEDIDO>();
            this.TBT_PESSOA_COND_PGTO = new HashSet<TBT_PESSOA_COND_PGTO>();
            this.TBT_PESSOA_MARCA = new HashSet<TBT_PESSOA_MARCA>();
            this.TBT_REPRESENTANTE_PREPOSTO = new HashSet<TBT_REPRESENTANTE_PREPOSTO>();
            this.TBT_REPRESENTANTE_PREPOSTO1 = new HashSet<TBT_REPRESENTANTE_PREPOSTO>();
            this.TBT_USUARIO = new HashSet<TBT_USUARIO>();
        }
    
        public string CodPessoa { get; set; }
        public string Nome { get; set; }
        public string CodTipoPessoa { get; set; }
        public string CodTabelaPreco { get; set; }
        public string CodCondicaoPagamento { get; set; }
        public string CodPessoaTransportadora { get; set; }
        public string CodPessoaRedespacho { get; set; }
        public Nullable<decimal> PercentualDesconto { get; set; }
        public string Email { get; set; }
        public string CodPessoaERP { get; set; }
        public string CodPessoaAFV { get; set; }
        public decimal ID { get; set; }
        public Nullable<System.DateTime> CtrlDataOperacao { get; set; }
    
        public virtual ICollection<TBT_CARRINHO> TBT_CARRINHO { get; set; }
        public virtual ICollection<TBT_CARRINHO> TBT_CARRINHO1 { get; set; }
        public virtual ICollection<TBT_CARTEIRA_CLIENTE> TBT_CARTEIRA_CLIENTE { get; set; }
        public virtual TBT_CONDICAO_PAGAMENTO TBT_CONDICAO_PAGAMENTO { get; set; }
        public virtual ICollection<TBT_GERENTE_REPRESENTANTE> TBT_GERENTE_REPRESENTANTE { get; set; }
        public virtual ICollection<TBT_GERENTE_REPRESENTANTE> TBT_GERENTE_REPRESENTANTE1 { get; set; }
        public virtual ICollection<TBT_PEDIDO> TBT_PEDIDO { get; set; }
        public virtual ICollection<TBT_PEDIDO> TBT_PEDIDO1 { get; set; }
        public virtual TBT_PESSOA_CLIENTE TBT_PESSOA_CLIENTE { get; set; }
        public virtual ICollection<TBT_PESSOA_COND_PGTO> TBT_PESSOA_COND_PGTO { get; set; }
        public virtual ICollection<TBT_PESSOA_MARCA> TBT_PESSOA_MARCA { get; set; }
        public virtual ICollection<TBT_REPRESENTANTE_PREPOSTO> TBT_REPRESENTANTE_PREPOSTO { get; set; }
        public virtual ICollection<TBT_REPRESENTANTE_PREPOSTO> TBT_REPRESENTANTE_PREPOSTO1 { get; set; }
        public virtual ICollection<TBT_USUARIO> TBT_USUARIO { get; set; }
        public virtual TBT_TABELA_PRECO TBT_TABELA_PRECO { get; set; }
        public virtual TBT_TIPO_PESSOA TBT_TIPO_PESSOA { get; set; }
    }
}
