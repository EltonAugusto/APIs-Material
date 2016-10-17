using Material.Dominio.Cadastros.Entidades;
using Material.Dominio.Cadastros.Servicos;
using Material.Produtos.API.Filters;
using System.Collections.Generic;
using System.Web.Http;

namespace Material.Produtos.API.Controllers
{
    [CustomAuthorize]
    [RoutePrefix("api/v1")]
    public class ProdutosController : ApiController
    {
        private readonly IProdutoServico _service;
        public ProdutosController(IProdutoServico service)
        {
            _service = service;
        }

        [Route("produtos")]
        public List<Produto> Get()
        {
            return _service.ObterProdutos();
        }
    }
}
