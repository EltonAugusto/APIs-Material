using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Material.Dominio.Cadastros.Entidades
{
    public class Produto
    {
        protected Produto() { }
        public Produto(string nome, string descricao, double? preco)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Descricao = descricao;
            Preco = preco;
            Categorias = new List<Categoria>();
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public double? Preco { get; private set; }
        public virtual List<Categoria> Categorias { get; private set; }
        public bool AlterarNome(string nome)
        {
            Nome = nome;
            return true;
        }

        public bool AlterarDescricao(string descricao)
        {
            Descricao = descricao;
            return true;
        }

        public bool AlterarPreco(double preco)
        {
            Preco = preco;
            return true;
        }

        public void AdicionarCategoria(Categoria categoria)
        {
            Categorias.Add(categoria);
        }
    }
}
