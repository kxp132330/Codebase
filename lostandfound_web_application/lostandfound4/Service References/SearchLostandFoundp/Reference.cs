﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lostandfound4.SearchLostandFoundp {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SearchLostandFoundp.SearchLostFoundSoap")]
    public interface SearchLostFoundSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLostandFound", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataTable GetLostandFound(string Type, int Location, int Category, System.DateTime date, string keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetLostandFound", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataTable> GetLostandFoundAsync(string Type, int Location, int Category, System.DateTime date, string keyword);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SearchLostFoundSoapChannel : lostandfound4.SearchLostandFoundp.SearchLostFoundSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SearchLostFoundSoapClient : System.ServiceModel.ClientBase<lostandfound4.SearchLostandFoundp.SearchLostFoundSoap>, lostandfound4.SearchLostandFoundp.SearchLostFoundSoap {
        
        public SearchLostFoundSoapClient() {
        }
        
        public SearchLostFoundSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SearchLostFoundSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SearchLostFoundSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SearchLostFoundSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataTable GetLostandFound(string Type, int Location, int Category, System.DateTime date, string keyword) {
            return base.Channel.GetLostandFound(Type, Location, Category, date, keyword);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataTable> GetLostandFoundAsync(string Type, int Location, int Category, System.DateTime date, string keyword) {
            return base.Channel.GetLostandFoundAsync(Type, Location, Category, date, keyword);
        }
    }
}
