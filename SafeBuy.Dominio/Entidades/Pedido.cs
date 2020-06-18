using SafeBuy.Dominio.ObjetoDeValor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafeBuy.Dominio.Entidades
{
    public class Pedido : Entidade
    {
        public int Id { get; set; }
        public DateTime DataPedido { get; set; }
        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }
        public DateTime DataPrevisaoEntrega { get; set; }
        public string Cep { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string EnderecoCompleto { get; set; }
        public int NumeroEndereco { get; set; }

        public int FormaPagamentoId { get; set; }

        public virtual FormaPagamento FormaPagamento { get; set; }


        // um pedido deve ter um item de pedido ou varios intens  pedidos

        public virtual ICollection<ItemPedido> ItemPedidos { get; set; }

        public override void Validate()
        {
            LimparMensagensValidacao();

            if (!ItemPedidos.Any())
                AdcionarMensagemCritica("Critica - Pedido não pode ficar em item");

            if (string.IsNullOrEmpty(Cep))
                AdcionarMensagemCritica("Critica - Cep deve estar preenchido");
        }
    }
}
