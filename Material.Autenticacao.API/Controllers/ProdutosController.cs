using Material.Dominio.Cadastros.Entidades;
using Material.Dominio.Cadastros.Servicos;
using Material.Servico.Services.Cadastros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Material.Autenticacao.API.Controllers
{
    [RoutePrefix("api/v1")]
    [Authorize]
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
