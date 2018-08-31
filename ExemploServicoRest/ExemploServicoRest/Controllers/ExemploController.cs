using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ExemploServicoRest.Controllers
{
    public class ExemploController : ApiController
    {
        private List<Fornecedor> ObterFornecedores()
        {
            var lista = new List<Fornecedor>();
            lista.Add(new Fornecedor() { Id = 1, Nome = "EmpresaX", Email = "contato@empresaX.com.br" });
            lista.Add(new Fornecedor() { Id = 2, Nome = "EmpresaY", Email = "contato@empresaY.com.br" });
            return lista;
        }
        // GET api/<controller>
        public IEnumerable<Fornecedor> Get()
        {
            return ObterFornecedores();
        }

        // GET api/<controller>/5
        public Fornecedor Get(int id)
        {
            return ObterFornecedores().Where(m => m.Id == id).First();
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}