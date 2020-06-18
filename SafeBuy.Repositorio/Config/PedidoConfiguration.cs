using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SafeBuy.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafeBuy.repositorio.Config
{
    public class PedidoConfiguration : IEntityTypeConfiguration<Pedido>
    {
        public void Configure(EntityTypeBuilder<Pedido> builder)
        {
            builder.HasKey(p => p.Id);

            builder
                .Property(P => P.DataPedido)
                .IsRequired();

            builder
                .Property(P => P.DataPrevisaoEntrega)
                .IsRequired();

            builder
                .Property(P => P.Cep)
                .IsRequired()
                .HasMaxLength(10);

            builder
                .Property(P => P.Cidade)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(P => P.Estado)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.EnderecoCompleto)
                .IsRequired()
                .HasMaxLength(100);

            builder
                .Property(p => p.NumeroEndereco)
                .IsRequired()
                .HasMaxLength(100);

            builder.HasOne(p => p.FormaPagamento);

            
        }
    }
}
