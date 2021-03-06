﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Calculator.ServiceReference2 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference2.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name getTextboxInfo from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        Calculator.ServiceReference2.AddResponse Add(Calculator.ServiceReference2.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<Calculator.ServiceReference2.AddResponse> AddAsync(Calculator.ServiceReference2.AddRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sub", ReplyAction="*")]
        double Sub(double getTextboxInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Sub", ReplyAction="*")]
        System.Threading.Tasks.Task<double> SubAsync(double getTextboxInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        double Mul(double getTextboxInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Mul", ReplyAction="*")]
        System.Threading.Tasks.Task<double> MulAsync(double getTextboxInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Dev", ReplyAction="*")]
        double Dev(double getTextboxInfo);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Dev", ReplyAction="*")]
        System.Threading.Tasks.Task<double> DevAsync(double getTextboxInfo);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Add", Namespace="http://tempuri.org/", Order=0)]
        public Calculator.ServiceReference2.AddRequestBody Body;
        
        public AddRequest() {
        }
        
        public AddRequest(Calculator.ServiceReference2.AddRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string getTextboxInfo;
        
        public AddRequestBody() {
        }
        
        public AddRequestBody(string getTextboxInfo) {
            this.getTextboxInfo = getTextboxInfo;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class AddResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="AddResponse", Namespace="http://tempuri.org/", Order=0)]
        public Calculator.ServiceReference2.AddResponseBody Body;
        
        public AddResponse() {
        }
        
        public AddResponse(Calculator.ServiceReference2.AddResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class AddResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double AddResult;
        
        public AddResponseBody() {
        }
        
        public AddResponseBody(double AddResult) {
            this.AddResult = AddResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Calculator.ServiceReference2.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Calculator.ServiceReference2.WebService1Soap>, Calculator.ServiceReference2.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Calculator.ServiceReference2.AddResponse Calculator.ServiceReference2.WebService1Soap.Add(Calculator.ServiceReference2.AddRequest request) {
            return base.Channel.Add(request);
        }
        
        public double Add(string getTextboxInfo) {
            Calculator.ServiceReference2.AddRequest inValue = new Calculator.ServiceReference2.AddRequest();
            inValue.Body = new Calculator.ServiceReference2.AddRequestBody();
            inValue.Body.getTextboxInfo = getTextboxInfo;
            Calculator.ServiceReference2.AddResponse retVal = ((Calculator.ServiceReference2.WebService1Soap)(this)).Add(inValue);
            return retVal.Body.AddResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Calculator.ServiceReference2.AddResponse> Calculator.ServiceReference2.WebService1Soap.AddAsync(Calculator.ServiceReference2.AddRequest request) {
            return base.Channel.AddAsync(request);
        }
        
        public System.Threading.Tasks.Task<Calculator.ServiceReference2.AddResponse> AddAsync(string getTextboxInfo) {
            Calculator.ServiceReference2.AddRequest inValue = new Calculator.ServiceReference2.AddRequest();
            inValue.Body = new Calculator.ServiceReference2.AddRequestBody();
            inValue.Body.getTextboxInfo = getTextboxInfo;
            return ((Calculator.ServiceReference2.WebService1Soap)(this)).AddAsync(inValue);
        }
        
        public double Sub(double getTextboxInfo) {
            return base.Channel.Sub(getTextboxInfo);
        }
        
        public System.Threading.Tasks.Task<double> SubAsync(double getTextboxInfo) {
            return base.Channel.SubAsync(getTextboxInfo);
        }
        
        public double Mul(double getTextboxInfo) {
            return base.Channel.Mul(getTextboxInfo);
        }
        
        public System.Threading.Tasks.Task<double> MulAsync(double getTextboxInfo) {
            return base.Channel.MulAsync(getTextboxInfo);
        }
        
        public double Dev(double getTextboxInfo) {
            return base.Channel.Dev(getTextboxInfo);
        }
        
        public System.Threading.Tasks.Task<double> DevAsync(double getTextboxInfo) {
            return base.Channel.DevAsync(getTextboxInfo);
        }
    }
}
