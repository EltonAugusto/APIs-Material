using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material.Dominio.Cadastros.Entidades
{
    public class Categoria
    {
        protected Categoria()
        {

        }
        public Categoria(string nome, string descricao)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Descricao = descricao;
        }
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }

        public virtual List<Produto> Produtos { get; private set; }
    }
}
