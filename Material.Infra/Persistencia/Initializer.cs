using Material.Dominio.Cadastros.Entidades;
using System.Collections.Generic;
using System.Data.Entity;

namespace Material.Infra.Persistencia
{
    public class Initializer : DropCreateDatabaseAlways<MaterialContext>
    {
        protected override void Seed(MaterialContext context)
        {
            context.Produtos.Add(new Produto("Notebook Dell 5000 SERIES", "Notebook Dell 5000 SERIES i7 16gb de RAM"));
            context.Produtos.Add(new Produto("Mouse Microsoft Basic", "Mouse Microsoft Basic preto sem fio"));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}
