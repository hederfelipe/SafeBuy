using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SafeBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        private List<string> _mensagensValidacao { get; set; }
        
        private List<string> MensagensValidacao
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>()); }
        }

        protected void LimparMensagensValidacao()
        {
            MensagensValidacao.Clear();
        }

        protected void AdcionarMensagemCritica(string mensagem)
        {
            MensagensValidacao.Add(mensagem);
        }

        public string ObterMensagensValidação()
        {
            return string.Join(". ", MensagensValidacao);
        }

        public abstract void Validate();

        protected bool EhValido
        {
            get { return !MensagensValidacao.Any(); }
        }
    }
}
