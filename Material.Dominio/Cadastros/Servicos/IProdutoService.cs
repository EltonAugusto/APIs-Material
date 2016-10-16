using Material.Dominio.Cadastros.Entidades;
using System.Collections.Generic;

namespace Material.Dominio.Cadastros.Servicos
{
    public interface IProdutoServico
    {
        List<Produto> ObterProdutos();
    }
}
