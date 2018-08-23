using System.Collections.Generic;

namespace LojaNet.Models
{
    public interface IClienteDados
    {
        void Incluir(Cliente cliente);
        void Alterar(Cliente cliente);
        void Excluir(string Id);
        List<Cliente> ObterTodos();
        Cliente ObterPorId(string Id);
        Cliente ObterPorEmail(string email);
    }
}
