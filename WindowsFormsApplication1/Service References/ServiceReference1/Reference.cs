﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18051
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WindowsFormsApplication1.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ItimeService")]
    public interface ItimeService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ItimeService/DoWork", ReplyAction="http://tempuri.org/ItimeService/DoWorkResponse")]
        string DoWork();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ItimeServiceChannel : WindowsFormsApplication1.ServiceReference1.ItimeService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ItimeServiceClient : System.ServiceModel.ClientBase<WindowsFormsApplication1.ServiceReference1.ItimeService>, WindowsFormsApplication1.ServiceReference1.ItimeService {
        
        public ItimeServiceClient() {
        }
        
        public ItimeServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ItimeServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItimeServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItimeServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string DoWork() {
            return base.Channel.DoWork();
        }
    }
}
