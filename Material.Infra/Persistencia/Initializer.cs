using Material.Dominio.Cadastros.Entidades;
using System.Collections.Generic;
using System.Data.Entity;

namespace Material.Infra.Persistencia
{
    public class Initializer : DropCreateDatabaseAlways<MaterialContext>
    {
        protected override void Seed(MaterialContext context)
        {
            var lista = new List<Produto>();

            lista.Add(new Produto("Notebook Dell 5000 SERIES", "Notebook Dell 5000 SERIES i7 16gb de RAM"));
            lista.Add(new Produto("Mouse Microsoft Basic", "Mouse Microsoft Basic preto sem fio"));
            lista.Add(new Produto("Notebook Dell 9000 SERIES", "Notebook Dell 5000 SERIES i7 16gb de RAM"));
            lista.Add(new Produto("Mouse Microsoft Vasic", "Mouse Microsoft Basic preto sem fio"));
            lista.Add(new Produto("Notebook Dell 1000 SERIES", "Notebook Dell 5000 SERIES i7 16gb de RAM"));
            lista.Add(new Produto("Mouse Microsoft Xasic", "Mouse Microsoft Basic preto sem fio"));
            lista.Add(new Produto("Notebook Dell 99000 SERIES", "Notebook Dell 5000 SERIES i7 16gb de RAM"));
            lista.Add(new Produto("Mouse Microsoft Yasic", "Mouse Microsoft Basic preto sem fio"));

            lista.ForEach(x => x.AlterarPreco(10));
            lista.ForEach(x => context.Produtos.Add(x));

            context.SaveChanges();

            base.Seed(context);
        }
    }
}
