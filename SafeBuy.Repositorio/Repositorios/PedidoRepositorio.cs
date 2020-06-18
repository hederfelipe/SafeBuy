using SafeBuy.Dominio.Contratos;
using SafeBuy.Dominio.Entidades;
using SafeBuy.repositorio.Contexto;
using SafeBuy.repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafeBuy.repositorio.Repositorios
{
    public class PedidoRepositorio : BaseRepositorio<Pedido>, IPedidoRepositorio
    {
        public PedidoRepositorio(SafeBuyContexto safeBuyContexto) : base(safeBuyContexto)
        {
        }
    }
}
