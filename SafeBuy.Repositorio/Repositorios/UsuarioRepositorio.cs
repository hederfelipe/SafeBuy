using SafeBuy.Dominio.Contratos;
using SafeBuy.Dominio.Entidades;
using SafeBuy.repositorio.Contexto;
using SafeBuy.repositorio.Repositorio;
using System;
using System.Collections.Generic;
using System.Text;

namespace SafeBuy.repositorio.Repositorios
{
    public class UsuarioRepositorio : BaseRepositorio<Usuario>, IUsuarioRepositorio
    {
        public UsuarioRepositorio(SafeBuyContexto safeBuyContexto) : base(safeBuyContexto)
        {
        }
    }
}
 