using System;
using LojaNet.DAL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LojaNet.Teste
{
    [TestClass]
    public class ClienteDALTest
    {
        [TestMethod]
        public void ObterPorEmailTest()
        {
            string email = "teste@teste.com";
            var dal = new ClienteDAL();
            var cliente = dal.ObterPorEmail(email);
            Assert.IsTrue(cliente != null, "Deveria ter retornado uma instancia de um Cliente!");
        }

        [TestMethod]
        public void ObterPorEmailNullTest()
        {
            string email = null;
            var dal = new ClienteDAL();
            bool ok = false;
            try
            {
                var cliente = dal.ObterPorEmail(email);
            }
            catch (ApplicationException ex)
            {
                if (ex.Message == "O email deve ser informado")
                {
                    ok = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro no Servidor, parametro não informado");
            }
            Assert.IsTrue(ok, "Deveria ter disparado um ApplicationException com a mensagem 'O email deve ser informado'");
        }
    }
}
