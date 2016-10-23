using Material.Dominio.Cadastros.Entidades;
using System;
using System.Linq.Expressions;

namespace Material.Dominio.Cadastros.Specs
{
    public static class ProdutoSpecs
    {
        public static Expression<Func<Produto, bool>> ObterPorId(string id)
        {
            return x => x.Id.ToString() == id;
        }


      
    }
}
