//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudyBank.PortableServices.CustomerProfiles {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CustomerProfileDto", Namespace="http://schemas.datacontract.org/2004/07/CloudyBank.Dto")]
    public partial class CustomerProfileDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private int HighAgeField;
        
        private int IdField;
        
        private int LowAgeField;
        
        private CloudyBank.PortableServices.CustomerProfiles.FamilySituation SituationField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int HighAge {
            get {
                return this.HighAgeField;
            }
            set {
                if ((this.HighAgeField.Equals(value) != true)) {
                    this.HighAgeField = value;
                    this.RaisePropertyChanged("HighAge");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int LowAge {
            get {
                return this.LowAgeField;
            }
            set {
                if ((this.LowAgeField.Equals(value) != true)) {
                    this.LowAgeField = value;
                    this.RaisePropertyChanged("LowAge");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public CloudyBank.PortableServices.CustomerProfiles.FamilySituation Situation {
            get {
                return this.SituationField;
            }
            set {
                if ((this.SituationField.Equals(value) != true)) {
                    this.SituationField = value;
                    this.RaisePropertyChanged("Situation");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="FamilySituation", Namespace="http://schemas.datacontract.org/2004/07/CloudyBank.CoreDomain.Customers")]
    public enum FamilySituation : int {
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        InCouple = 0,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Single = 1,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        Maried = 2,
        
        [System.Runtime.Serialization.EnumMemberAttribute()]
        NotSet = 3,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="octo.customerprofiles.service", ConfigurationName="CustomerProfiles.WCFCustomerProfileService")]
    public interface WCFCustomerProfileService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="octo.customerprofiles.service/WCFCustomerProfileService/GetCustomerProfiles", ReplyAction="octo.customerprofiles.service/WCFCustomerProfileService/GetCustomerProfilesRespon" +
            "se")]
        System.IAsyncResult BeginGetCustomerProfiles(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<CloudyBank.PortableServices.CustomerProfiles.CustomerProfileDto> EndGetCustomerProfiles(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WCFCustomerProfileServiceChannel : CloudyBank.PortableServices.CustomerProfiles.WCFCustomerProfileService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetCustomerProfilesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetCustomerProfilesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<CloudyBank.PortableServices.CustomerProfiles.CustomerProfileDto> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<CloudyBank.PortableServices.CustomerProfiles.CustomerProfileDto>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFCustomerProfileServiceClient : System.ServiceModel.ClientBase<CloudyBank.PortableServices.CustomerProfiles.WCFCustomerProfileService>, CloudyBank.PortableServices.CustomerProfiles.WCFCustomerProfileService {
        
        private BeginOperationDelegate onBeginGetCustomerProfilesDelegate;
        
        private EndOperationDelegate onEndGetCustomerProfilesDelegate;
        
        private System.Threading.SendOrPostCallback onGetCustomerProfilesCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public WCFCustomerProfileServiceClient() {
        }
        
        public WCFCustomerProfileServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFCustomerProfileServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFCustomerProfileServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFCustomerProfileServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<GetCustomerProfilesCompletedEventArgs> GetCustomerProfilesCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CloudyBank.PortableServices.CustomerProfiles.WCFCustomerProfileService.BeginGetCustomerProfiles(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetCustomerProfiles(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.Generic.List<CloudyBank.PortableServices.CustomerProfiles.CustomerProfileDto> CloudyBank.PortableServices.CustomerProfiles.WCFCustomerProfileService.EndGetCustomerProfiles(System.IAsyncResult result) {
            return base.Channel.EndGetCustomerProfiles(result);
        }
        
        private System.IAsyncResult OnBeginGetCustomerProfiles(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((CloudyBank.PortableServices.CustomerProfiles.WCFCustomerProfileService)(this)).BeginGetCustomerProfiles(callback, asyncState);
        }
        
        private object[] OnEndGetCustomerProfiles(System.IAsyncResult result) {
            System.Collections.Generic.List<CloudyBank.PortableServices.CustomerProfiles.CustomerProfileDto> retVal = ((CloudyBank.PortableServices.CustomerProfiles.WCFCustomerProfileService)(this)).EndGetCustomerProfiles(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetCustomerProfilesCompleted(object state) {
            if ((this.GetCustomerProfilesCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetCustomerProfilesCompleted(this, new GetCustomerProfilesCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetCustomerProfilesAsync() {
            this.GetCustomerProfilesAsync(null);
        }
        
        public void GetCustomerProfilesAsync(object userState) {
            if ((this.onBeginGetCustomerProfilesDelegate == null)) {
                this.onBeginGetCustomerProfilesDelegate = new BeginOperationDelegate(this.OnBeginGetCustomerProfiles);
            }
            if ((this.onEndGetCustomerProfilesDelegate == null)) {
                this.onEndGetCustomerProfilesDelegate = new EndOperationDelegate(this.OnEndGetCustomerProfiles);
            }
            if ((this.onGetCustomerProfilesCompletedDelegate == null)) {
                this.onGetCustomerProfilesCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetCustomerProfilesCompleted);
            }
            base.InvokeAsync(this.onBeginGetCustomerProfilesDelegate, null, this.onEndGetCustomerProfilesDelegate, this.onGetCustomerProfilesCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override CloudyBank.PortableServices.CustomerProfiles.WCFCustomerProfileService CreateChannel() {
            return new WCFCustomerProfileServiceClientChannel(this);
        }
        
        private class WCFCustomerProfileServiceClientChannel : ChannelBase<CloudyBank.PortableServices.CustomerProfiles.WCFCustomerProfileService>, CloudyBank.PortableServices.CustomerProfiles.WCFCustomerProfileService {
            
            public WCFCustomerProfileServiceClientChannel(System.ServiceModel.ClientBase<CloudyBank.PortableServices.CustomerProfiles.WCFCustomerProfileService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetCustomerProfiles(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetCustomerProfiles", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.Generic.List<CloudyBank.PortableServices.CustomerProfiles.CustomerProfileDto> EndGetCustomerProfiles(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.Generic.List<CloudyBank.PortableServices.CustomerProfiles.CustomerProfileDto> _result = ((System.Collections.Generic.List<CloudyBank.PortableServices.CustomerProfiles.CustomerProfileDto>)(base.EndInvoke("GetCustomerProfiles", _args, result)));
                return _result;
            }
        }
    }
}