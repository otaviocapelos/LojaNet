using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace ExemploServico
{
    public class Service1 : Servico01
    {
        public string Mensagem()
        {
            return "Alterado:Isto vem de um servidor usando WCF";
        }

        public int Somar(int x, int y)
        {
            return x + y;
        }
    }
}
