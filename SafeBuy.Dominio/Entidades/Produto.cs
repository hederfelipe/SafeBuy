using System;
using System.Collections.Generic;
using System.Text;

namespace SafeBuy.Dominio.Entidades
{
    public class Produto :Entidade
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public decimal Preco { get; set; }

        public string NomeArquivo { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Nome))
                AdcionarMensagemCritica("Nome do produto não informado");

            if (string.IsNullOrEmpty(Descricao))
                AdcionarMensagemCritica("Descrição não foi informado");

        }
    }
}
