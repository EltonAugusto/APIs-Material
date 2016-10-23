using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Material.Dominio.Cadastros.Entidades;
using Material.Dominio.Cadastros.Specs;
using System;

namespace Material.Dominio.Testes.Cadastros.Specs
{
    [TestClass]
    public class ProdutoSpecsTestes
    {
        private List<Produto> _produtos = new List<Produto>();
        public ProdutoSpecsTestes()
        {
            _produtos = new List<Produto>();
            _produtos.Add(new Produto("Mouse Microsoft Basic", "Mouse Microsoft Basic preto sem fio",10));
            _produtos.Add(new Produto("Notebook Dell 5000 SERIES", "Notebook Dell 5000 SERIES i7 16gb de RAM",33));
            _produtos.Add(new Produto("Mouse Microsoft Basic", "Mouse Microsoft Basic preto sem fio",22));
        }

        [TestMethod]
        [TestCategory("Produto - Specification")]
        public void Obter_Por_Id()
        {
            var principal = _produtos.FirstOrDefault();

            var resultado = _produtos.AsQueryable().Where(ProdutoSpecs.ObterPorId(principal.Id.ToString())).ToList();

            Assert.AreEqual(resultado.Count(), 1);

        }
    }
}
