using System;
using System.Collections.Generic;
using LojaNet.DAL;
using LojaNet.Models;

namespace LojaNet.BLL
{
    public class ClienteBLL : IClienteDados
    {
        public void Alterar(Cliente cliente)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(string Id)
        {
            throw new System.NotImplementedException();
        }

        public void Incluir(Cliente cliente)
        {
            if (string.IsNullOrEmpty(cliente.Nome))
            {
                throw new ApplicationException("O nome deve ser informado!");
            }
            if (string.IsNullOrEmpty(cliente.Id))
            {
                cliente.Id = Guid.NewGuid().ToString();
            }

            var dal = new ClienteDAL();
            dal.Incluir(cliente);
        }

        public Cliente ObterPorEmail(string email)
        {
            throw new System.NotImplementedException();
        }

        public Cliente ObterPorId(string Id)
        {
            throw new System.NotImplementedException();
        }

        public List<Cliente> ObterTodos()
        {
            throw new System.NotImplementedException();
        }
    }
}
