﻿//------------------------------------------------------------------------------
// <auto-generated>
//     O código foi gerado por uma ferramenta.
//     Versão de Tempo de Execução:4.0.30319.42000
//
//     As alterações ao arquivo poderão causar comportamento incorreto e serão perdidas se
//     o código for gerado novamente.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClienteWindows.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.Servico01")]
    public interface Servico01 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Servico01/Mensagem", ReplyAction="http://tempuri.org/Servico01/MensagemResponse")]
        string Mensagem();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Servico01/Mensagem", ReplyAction="http://tempuri.org/Servico01/MensagemResponse")]
        System.Threading.Tasks.Task<string> MensagemAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Servico01/Somar", ReplyAction="http://tempuri.org/Servico01/SomarResponse")]
        int Somar(int x, int y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Servico01/Somar", ReplyAction="http://tempuri.org/Servico01/SomarResponse")]
        System.Threading.Tasks.Task<int> SomarAsync(int x, int y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Servico01Channel : ClienteWindows.ServiceReference1.Servico01, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Servico01Client : System.ServiceModel.ClientBase<ClienteWindows.ServiceReference1.Servico01>, ClienteWindows.ServiceReference1.Servico01 {
        
        public Servico01Client() {
        }
        
        public Servico01Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Servico01Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Servico01Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Servico01Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Mensagem() {
            return base.Channel.Mensagem();
        }
        
        public System.Threading.Tasks.Task<string> MensagemAsync() {
            return base.Channel.MensagemAsync();
        }
        
        public int Somar(int x, int y) {
            return base.Channel.Somar(x, y);
        }
        
        public System.Threading.Tasks.Task<int> SomarAsync(int x, int y) {
            return base.Channel.SomarAsync(x, y);
        }
    }
}