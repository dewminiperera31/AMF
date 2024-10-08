﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace AMF.localhostTask {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    using System.Data;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="TaskServiceSoap", Namespace="http://tempuri.org/")]
    public partial class TaskService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback addTaskOperationCompleted;
        
        private System.Threading.SendOrPostCallback findTaskOperationCompleted;
        
        private System.Threading.SendOrPostCallback updateTaskOperationCompleted;
        
        private System.Threading.SendOrPostCallback deleteTaskOperationCompleted;
        
        private System.Threading.SendOrPostCallback viewAllTaskOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public TaskService() {
            this.Url = global::AMF.Properties.Settings.Default.AMF_localhostTask_TaskService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event addTaskCompletedEventHandler addTaskCompleted;
        
        /// <remarks/>
        public event findTaskCompletedEventHandler findTaskCompleted;
        
        /// <remarks/>
        public event updateTaskCompletedEventHandler updateTaskCompleted;
        
        /// <remarks/>
        public event deleteTaskCompletedEventHandler deleteTaskCompleted;
        
        /// <remarks/>
        public event viewAllTaskCompletedEventHandler viewAllTaskCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/addTask", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int addTask(int TaskID, string Title, string Description) {
            object[] results = this.Invoke("addTask", new object[] {
                        TaskID,
                        Title,
                        Description});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void addTaskAsync(int TaskID, string Title, string Description) {
            this.addTaskAsync(TaskID, Title, Description, null);
        }
        
        /// <remarks/>
        public void addTaskAsync(int TaskID, string Title, string Description, object userState) {
            if ((this.addTaskOperationCompleted == null)) {
                this.addTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OnaddTaskOperationCompleted);
            }
            this.InvokeAsync("addTask", new object[] {
                        TaskID,
                        Title,
                        Description}, this.addTaskOperationCompleted, userState);
        }
        
        private void OnaddTaskOperationCompleted(object arg) {
            if ((this.addTaskCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.addTaskCompleted(this, new addTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/findTask", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet findTask(int TaskID) {
            object[] results = this.Invoke("findTask", new object[] {
                        TaskID});
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void findTaskAsync(int TaskID) {
            this.findTaskAsync(TaskID, null);
        }
        
        /// <remarks/>
        public void findTaskAsync(int TaskID, object userState) {
            if ((this.findTaskOperationCompleted == null)) {
                this.findTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OnfindTaskOperationCompleted);
            }
            this.InvokeAsync("findTask", new object[] {
                        TaskID}, this.findTaskOperationCompleted, userState);
        }
        
        private void OnfindTaskOperationCompleted(object arg) {
            if ((this.findTaskCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.findTaskCompleted(this, new findTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/updateTask", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int updateTask(int TaskID, string Title, string Description) {
            object[] results = this.Invoke("updateTask", new object[] {
                        TaskID,
                        Title,
                        Description});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void updateTaskAsync(int TaskID, string Title, string Description) {
            this.updateTaskAsync(TaskID, Title, Description, null);
        }
        
        /// <remarks/>
        public void updateTaskAsync(int TaskID, string Title, string Description, object userState) {
            if ((this.updateTaskOperationCompleted == null)) {
                this.updateTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OnupdateTaskOperationCompleted);
            }
            this.InvokeAsync("updateTask", new object[] {
                        TaskID,
                        Title,
                        Description}, this.updateTaskOperationCompleted, userState);
        }
        
        private void OnupdateTaskOperationCompleted(object arg) {
            if ((this.updateTaskCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.updateTaskCompleted(this, new updateTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/deleteTask", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public int deleteTask(int TaskID) {
            object[] results = this.Invoke("deleteTask", new object[] {
                        TaskID});
            return ((int)(results[0]));
        }
        
        /// <remarks/>
        public void deleteTaskAsync(int TaskID) {
            this.deleteTaskAsync(TaskID, null);
        }
        
        /// <remarks/>
        public void deleteTaskAsync(int TaskID, object userState) {
            if ((this.deleteTaskOperationCompleted == null)) {
                this.deleteTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OndeleteTaskOperationCompleted);
            }
            this.InvokeAsync("deleteTask", new object[] {
                        TaskID}, this.deleteTaskOperationCompleted, userState);
        }
        
        private void OndeleteTaskOperationCompleted(object arg) {
            if ((this.deleteTaskCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.deleteTaskCompleted(this, new deleteTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/viewAllTask", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public System.Data.DataSet viewAllTask() {
            object[] results = this.Invoke("viewAllTask", new object[0]);
            return ((System.Data.DataSet)(results[0]));
        }
        
        /// <remarks/>
        public void viewAllTaskAsync() {
            this.viewAllTaskAsync(null);
        }
        
        /// <remarks/>
        public void viewAllTaskAsync(object userState) {
            if ((this.viewAllTaskOperationCompleted == null)) {
                this.viewAllTaskOperationCompleted = new System.Threading.SendOrPostCallback(this.OnviewAllTaskOperationCompleted);
            }
            this.InvokeAsync("viewAllTask", new object[0], this.viewAllTaskOperationCompleted, userState);
        }
        
        private void OnviewAllTaskOperationCompleted(object arg) {
            if ((this.viewAllTaskCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.viewAllTaskCompleted(this, new viewAllTaskCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void addTaskCompletedEventHandler(object sender, addTaskCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class addTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal addTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void findTaskCompletedEventHandler(object sender, findTaskCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class findTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal findTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void updateTaskCompletedEventHandler(object sender, updateTaskCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class updateTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal updateTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void deleteTaskCompletedEventHandler(object sender, deleteTaskCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class deleteTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal deleteTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public int Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((int)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    public delegate void viewAllTaskCompletedEventHandler(object sender, viewAllTaskCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.9032.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class viewAllTaskCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal viewAllTaskCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public System.Data.DataSet Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((System.Data.DataSet)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591