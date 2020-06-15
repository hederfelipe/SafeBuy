using System;
using System.Collections.Generic;
using System.Text;

namespace SafeBuy.Dominio.Entidades
{
    class Produto :Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdcionarMensagemCritica("Nome do produto não informado");

            if (Preco < 0)
                AdcionarMensagemCritica("Preço informado não pode ser negativo");
        }
    }
}
