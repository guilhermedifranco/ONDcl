﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SmartBagEntities : DbContext
    {
        public SmartBagEntities()
            : base("name=SmartBagEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AFV_CAMPOS_SINCRONIZACAO_TBT> AFV_CAMPOS_SINCRONIZACAO_TBT { get; set; }
        public virtual DbSet<AFV_FOTO_MARCA> AFV_FOTO_MARCA { get; set; }
        public virtual DbSet<AFV_FOTO_PRODUTO> AFV_FOTO_PRODUTO { get; set; }
        public virtual DbSet<AFV_INSTALACAO> AFV_INSTALACAO { get; set; }
        public virtual DbSet<AFV_PARAMETRO_SINCRONIZACAO> AFV_PARAMETRO_SINCRONIZACAO { get; set; }
        public virtual DbSet<AFV_TABELA_SINCRONIZACAO_TBT> AFV_TABELA_SINCRONIZACAO_TBT { get; set; }
        public virtual DbSet<TBT_CARRINHO> TBT_CARRINHO { get; set; }
        public virtual DbSet<TBT_CARTEIRA_CLIENTE> TBT_CARTEIRA_CLIENTE { get; set; }
        public virtual DbSet<TBT_COLECAO> TBT_COLECAO { get; set; }
        public virtual DbSet<TBT_CONDICAO_PAGAMENTO> TBT_CONDICAO_PAGAMENTO { get; set; }
        public virtual DbSet<TBT_CONFIGURACAO_NIVEL> TBT_CONFIGURACAO_NIVEL { get; set; }
        public virtual DbSet<TBT_COR> TBT_COR { get; set; }
        public virtual DbSet<TBT_CRITICA_CARRINHO> TBT_CRITICA_CARRINHO { get; set; }
        public virtual DbSet<TBT_DERIVACAO> TBT_DERIVACAO { get; set; }
        public virtual DbSet<TBT_DERIVACAO_GRADE> TBT_DERIVACAO_GRADE { get; set; }
        public virtual DbSet<TBT_ENDERECO_CLIENTE> TBT_ENDERECO_CLIENTE { get; set; }
        public virtual DbSet<TBT_GERENTE_REPRESENTANTE> TBT_GERENTE_REPRESENTANTE { get; set; }
        public virtual DbSet<TBT_GRADE> TBT_GRADE { get; set; }
        public virtual DbSet<TBT_GRADE_ITEM_CARRINHO> TBT_GRADE_ITEM_CARRINHO { get; set; }
        public virtual DbSet<TBT_GRADE_ITEM_PEDIDO> TBT_GRADE_ITEM_PEDIDO { get; set; }
        public virtual DbSet<TBT_GRADE_MODELO> TBT_GRADE_MODELO { get; set; }
        public virtual DbSet<TBT_GRUPO_CLIENTE> TBT_GRUPO_CLIENTE { get; set; }
        public virtual DbSet<TBT_GRUPO_PRODUTO> TBT_GRUPO_PRODUTO { get; set; }
        public virtual DbSet<TBT_ITEM_CARRINHO> TBT_ITEM_CARRINHO { get; set; }
        public virtual DbSet<TBT_ITEM_PEDIDO> TBT_ITEM_PEDIDO { get; set; }
        public virtual DbSet<TBT_ITEM_PRONTA_ENTREGA> TBT_ITEM_PRONTA_ENTREGA { get; set; }
        public virtual DbSet<TBT_LINHA> TBT_LINHA { get; set; }
        public virtual DbSet<TBT_MARCA> TBT_MARCA { get; set; }
        public virtual DbSet<TBT_MARKETING> TBT_MARKETING { get; set; }
        public virtual DbSet<TBT_MARKETING_MODELO> TBT_MARKETING_MODELO { get; set; }
        public virtual DbSet<TBT_MODELO> TBT_MODELO { get; set; }
        public virtual DbSet<TBT_MODELO_TABELA_PRECO> TBT_MODELO_TABELA_PRECO { get; set; }
        public virtual DbSet<TBT_NIVEL1> TBT_NIVEL1 { get; set; }
        public virtual DbSet<TBT_NIVEL2> TBT_NIVEL2 { get; set; }
        public virtual DbSet<TBT_NOTA_FISCAL> TBT_NOTA_FISCAL { get; set; }
        public virtual DbSet<TBT_PARAMETRO> TBT_PARAMETRO { get; set; }
        public virtual DbSet<TBT_PEDIDO> TBT_PEDIDO { get; set; }
        public virtual DbSet<TBT_PESSOA> TBT_PESSOA { get; set; }
        public virtual DbSet<TBT_PESSOA_CLIENTE> TBT_PESSOA_CLIENTE { get; set; }
        public virtual DbSet<TBT_PESSOA_COND_PGTO> TBT_PESSOA_COND_PGTO { get; set; }
        public virtual DbSet<TBT_PESSOA_MARCA> TBT_PESSOA_MARCA { get; set; }
        public virtual DbSet<TBT_PORTADOR> TBT_PORTADOR { get; set; }
        public virtual DbSet<TBT_PRODUTO> TBT_PRODUTO { get; set; }
        public virtual DbSet<TBT_PRODUTO_RELACIONADO> TBT_PRODUTO_RELACIONADO { get; set; }
        public virtual DbSet<TBT_PRODUTO_TAMANHO> TBT_PRODUTO_TAMANHO { get; set; }
        public virtual DbSet<TBT_REPRESENTANTE_PREPOSTO> TBT_REPRESENTANTE_PREPOSTO { get; set; }
        public virtual DbSet<TBT_SITUACAO_CLIENTE> TBT_SITUACAO_CLIENTE { get; set; }
        public virtual DbSet<TBT_SITUACAO_PEDIDO> TBT_SITUACAO_PEDIDO { get; set; }
        public virtual DbSet<TBT_SITUACAO_TITULO> TBT_SITUACAO_TITULO { get; set; }
        public virtual DbSet<TBT_TABELA_PRECO> TBT_TABELA_PRECO { get; set; }
        public virtual DbSet<TBT_TIPO_MARKETING> TBT_TIPO_MARKETING { get; set; }
        public virtual DbSet<TBT_TIPO_PEDIDO> TBT_TIPO_PEDIDO { get; set; }
        public virtual DbSet<TBT_TIPO_PESSOA> TBT_TIPO_PESSOA { get; set; }
        public virtual DbSet<TBT_TITULO> TBT_TITULO { get; set; }
        public virtual DbSet<TBT_USUARIO> TBT_USUARIO { get; set; }
        public virtual DbSet<TMP_FOTO_ARQUIVO> TMP_FOTO_ARQUIVO { get; set; }
        public virtual DbSet<AFV_LOG_ERRO_CARGA> AFV_LOG_ERRO_CARGA { get; set; }
    }
}
