using Material.Dominio.Cadastros.Entidades;
using System.Collections.Generic;
using System.Data.Entity;
using System;

namespace Material.Infra.Persistencia
{
    public class Initializer : DropCreateDatabaseAlways<MaterialContext>
    {
      

        protected override void Seed(MaterialContext context)
        {
            base.Seed(context);


            var lista = new List<Produto>();
            var listaCat = new List<Categoria>();

            lista.Add(new Produto("Notebook Dell 5000 SERIES", "Notebook Dell 5000 SERIES i7 16gb de RAM", 10));
            lista.Add(new Produto("Mouse Microsoft Basic", "Mouse Microsoft Basic preto sem fio", 10));
            lista.Add(new Produto("Notebook Dell 9000 SERIES", "Notebook Dell 5000 SERIES i7 16gb de RAM", 10));
            lista.Add(new Produto("Mouse Microsoft Vasic", "Mouse Microsoft Basic preto sem fio", 10));
            lista.Add(new Produto("Notebook Dell 1000 SERIES", "Notebook Dell 5000 SERIES i7 16gb de RAM", 14));
            lista.Add(new Produto("Mouse Microsoft Xasic", "Mouse Microsoft Basic preto sem fio", 22));
            lista.Add(new Produto("Notebook Dell 99000 SERIES", "Notebook Dell 5000 SERIES i7 16gb de RAM", 96));

            listaCat.Add(new Categoria("INFOZ", "Informática"));
            listaCat.Add(new Categoria("INFOB", "Informática"));

            lista.ForEach(x => listaCat.ForEach(y=> x.AdicionarCategoria(y) ) );

            listaCat.ForEach(x => context.Categorias.Add(x));

            lista.ForEach(x => context.Produtos.Add(x));

            context.SaveChanges();

        }

      
    }
}
