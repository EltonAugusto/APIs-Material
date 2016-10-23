using Material.Dominio.Cadastros.Entidades;
using Material.Dominio.Cadastros.Servicos;
using Material.Produtos.API.Filters;
using System.Collections.Generic;
using System.Web.Http;

namespace Material.Produtos.API.Controllers
{
    [CustomAuthorize]
    public class ProdutosController : ApiController
    {
        private readonly IProdutoServico _service;
        public ProdutosController(IProdutoServico service)
        {
            _service = service;
        }

        public List<Produto> Get()
        {
            return _service.ObterProdutos();
        }

        public Produto Get(string id)
        {
            return _service.ObterPorId(id);
        }

        [HttpGet]
        [Route("api/produtos/{id}/categorias")]
        public List<Categoria> ObterCategoriasPorProduto(string id)
        {
            return _service.ObterCategoriasPorProduto(id);
        }


        public Produto Post(Produto produto)
        {
            return _service.Incluir(produto);
        }

        public Produto Put(string id, Produto produto)
        {
            return _service.Alterar(id, produto);
        }

        public Produto Patch(string id, Produto produto)
        {
            return _service.Remendar(id, produto);
        }
        public void Delete(string id)
        {
            _service.Deletar(id);
        }
    }
}
