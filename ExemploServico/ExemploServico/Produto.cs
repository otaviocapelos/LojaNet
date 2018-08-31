using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace ExemploServico
{
    [DataContract]
    public class Produto
    {
        public int Id { get; set; }
        [DataMember]
        public string Nome { get; set; }
        [DataMember]
        public decimal Preco { get; set; }
    }
}