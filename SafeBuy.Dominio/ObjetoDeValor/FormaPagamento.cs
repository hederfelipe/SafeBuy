using SafeBuy.Dominio.Enumerados;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafeBuy.Dominio.ObjetoDeValor
{
    public class FormaPagamento
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Descricao { get; set; }

        public bool NoBoleto
        {
            get { return Id == (int)TipoFormaPagamentoNum.Boleto; }
        }
        public bool NoCartao
        {
            get { return Id == (int)TipoFormaPagamentoNum.CartaoDeCredito; }
        }
        public bool NoDeposito
        {
            get { return Id == (int)TipoFormaPagamentoNum.Deposito; }
        }

        public bool NaoDefinido
        {
            get { return Id == (int)TipoFormaPagamentoNum.NaoDefinido; }
        }
    }
}
