using LojaNet.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Web;

namespace LojaNet.DAL
{
    public class ClienteDAL : IClienteDados
    {
        public void Alterar(Cliente cliente)
        {
            DbHelper.ExecuteNonQuery("ClienteAlterar",
                "@Id", cliente.Id,
                "@Nome", cliente.Nome,
                "@Email", cliente.Email,
                "@Telefone", cliente.Telefone
                );
        }

        public void Excluir(string Id)
        {
            string arquivo = HttpContext.Current.Server.MapPath($"~/App_Data/Cliente_{Id}.xml");
            Cliente cliente = ObterPorId(Id);
            SerializadorHelper.Serializar(arquivo, cliente);
            DbHelper.ExecuteNonQuery("ClienteExcluir", "@Id", Id);
        }

        public void Incluir(Cliente cliente)
        {
            DbHelper.ExecuteNonQuery("ClienteIncluir",
                "@Id", cliente.Id,
                "@Nome", cliente.Nome,
                "@Email", cliente.Email,
                "@Telefone", cliente.Telefone
                );
        }

        public Cliente ObterPorEmail(string email)
        {
            if (string.IsNullOrEmpty(email))
            {
                throw new ApplicationException("O email deve ser informado");
            }
            Cliente cliente = null;
            using (var reader = DbHelper.ExecuteReader("ClienteObterPorEmail", "@email", email))
            {
                if (reader.Read())
                {
                    cliente = ObterClienteReader(reader);
                }
            }
            return cliente;
        }

        public Cliente ObterPorId(string Id)
        {
            Cliente cliente = null;
            using (var reader = DbHelper.ExecuteReader("ClienteObterPorId", "@Id", Id))
            {
                if (reader.Read())
                {
                    cliente = ObterClienteReader(reader);
                }
            }
            return cliente;
        }

        public List<Cliente> ObterTodos()
        {
            var lista = new List<Cliente>();
            using (var reader = DbHelper.ExecuteReader("ClienteListar"))
            {
                while (reader.Read())
                {
                    lista.Add(ObterClienteReader(reader));
                }
                return lista;
            }
        }

        private static Cliente ObterClienteReader(IDataReader reader)
        {
            var cliente = new Cliente
            {
                Id = reader["Id"].ToString(),
                Nome = reader["Nome"].ToString(),
                Email = reader["Email"].ToString(),
                Telefone = reader["Telefone"].ToString()
            };
            return cliente;
        }
    }
}
