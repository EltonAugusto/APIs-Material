using Material.Dominio.Cadastros.Repositorios;
using System.Linq;
using System.Collections.Generic;
using Material.Dominio.Cadastros.Entidades;
using Material.Infra.Persistencia;
using Material.Dominio.Cadastros.Specs;
using System.Data.Entity;
using System;

namespace Material.Infra.Repositorios.Cadastros
{
    public class ProdutoRepositorio : IProdutoRepositorio
    {
        private readonly MaterialContext _context;
        public ProdutoRepositorio(MaterialContext context)
        {
            _context = context;
        }
        public List<Produto> ObterProdutos()
        {
            return _context.Produtos.ToList();
        }

        public Produto ObterPorId(string id)
        {
            return _context.Produtos.FirstOrDefault(ProdutoSpecs.ObterPorId(id));
        }

        public void Alterar(string id, Produto produto)
        {
            var original = ObterPorId(id);

            original.AlterarNome(produto.Nome);
            original.AlterarDescricao(produto.Descricao);
            original.AlterarPreco(produto.Preco.Value);

            _context.Entry(original).State = EntityState.Modified;
        }

        public void Incluir(Produto produto)
        {
            _context.Produtos.Add(produto);
        }

        public void Remendar(string id, Produto produto)
        {
            var original = ObterPorId(id);

            if( produto.Nome != null)
                original.AlterarNome(produto.Nome);

            if (produto.Descricao != null)
                original.AlterarDescricao(produto.Descricao);

            if (produto.Preco != null)
                original.AlterarPreco(produto.Preco.Value);

            _context.Entry(original).State = EntityState.Modified;
        }

        public void Deletar(string id)
        {
            _context.Produtos.Remove(ObterPorId(id));
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public List<Categoria> ObterCategoriasPorProduto(string id)
        {
            return ObterPorId(id).Categorias;
        }
    }
}
