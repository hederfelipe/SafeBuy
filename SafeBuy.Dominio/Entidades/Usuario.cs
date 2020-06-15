using System;
using System.Collections.Generic;
using System.Text;

namespace SafeBuy.Dominio.Entidades
{
    public class Usuario :Entidade
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }

        //um usuario pode ou não pode (fazer/ter) pedidos
        public ICollection<Pedido> Pedidos { get; set; }

        public override void Validate()
        {
            if (string.IsNullOrEmpty(Email))
                AdcionarMensagemCritica("Email não informado");

            if (string.IsNullOrEmpty(Senha))
                AdcionarMensagemCritica("Senha não informada");
        }
    }
}
