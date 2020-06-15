using System;
using System.Collections.Generic;
using System.Text;

namespace SafeBuy.Dominio.Entidades
{
    class ItemPedido :Entidade
    {
        public int Id { get; set; }
        public int ProdutoId { get; set; }
        public int  Quantidade { get; set; }

        public override void Validate()
        {
            if()
        }
    }
}
