//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CloudyBank.PortableServices.Tags {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="TagDto", Namespace="http://schemas.datacontract.org/2004/07/CloudyBank.Dto")]
    public partial class TagDto : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string DescriptionField;
        
        private int IdField;
        
        private string TitleField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Description {
            get {
                return this.DescriptionField;
            }
            set {
                if ((object.ReferenceEquals(this.DescriptionField, value) != true)) {
                    this.DescriptionField = value;
                    this.RaisePropertyChanged("Description");
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
        public string Title {
            get {
                return this.TitleField;
            }
            set {
                if ((object.ReferenceEquals(this.TitleField, value) != true)) {
                    this.TitleField = value;
                    this.RaisePropertyChanged("Title");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="octo.tags.service", ConfigurationName="Tags.WCFTagService")]
    public interface WCFTagService {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="octo.tags.service/WCFTagService/GetTagsForCustomer", ReplyAction="octo.tags.service/WCFTagService/GetTagsForCustomerResponse")]
        System.IAsyncResult BeginGetTagsForCustomer(int customerID, System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto> EndGetTagsForCustomer(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="octo.tags.service/WCFTagService/CreateTag", ReplyAction="octo.tags.service/WCFTagService/CreateTagResponse")]
        System.IAsyncResult BeginCreateTag(int customerID, CloudyBank.PortableServices.Tags.TagDto tag, System.AsyncCallback callback, object asyncState);
        
        void EndCreateTag(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="octo.tags.service/WCFTagService/TagOperation", ReplyAction="octo.tags.service/WCFTagService/TagOperationResponse")]
        System.IAsyncResult BeginTagOperation(int operationID, int tagID, System.AsyncCallback callback, object asyncState);
        
        void EndTagOperation(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="octo.tags.service/WCFTagService/UpdateTag", ReplyAction="octo.tags.service/WCFTagService/UpdateTagResponse")]
        System.IAsyncResult BeginUpdateTag(CloudyBank.PortableServices.Tags.TagDto tag, int customerID, System.AsyncCallback callback, object asyncState);
        
        void EndUpdateTag(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="octo.tags.service/WCFTagService/RemoveTag", ReplyAction="octo.tags.service/WCFTagService/RemoveTagResponse")]
        System.IAsyncResult BeginRemoveTag(int tagID, int customerID, System.AsyncCallback callback, object asyncState);
        
        void EndRemoveTag(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="octo.tags.service/WCFTagService/GetStandardTags", ReplyAction="octo.tags.service/WCFTagService/GetStandardTagsResponse")]
        System.IAsyncResult BeginGetStandardTags(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto> EndGetStandardTags(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WCFTagServiceChannel : CloudyBank.PortableServices.Tags.WCFTagService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetTagsForCustomerCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetTagsForCustomerCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetStandardTagsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetStandardTagsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WCFTagServiceClient : System.ServiceModel.ClientBase<CloudyBank.PortableServices.Tags.WCFTagService>, CloudyBank.PortableServices.Tags.WCFTagService {
        
        private BeginOperationDelegate onBeginGetTagsForCustomerDelegate;
        
        private EndOperationDelegate onEndGetTagsForCustomerDelegate;
        
        private System.Threading.SendOrPostCallback onGetTagsForCustomerCompletedDelegate;
        
        private BeginOperationDelegate onBeginCreateTagDelegate;
        
        private EndOperationDelegate onEndCreateTagDelegate;
        
        private System.Threading.SendOrPostCallback onCreateTagCompletedDelegate;
        
        private BeginOperationDelegate onBeginTagOperationDelegate;
        
        private EndOperationDelegate onEndTagOperationDelegate;
        
        private System.Threading.SendOrPostCallback onTagOperationCompletedDelegate;
        
        private BeginOperationDelegate onBeginUpdateTagDelegate;
        
        private EndOperationDelegate onEndUpdateTagDelegate;
        
        private System.Threading.SendOrPostCallback onUpdateTagCompletedDelegate;
        
        private BeginOperationDelegate onBeginRemoveTagDelegate;
        
        private EndOperationDelegate onEndRemoveTagDelegate;
        
        private System.Threading.SendOrPostCallback onRemoveTagCompletedDelegate;
        
        private BeginOperationDelegate onBeginGetStandardTagsDelegate;
        
        private EndOperationDelegate onEndGetStandardTagsDelegate;
        
        private System.Threading.SendOrPostCallback onGetStandardTagsCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public WCFTagServiceClient() {
        }
        
        public WCFTagServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WCFTagServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFTagServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WCFTagServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<GetTagsForCustomerCompletedEventArgs> GetTagsForCustomerCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CreateTagCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> TagOperationCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> UpdateTagCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> RemoveTagCompleted;
        
        public event System.EventHandler<GetStandardTagsCompletedEventArgs> GetStandardTagsCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CloudyBank.PortableServices.Tags.WCFTagService.BeginGetTagsForCustomer(int customerID, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetTagsForCustomer(customerID, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto> CloudyBank.PortableServices.Tags.WCFTagService.EndGetTagsForCustomer(System.IAsyncResult result) {
            return base.Channel.EndGetTagsForCustomer(result);
        }
        
        private System.IAsyncResult OnBeginGetTagsForCustomer(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int customerID = ((int)(inValues[0]));
            return ((CloudyBank.PortableServices.Tags.WCFTagService)(this)).BeginGetTagsForCustomer(customerID, callback, asyncState);
        }
        
        private object[] OnEndGetTagsForCustomer(System.IAsyncResult result) {
            System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto> retVal = ((CloudyBank.PortableServices.Tags.WCFTagService)(this)).EndGetTagsForCustomer(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetTagsForCustomerCompleted(object state) {
            if ((this.GetTagsForCustomerCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetTagsForCustomerCompleted(this, new GetTagsForCustomerCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetTagsForCustomerAsync(int customerID) {
            this.GetTagsForCustomerAsync(customerID, null);
        }
        
        public void GetTagsForCustomerAsync(int customerID, object userState) {
            if ((this.onBeginGetTagsForCustomerDelegate == null)) {
                this.onBeginGetTagsForCustomerDelegate = new BeginOperationDelegate(this.OnBeginGetTagsForCustomer);
            }
            if ((this.onEndGetTagsForCustomerDelegate == null)) {
                this.onEndGetTagsForCustomerDelegate = new EndOperationDelegate(this.OnEndGetTagsForCustomer);
            }
            if ((this.onGetTagsForCustomerCompletedDelegate == null)) {
                this.onGetTagsForCustomerCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetTagsForCustomerCompleted);
            }
            base.InvokeAsync(this.onBeginGetTagsForCustomerDelegate, new object[] {
                        customerID}, this.onEndGetTagsForCustomerDelegate, this.onGetTagsForCustomerCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CloudyBank.PortableServices.Tags.WCFTagService.BeginCreateTag(int customerID, CloudyBank.PortableServices.Tags.TagDto tag, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCreateTag(customerID, tag, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void CloudyBank.PortableServices.Tags.WCFTagService.EndCreateTag(System.IAsyncResult result) {
            base.Channel.EndCreateTag(result);
        }
        
        private System.IAsyncResult OnBeginCreateTag(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int customerID = ((int)(inValues[0]));
            CloudyBank.PortableServices.Tags.TagDto tag = ((CloudyBank.PortableServices.Tags.TagDto)(inValues[1]));
            return ((CloudyBank.PortableServices.Tags.WCFTagService)(this)).BeginCreateTag(customerID, tag, callback, asyncState);
        }
        
        private object[] OnEndCreateTag(System.IAsyncResult result) {
            ((CloudyBank.PortableServices.Tags.WCFTagService)(this)).EndCreateTag(result);
            return null;
        }
        
        private void OnCreateTagCompleted(object state) {
            if ((this.CreateTagCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CreateTagCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CreateTagAsync(int customerID, CloudyBank.PortableServices.Tags.TagDto tag) {
            this.CreateTagAsync(customerID, tag, null);
        }
        
        public void CreateTagAsync(int customerID, CloudyBank.PortableServices.Tags.TagDto tag, object userState) {
            if ((this.onBeginCreateTagDelegate == null)) {
                this.onBeginCreateTagDelegate = new BeginOperationDelegate(this.OnBeginCreateTag);
            }
            if ((this.onEndCreateTagDelegate == null)) {
                this.onEndCreateTagDelegate = new EndOperationDelegate(this.OnEndCreateTag);
            }
            if ((this.onCreateTagCompletedDelegate == null)) {
                this.onCreateTagCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCreateTagCompleted);
            }
            base.InvokeAsync(this.onBeginCreateTagDelegate, new object[] {
                        customerID,
                        tag}, this.onEndCreateTagDelegate, this.onCreateTagCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CloudyBank.PortableServices.Tags.WCFTagService.BeginTagOperation(int operationID, int tagID, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginTagOperation(operationID, tagID, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void CloudyBank.PortableServices.Tags.WCFTagService.EndTagOperation(System.IAsyncResult result) {
            base.Channel.EndTagOperation(result);
        }
        
        private System.IAsyncResult OnBeginTagOperation(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int operationID = ((int)(inValues[0]));
            int tagID = ((int)(inValues[1]));
            return ((CloudyBank.PortableServices.Tags.WCFTagService)(this)).BeginTagOperation(operationID, tagID, callback, asyncState);
        }
        
        private object[] OnEndTagOperation(System.IAsyncResult result) {
            ((CloudyBank.PortableServices.Tags.WCFTagService)(this)).EndTagOperation(result);
            return null;
        }
        
        private void OnTagOperationCompleted(object state) {
            if ((this.TagOperationCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.TagOperationCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void TagOperationAsync(int operationID, int tagID) {
            this.TagOperationAsync(operationID, tagID, null);
        }
        
        public void TagOperationAsync(int operationID, int tagID, object userState) {
            if ((this.onBeginTagOperationDelegate == null)) {
                this.onBeginTagOperationDelegate = new BeginOperationDelegate(this.OnBeginTagOperation);
            }
            if ((this.onEndTagOperationDelegate == null)) {
                this.onEndTagOperationDelegate = new EndOperationDelegate(this.OnEndTagOperation);
            }
            if ((this.onTagOperationCompletedDelegate == null)) {
                this.onTagOperationCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnTagOperationCompleted);
            }
            base.InvokeAsync(this.onBeginTagOperationDelegate, new object[] {
                        operationID,
                        tagID}, this.onEndTagOperationDelegate, this.onTagOperationCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CloudyBank.PortableServices.Tags.WCFTagService.BeginUpdateTag(CloudyBank.PortableServices.Tags.TagDto tag, int customerID, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpdateTag(tag, customerID, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void CloudyBank.PortableServices.Tags.WCFTagService.EndUpdateTag(System.IAsyncResult result) {
            base.Channel.EndUpdateTag(result);
        }
        
        private System.IAsyncResult OnBeginUpdateTag(object[] inValues, System.AsyncCallback callback, object asyncState) {
            CloudyBank.PortableServices.Tags.TagDto tag = ((CloudyBank.PortableServices.Tags.TagDto)(inValues[0]));
            int customerID = ((int)(inValues[1]));
            return ((CloudyBank.PortableServices.Tags.WCFTagService)(this)).BeginUpdateTag(tag, customerID, callback, asyncState);
        }
        
        private object[] OnEndUpdateTag(System.IAsyncResult result) {
            ((CloudyBank.PortableServices.Tags.WCFTagService)(this)).EndUpdateTag(result);
            return null;
        }
        
        private void OnUpdateTagCompleted(object state) {
            if ((this.UpdateTagCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UpdateTagCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UpdateTagAsync(CloudyBank.PortableServices.Tags.TagDto tag, int customerID) {
            this.UpdateTagAsync(tag, customerID, null);
        }
        
        public void UpdateTagAsync(CloudyBank.PortableServices.Tags.TagDto tag, int customerID, object userState) {
            if ((this.onBeginUpdateTagDelegate == null)) {
                this.onBeginUpdateTagDelegate = new BeginOperationDelegate(this.OnBeginUpdateTag);
            }
            if ((this.onEndUpdateTagDelegate == null)) {
                this.onEndUpdateTagDelegate = new EndOperationDelegate(this.OnEndUpdateTag);
            }
            if ((this.onUpdateTagCompletedDelegate == null)) {
                this.onUpdateTagCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdateTagCompleted);
            }
            base.InvokeAsync(this.onBeginUpdateTagDelegate, new object[] {
                        tag,
                        customerID}, this.onEndUpdateTagDelegate, this.onUpdateTagCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CloudyBank.PortableServices.Tags.WCFTagService.BeginRemoveTag(int tagID, int customerID, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginRemoveTag(tagID, customerID, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void CloudyBank.PortableServices.Tags.WCFTagService.EndRemoveTag(System.IAsyncResult result) {
            base.Channel.EndRemoveTag(result);
        }
        
        private System.IAsyncResult OnBeginRemoveTag(object[] inValues, System.AsyncCallback callback, object asyncState) {
            int tagID = ((int)(inValues[0]));
            int customerID = ((int)(inValues[1]));
            return ((CloudyBank.PortableServices.Tags.WCFTagService)(this)).BeginRemoveTag(tagID, customerID, callback, asyncState);
        }
        
        private object[] OnEndRemoveTag(System.IAsyncResult result) {
            ((CloudyBank.PortableServices.Tags.WCFTagService)(this)).EndRemoveTag(result);
            return null;
        }
        
        private void OnRemoveTagCompleted(object state) {
            if ((this.RemoveTagCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.RemoveTagCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void RemoveTagAsync(int tagID, int customerID) {
            this.RemoveTagAsync(tagID, customerID, null);
        }
        
        public void RemoveTagAsync(int tagID, int customerID, object userState) {
            if ((this.onBeginRemoveTagDelegate == null)) {
                this.onBeginRemoveTagDelegate = new BeginOperationDelegate(this.OnBeginRemoveTag);
            }
            if ((this.onEndRemoveTagDelegate == null)) {
                this.onEndRemoveTagDelegate = new EndOperationDelegate(this.OnEndRemoveTag);
            }
            if ((this.onRemoveTagCompletedDelegate == null)) {
                this.onRemoveTagCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnRemoveTagCompleted);
            }
            base.InvokeAsync(this.onBeginRemoveTagDelegate, new object[] {
                        tagID,
                        customerID}, this.onEndRemoveTagDelegate, this.onRemoveTagCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult CloudyBank.PortableServices.Tags.WCFTagService.BeginGetStandardTags(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetStandardTags(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto> CloudyBank.PortableServices.Tags.WCFTagService.EndGetStandardTags(System.IAsyncResult result) {
            return base.Channel.EndGetStandardTags(result);
        }
        
        private System.IAsyncResult OnBeginGetStandardTags(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((CloudyBank.PortableServices.Tags.WCFTagService)(this)).BeginGetStandardTags(callback, asyncState);
        }
        
        private object[] OnEndGetStandardTags(System.IAsyncResult result) {
            System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto> retVal = ((CloudyBank.PortableServices.Tags.WCFTagService)(this)).EndGetStandardTags(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetStandardTagsCompleted(object state) {
            if ((this.GetStandardTagsCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetStandardTagsCompleted(this, new GetStandardTagsCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetStandardTagsAsync() {
            this.GetStandardTagsAsync(null);
        }
        
        public void GetStandardTagsAsync(object userState) {
            if ((this.onBeginGetStandardTagsDelegate == null)) {
                this.onBeginGetStandardTagsDelegate = new BeginOperationDelegate(this.OnBeginGetStandardTags);
            }
            if ((this.onEndGetStandardTagsDelegate == null)) {
                this.onEndGetStandardTagsDelegate = new EndOperationDelegate(this.OnEndGetStandardTags);
            }
            if ((this.onGetStandardTagsCompletedDelegate == null)) {
                this.onGetStandardTagsCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetStandardTagsCompleted);
            }
            base.InvokeAsync(this.onBeginGetStandardTagsDelegate, null, this.onEndGetStandardTagsDelegate, this.onGetStandardTagsCompletedDelegate, userState);
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
        
        protected override CloudyBank.PortableServices.Tags.WCFTagService CreateChannel() {
            return new WCFTagServiceClientChannel(this);
        }
        
        private class WCFTagServiceClientChannel : ChannelBase<CloudyBank.PortableServices.Tags.WCFTagService>, CloudyBank.PortableServices.Tags.WCFTagService {
            
            public WCFTagServiceClientChannel(System.ServiceModel.ClientBase<CloudyBank.PortableServices.Tags.WCFTagService> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetTagsForCustomer(int customerID, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = customerID;
                System.IAsyncResult _result = base.BeginInvoke("GetTagsForCustomer", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto> EndGetTagsForCustomer(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto> _result = ((System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto>)(base.EndInvoke("GetTagsForCustomer", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginCreateTag(int customerID, CloudyBank.PortableServices.Tags.TagDto tag, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = customerID;
                _args[1] = tag;
                System.IAsyncResult _result = base.BeginInvoke("CreateTag", _args, callback, asyncState);
                return _result;
            }
            
            public void EndCreateTag(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("CreateTag", _args, result);
            }
            
            public System.IAsyncResult BeginTagOperation(int operationID, int tagID, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = operationID;
                _args[1] = tagID;
                System.IAsyncResult _result = base.BeginInvoke("TagOperation", _args, callback, asyncState);
                return _result;
            }
            
            public void EndTagOperation(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("TagOperation", _args, result);
            }
            
            public System.IAsyncResult BeginUpdateTag(CloudyBank.PortableServices.Tags.TagDto tag, int customerID, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = tag;
                _args[1] = customerID;
                System.IAsyncResult _result = base.BeginInvoke("UpdateTag", _args, callback, asyncState);
                return _result;
            }
            
            public void EndUpdateTag(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("UpdateTag", _args, result);
            }
            
            public System.IAsyncResult BeginRemoveTag(int tagID, int customerID, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = tagID;
                _args[1] = customerID;
                System.IAsyncResult _result = base.BeginInvoke("RemoveTag", _args, callback, asyncState);
                return _result;
            }
            
            public void EndRemoveTag(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("RemoveTag", _args, result);
            }
            
            public System.IAsyncResult BeginGetStandardTags(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetStandardTags", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto> EndGetStandardTags(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto> _result = ((System.Collections.Generic.List<CloudyBank.PortableServices.Tags.TagDto>)(base.EndInvoke("GetStandardTags", _args, result)));
                return _result;
            }
        }
    }
}
