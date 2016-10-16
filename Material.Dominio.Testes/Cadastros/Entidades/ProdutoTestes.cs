using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System;

namespace Material.Dominio.Cadastros.Entidades.Testes
{
    [TestClass]
    public class ProdutoTestes
    {
        private Produto _produto;
        public ProdutoTestes()
        {
             _produto = new Produto("Notebook Dell 5000 SERIES", "Notebook Dell 5000 SERIES i7 16gb de RAM");
        }

        [TestMethod]
        [TestCategory("Produto - Domínio")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Alterar_preco_para_negativo()
        {
            _produto.AlterarPreco(-10);
        }

        [TestMethod]
        [TestCategory("Produto - Domínio")]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Alterar_preco_para_zero()
        {
            _produto.AlterarPreco(0);
        }

        [TestMethod]
        [TestCategory("Produto - Domínio")]
        public void Alterar_preco_ok()
        {
            _produto.AlterarPreco(20);
        }

    }
}
