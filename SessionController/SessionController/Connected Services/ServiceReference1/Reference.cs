﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Bu kod araç tarafından oluşturuldu.
//     Çalışma Zamanı Sürümü:4.0.30319.42000
//
//     Bu dosyada yapılacak değişiklikler yanlış davranışa neden olabilir ve
//     kod yeniden oluşturulursa kaybolur.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SessionController.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.AddLoginInfoSoap")]
    public interface AddLoginInfoSoap {
        
        // CODEGEN: AddInfoRequest iletisinde üst bilgi olduğundan ileti sözleşmesi oluşturuluyor
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddInfo", ReplyAction="*")]
        [System.ServiceModel.XmlSerializerFormatAttribute(SupportFaults=true)]
        SessionController.ServiceReference1.AddInfoResponse AddInfo(SessionController.ServiceReference1.AddInfoRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/AddInfo", ReplyAction="*")]
        System.Threading.Tasks.Task<SessionController.ServiceReference1.AddInfoResponse> AddInfoAsync(SessionController.ServiceReference1.AddInfoRequest request);
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://tempuri.org/")]
    public partial class UserDetails : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string userNameField;
        
        private string passwordField;
        
        private System.Xml.XmlAttribute[] anyAttrField;
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public string userName {
            get {
                return this.userNameField;
            }
            set {
                this.userNameField = value;
                this.RaisePropertyChanged("userName");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public string password {
            get {
                return this.passwordField;
            }
            set {
                this.passwordField = value;
                this.RaisePropertyChanged("password");
            }
        }
        
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public System.Xml.XmlAttribute[] AnyAttr {
            get {
                return this.anyAttrField;
            }
            set {
                this.anyAttrField = value;
                this.RaisePropertyChanged("AnyAttr");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddInfo", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddInfoRequest {
        
        [System.ServiceModel.MessageHeaderAttribute(Namespace="http://tempuri.org/")]
        public SessionController.ServiceReference1.UserDetails UserDetails;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string kullaniciAdi;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public string macAdres;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=2)]
        public string durum;
        
        public AddInfoRequest() {
        }
        
        public AddInfoRequest(SessionController.ServiceReference1.UserDetails UserDetails, string kullaniciAdi, string macAdres, string durum) {
            this.UserDetails = UserDetails;
            this.kullaniciAdi = kullaniciAdi;
            this.macAdres = macAdres;
            this.durum = durum;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="AddInfoResponse", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class AddInfoResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public string AddInfoResult;
        
        public AddInfoResponse() {
        }
        
        public AddInfoResponse(string AddInfoResult) {
            this.AddInfoResult = AddInfoResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AddLoginInfoSoapChannel : SessionController.ServiceReference1.AddLoginInfoSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AddLoginInfoSoapClient : System.ServiceModel.ClientBase<SessionController.ServiceReference1.AddLoginInfoSoap>, SessionController.ServiceReference1.AddLoginInfoSoap {
        public UserDetails UserDetailsValue { get; internal set; }

        public AddLoginInfoSoapClient() {
        }
        
        public AddLoginInfoSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AddLoginInfoSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddLoginInfoSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AddLoginInfoSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SessionController.ServiceReference1.AddInfoResponse SessionController.ServiceReference1.AddLoginInfoSoap.AddInfo(SessionController.ServiceReference1.AddInfoRequest request) {
            return base.Channel.AddInfo(request);
        }
        
        public string AddInfo(SessionController.ServiceReference1.UserDetails UserDetails, string kullaniciAdi, string macAdres, string durum) {
            SessionController.ServiceReference1.AddInfoRequest inValue = new SessionController.ServiceReference1.AddInfoRequest();
            inValue.UserDetails = UserDetails;
            inValue.kullaniciAdi = kullaniciAdi;
            inValue.macAdres = macAdres;
            inValue.durum = durum;
            SessionController.ServiceReference1.AddInfoResponse retVal = ((SessionController.ServiceReference1.AddLoginInfoSoap)(this)).AddInfo(inValue);
            return retVal.AddInfoResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<SessionController.ServiceReference1.AddInfoResponse> SessionController.ServiceReference1.AddLoginInfoSoap.AddInfoAsync(SessionController.ServiceReference1.AddInfoRequest request) {
            return base.Channel.AddInfoAsync(request);
        }
        
        public System.Threading.Tasks.Task<SessionController.ServiceReference1.AddInfoResponse> AddInfoAsync(SessionController.ServiceReference1.UserDetails UserDetails, string kullaniciAdi, string macAdres, string durum) {
            SessionController.ServiceReference1.AddInfoRequest inValue = new SessionController.ServiceReference1.AddInfoRequest();
            inValue.UserDetails = UserDetails;
            inValue.kullaniciAdi = kullaniciAdi;
            inValue.macAdres = macAdres;
            inValue.durum = durum;
            return ((SessionController.ServiceReference1.AddLoginInfoSoap)(this)).AddInfoAsync(inValue);
        }
    }
}