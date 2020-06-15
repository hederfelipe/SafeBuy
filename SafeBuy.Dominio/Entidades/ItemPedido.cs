using System;
using System.Collections.Generic;
using System.Text;

namespace SafeBuy.Dominio.Entidades
{
    public class ItemPedido :Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int  Quantidade { get; set; }

        public override void Validate()
        {
            if (ProdutoId == 0)
                AdcionarMensagemCritica("Não foi identificado qual a referência");

            if (Quantidade == 0)
                AdcionarMensagemCritica("Quantidade não informada");
        }
    }
}
