﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFClient.MyFirstService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyFirstService.Iindex")]
    public interface Iindex {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Iindex/Getmessage", ReplyAction="http://tempuri.org/Iindex/GetmessageResponse")]
        string Getmessage(string Name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IindexChannel : WCFClient.MyFirstService.Iindex, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class IindexClient : System.ServiceModel.ClientBase<WCFClient.MyFirstService.Iindex>, WCFClient.MyFirstService.Iindex {
        
        public IindexClient() {
        }
        
        public IindexClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public IindexClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IindexClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public IindexClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Getmessage(string Name) {
            return base.Channel.Getmessage(Name);
        }
    }
}
