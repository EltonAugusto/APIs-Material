using Material.Dominio.Cadastros.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Material.Dominio.Cadastros.Repositorios
{
    public interface IProdutoRepositorio
    {
        List<Produto> ObterProdutos();
    }
}
