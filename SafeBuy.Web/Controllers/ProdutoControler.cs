using Microsoft.AspNetCore.Mvc;
using SafeBuy.Dominio.Contratos;

namespace SafeBuy.Web.Controllers
{
    [Route("api/[controller]")]
    public class ProdutoControler : Controller


        private readonly IProdutoRepositorio _produtoRepositorio;
        public ProdutoControler(IProdutoRepositorio produtoRepositorio)
        {
        _produtoRepositorio = produtoRepositorio;
        }
    }
}
