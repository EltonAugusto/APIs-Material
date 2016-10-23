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
        public Produto ObterPorId(string id)
        {
            return _repositorio.ObterPorId(id);
        }

        public Produto Alterar(string id, Produto produto)
        {
            _repositorio.Alterar(id, produto);
            _repositorio.Commit();
            return ObterPorId(id);
        }

        public Produto Remendar(string id, Produto produto)
        {
            _repositorio.Remendar(id, produto);
            _repositorio.Commit();
            return ObterPorId(id);
        }

        public List<Categoria> ObterCategoriasPorProduto(string id)
        {
            return _repositorio.ObterCategoriasPorProduto(id);
        }

        public Produto Incluir(Produto produto)
        {
            _repositorio.Incluir(produto);
            _repositorio.Commit();
            return ObterPorId(produto.Id.ToString());
        }

        public void Deletar(string id)
        {
            _repositorio.Deletar(id);
        }
    }
}
