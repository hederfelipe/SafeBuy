using Microsoft.AspNetCore.Mvc;
using SafeBuy.Dominio.Contratos;
using SafeBuy.Dominio.Entidades;
using System;

namespace SafeBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class ProdutoController : Controller
    {

        private readonly IProdutoRepositorio _produtoRepositorio;

        public ProdutoController(IProdutoRepositorio produtoRepositorio)
        {
            _produtoRepositorio = produtoRepositorio;

        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                return Json(_produtoRepositorio.ObterTodos());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Produto produto)
        {
            try
            {
                produto.Validate();
                if (!produto.EhValido)
                {
                    return BadRequest(produto.ObterMensagensValidação());
                }
                if (produto.Id > 0)
                {
                    _produtoRepositorio.Atualizar(produto);
                }
                else
                {
                    _produtoRepositorio.Adicionar(produto);
                }

                return Created("api/produto", produto);

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("Deletar")]
        public IActionResult Deletar([FromBody] Produto produto)
        {
            try
            {

                // produto recebido do FromBody, deve ter a propriedade Id > 0
                _produtoRepositorio.Remover(produto);
                return Json(_produtoRepositorio.ObterTodos());

            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

    }
}
