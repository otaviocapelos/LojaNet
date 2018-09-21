using System.Runtime.Serialization;

namespace LojaNet.Services
{
    [DataContract]
    public class ClienteInfo
    {
        [DataMember]
        public string Nome { get; private set; }
        [DataMember]
        public string Email { get; private set; }
        [DataMember]
        public string Telefone { get; private set; }
        public ClienteInfo(string nome, string email, string telefone)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }
    }
}