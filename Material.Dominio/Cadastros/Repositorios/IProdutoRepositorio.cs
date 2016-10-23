using Material.Dominio.Cadastros.Entidades;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Material.Dominio.Cadastros.Repositorios
{
    public interface IProdutoRepositorio
    {
        List<Produto> ObterProdutos();
        void Remendar(string id, Produto produto);
        void Incluir(Produto produto);
        void Deletar(string id);
        void Alterar(string id, Produto produto);
        Produto ObterPorId(string id);
        void Commit();
        List<Categoria> ObterCategoriasPorProduto(string id);
    }
}
