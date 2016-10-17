using Material.Dominio.Cadastros.Servicos;
using System.Collections.Generic;
using Material.Dominio.Cadastros.Entidades;
using Material.Dominio.Cadastros.Repositorios;

namespace Material.Servico.Services.Cadastros
{
    public class ProdutoServico : IProdutoServico
    {
        private readonly IProdutoRepositorio _repositorio;
        public ProdutoServico(IProdutoRepositorio repositorio)
        {
            _repositorio = repositorio;
        }
        public List<Produto> ObterProdutos()
        {
            return _repositorio.ObterProdutos();
        }
    }
}
