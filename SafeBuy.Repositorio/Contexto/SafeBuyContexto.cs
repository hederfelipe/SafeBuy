using Microsoft.EntityFrameworkCore;
using SafeBuy.Dominio.Entidades;
using SafeBuy.Dominio.ObjetoDeValor;
using SafeBuy.repositorio.Config;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafeBuy.repositorio.Contexto
{
    public class SafeBuyContexto : DbContext
    {
       

        public DbSet<Usuario>  Usuarios { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet <Pedido> Pedidos { get; set; }
        public DbSet<ItemPedido> ItensPedidos { get; set; }
        public DbSet<FormaPagamento> FormaPagamentos { get; set; }

        public SafeBuyContexto(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Classes de mapeamento...
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new ProdutoConfiguration());
            modelBuilder.ApplyConfiguration(new PedidoConfiguration());
            modelBuilder.ApplyConfiguration(new ItemPedidoConfiguration());
            modelBuilder.ApplyConfiguration(new FormaPagamentoConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
