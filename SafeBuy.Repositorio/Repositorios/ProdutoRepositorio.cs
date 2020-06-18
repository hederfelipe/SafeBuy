using SafeBuy.Dominio.Contratos;
using SafeBuy.Dominio.Entidades;
using SafeBuy.repositorio.Contexto;
using SafeBuy.repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafeBuy.repositorio.Repositorios
{
    public class ProdutoRepositorio : BaseRepositorio<Produto>, IProdutoRepositorio
    {
        public ProdutoRepositorio(SafeBuyContexto safeBuyContexto) : base(safeBuyContexto)
        {
        }
    }
}
