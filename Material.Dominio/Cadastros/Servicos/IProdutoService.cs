using Material.Dominio.Cadastros.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Material.Dominio.Cadastros.Servicos
{
    public interface IProdutoServico
    {
        List<Produto> ObterProdutos();
    }
}
