using Material.Dominio.Cadastros.Entidades;
using System.Collections.Generic;

namespace Material.Dominio.Cadastros.Repositorios
{
    public interface IProdutoRepositorio
    {
        List<Produto> ObterProdutos();
    }
}
