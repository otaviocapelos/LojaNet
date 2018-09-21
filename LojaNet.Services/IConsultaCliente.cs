using System.ServiceModel;

namespace LojaNet.Services
{
    [ServiceContract]
    public interface IConsultaCliente
    {
        [OperationContract]
        ClienteInfo ConsultarPorEmail(string chave, string email);
    }
}
