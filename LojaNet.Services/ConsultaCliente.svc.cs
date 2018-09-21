using LojaNet.BLL;

namespace LojaNet.Services
{
    public class ConsultaCliente : IConsultaCliente
    {
        public ClienteInfo ConsultarPorEmail(string chave, string email)
        {
            if (chave != "1234567890@") return null;
            var bll = new ClienteBLL();
            var cliente = bll.ObterPorEmail(email);
            if (cliente == null) return null;
            else return new ClienteInfo(cliente.Nome, cliente.Email, cliente.Telefone);            
        }
    }
}
