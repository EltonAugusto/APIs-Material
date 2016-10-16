using Material.Dominio.Cadastros.Repositorios;
using System.Linq;
using System.Collections.Generic;
using Material.Dominio.Cadastros.Entidades;
using Material.Infra.Persistencia;
using System;
using Material.Dominio.Cadastros.Specs;

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

        public Produto ObterPorId(Guid guid)
        {
            return _context.Produtos.FirstOrDefault(ProdutoSpecs.ObterPorId(guid));
        }
    }
}
