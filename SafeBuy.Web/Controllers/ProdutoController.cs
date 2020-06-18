using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SafeBuy.Dominio.Contratos;
using SafeBuy.repositorio.Repositorios;

namespace SafeBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class ProdutoController : Controller
    {
        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;
        }
    }
}
