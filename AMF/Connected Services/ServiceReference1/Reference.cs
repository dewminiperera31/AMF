﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AMF.ServiceReference1 {
    using System.Data;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.TaskServiceSoap")]
    public interface TaskServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addTask", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int addTask(int TaskID, string Title, string Description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/addTask", ReplyAction="*")]
        System.Threading.Tasks.Task<int> addTaskAsync(int TaskID, string Title, string Description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/findTask", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet findTask(int TaskID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/findTask", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> findTaskAsync(int TaskID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateTask", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int updateTask(int TaskID, string Title, string Description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/updateTask", ReplyAction="*")]
        System.Threading.Tasks.Task<int> updateTaskAsync(int TaskID, string Title, string Description);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteTask", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        int deleteTask(int TaskID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/deleteTask", ReplyAction="*")]
        System.Threading.Tasks.Task<int> deleteTaskAsync(int TaskID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/viewAllTask", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        System.Data.DataSet viewAllTask();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/viewAllTask", ReplyAction="*")]
        System.Threading.Tasks.Task<System.Data.DataSet> viewAllTaskAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TaskServiceSoapChannel : AMF.ServiceReference1.TaskServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TaskServiceSoapClient : System.ServiceModel.ClientBase<AMF.ServiceReference1.TaskServiceSoap>, AMF.ServiceReference1.TaskServiceSoap {
        
        public TaskServiceSoapClient() {
        }
        
        public TaskServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TaskServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TaskServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TaskServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int addTask(int TaskID, string Title, string Description) {
            return base.Channel.addTask(TaskID, Title, Description);
        }
        
        public System.Threading.Tasks.Task<int> addTaskAsync(int TaskID, string Title, string Description) {
            return base.Channel.addTaskAsync(TaskID, Title, Description);
        }
        
        public System.Data.DataSet findTask(int TaskID) {
            return base.Channel.findTask(TaskID);
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> findTaskAsync(int TaskID) {
            return base.Channel.findTaskAsync(TaskID);
        }
        
        public int updateTask(int TaskID, string Title, string Description) {
            return base.Channel.updateTask(TaskID, Title, Description);
        }
        
        public System.Threading.Tasks.Task<int> updateTaskAsync(int TaskID, string Title, string Description) {
            return base.Channel.updateTaskAsync(TaskID, Title, Description);
        }
        
        public int deleteTask(int TaskID) {
            return base.Channel.deleteTask(TaskID);
        }
        
        public System.Threading.Tasks.Task<int> deleteTaskAsync(int TaskID) {
            return base.Channel.deleteTaskAsync(TaskID);
        }
        
        public System.Data.DataSet viewAllTask() {
            return base.Channel.viewAllTask();
        }
        
        public System.Threading.Tasks.Task<System.Data.DataSet> viewAllTaskAsync() {
            return base.Channel.viewAllTaskAsync();
        }
    }
}
