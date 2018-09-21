using LojaNet.BLL;
using LojaNet.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LojaNet.Teste
{
    [TestClass]
    public class ClienteBLLTest
    {
        [TestMethod]
        public void IncluirNomeNull()
        {
            var cliente = new Cliente()
            {
                Nome = null,
                Email = "email@teste.com.br",
                Telefone = "4444-5555"
            };
            var bll = new ClienteBLL();
            bool ok = false;
            try
            {
                bll.Incluir(cliente);
            }
            catch (ApplicationException)
            {
                ok = true;
            }
            Assert.IsTrue(ok, "Deveria ter disparado uma Exception");
        }
        [TestMethod]
        public void IncluirNomeNotNull()
        {
            var cliente = new Cliente()
            {
                Nome = "TESTE",
                Email = "email@teste.com.br",
                Telefone = "4444-5555"
            };
            var bll = new ClienteBLL();
            bool ok = false;
            try
            {
                bll.Incluir(cliente);
                ok = true;
            }
            catch (ApplicationException)
            {
                ok = false;
            }
            Assert.IsTrue(ok, "Deveria ter disparado uma Exception");
        }
    }

}
