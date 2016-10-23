using Material.Dominio.Cadastros.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Material.Dominio.Cadastros.Servicos
{
    public interface IProdutoServico
    {
        List<Produto> ObterProdutos();
        Produto Remendar(string id, Produto produto);
        Produto Incluir(Produto produto);
        void Deletar(string id);
        Produto Alterar(string id, Produto produto);
        Produto ObterPorId(string id);
        List<Categoria> ObterCategoriasPorProduto(string id);
    }
}
