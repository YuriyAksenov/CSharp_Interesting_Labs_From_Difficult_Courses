﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MasterServiceLibrary.NodeService4 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="NodeService4.INodeService4")]
    public interface INodeService4 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INodeService4/SumOfSquares", ReplyAction="http://tempuri.org/INodeService4/SumOfSquaresResponse")]
        double SumOfSquares(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INodeService4/SumOfSquares", ReplyAction="http://tempuri.org/INodeService4/SumOfSquaresResponse")]
        System.Threading.Tasks.Task<double> SumOfSquaresAsync(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INodeService4/MagicOperation", ReplyAction="http://tempuri.org/INodeService4/MagicOperationResponse")]
        double MagicOperation(double x, double y);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/INodeService4/MagicOperation", ReplyAction="http://tempuri.org/INodeService4/MagicOperationResponse")]
        System.Threading.Tasks.Task<double> MagicOperationAsync(double x, double y);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface INodeService4Channel : MasterServiceLibrary.NodeService4.INodeService4, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NodeService4Client : System.ServiceModel.ClientBase<MasterServiceLibrary.NodeService4.INodeService4>, MasterServiceLibrary.NodeService4.INodeService4 {
        
        public NodeService4Client() {
        }
        
        public NodeService4Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NodeService4Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NodeService4Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NodeService4Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double SumOfSquares(double x, double y) {
            return base.Channel.SumOfSquares(x, y);
        }
        
        public System.Threading.Tasks.Task<double> SumOfSquaresAsync(double x, double y) {
            return base.Channel.SumOfSquaresAsync(x, y);
        }
        
        public double MagicOperation(double x, double y) {
            return base.Channel.MagicOperation(x, y);
        }
        
        public System.Threading.Tasks.Task<double> MagicOperationAsync(double x, double y) {
            return base.Channel.MagicOperationAsync(x, y);
        }
    }
}
