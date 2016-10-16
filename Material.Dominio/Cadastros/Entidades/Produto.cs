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
        public Produto(string nome, string descricao)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Descricao = descricao;
        }

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Descricao { get; private set; }
        public double Preco { get; private set; }

        public void AlterarPreco(double preco)
        {
            //TODO: Implementar AssertionConcern e DomainNotifications para criar validações e notificações de dominio quando uma regra de negócio for infringida.
            if (preco <= 0)
                throw new InvalidOperationException("Preço deve ser maior que zero");
            Preco = preco;
        }
    }
}
