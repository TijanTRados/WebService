﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace senzor.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/webservis")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="userAddress", Namespace="http://schemas.datacontract.org/2004/07/webservis")]
    [System.SerializableAttribute()]
    public partial class userAddress : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double distanceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private senzor.ServiceReference1.sensorform senzorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double distance {
            get {
                return this.distanceField;
            }
            set {
                if ((this.distanceField.Equals(value) != true)) {
                    this.distanceField = value;
                    this.RaisePropertyChanged("distance");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public senzor.ServiceReference1.sensorform senzor {
            get {
                return this.senzorField;
            }
            set {
                if ((object.ReferenceEquals(this.senzorField, value) != true)) {
                    this.senzorField = value;
                    this.RaisePropertyChanged("senzor");
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="sensorform", Namespace="http://schemas.datacontract.org/2004/07/webservis")]
    [System.SerializableAttribute()]
    public partial class sensorform : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IPaddressField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double latitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private double longitudeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int portField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string usernameField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IPaddress {
            get {
                return this.IPaddressField;
            }
            set {
                if ((object.ReferenceEquals(this.IPaddressField, value) != true)) {
                    this.IPaddressField = value;
                    this.RaisePropertyChanged("IPaddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double latitude {
            get {
                return this.latitudeField;
            }
            set {
                if ((this.latitudeField.Equals(value) != true)) {
                    this.latitudeField = value;
                    this.RaisePropertyChanged("latitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public double longitude {
            get {
                return this.longitudeField;
            }
            set {
                if ((this.longitudeField.Equals(value) != true)) {
                    this.longitudeField = value;
                    this.RaisePropertyChanged("longitude");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int port {
            get {
                return this.portField;
            }
            set {
                if ((this.portField.Equals(value) != true)) {
                    this.portField = value;
                    this.RaisePropertyChanged("port");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string username {
            get {
                return this.usernameField;
            }
            set {
                if ((object.ReferenceEquals(this.usernameField, value) != true)) {
                    this.usernameField = value;
                    this.RaisePropertyChanged("username");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetData", ReplyAction="http://tempuri.org/IService1/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        senzor.ServiceReference1.CompositeType GetDataUsingDataContract(senzor.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetDataUsingDataContract", ReplyAction="http://tempuri.org/IService1/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<senzor.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(senzor.ServiceReference1.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/register", ReplyAction="http://tempuri.org/IService1/registerResponse")]
        bool register(string username, double latitude, double longitude, string IPaddress, int port);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/register", ReplyAction="http://tempuri.org/IService1/registerResponse")]
        System.Threading.Tasks.Task<bool> registerAsync(string username, double latitude, double longitude, string IPaddress, int port);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/distance", ReplyAction="http://tempuri.org/IService1/distanceResponse")]
        double distance(double lon1, double lon2, double lat1, double lat2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/distance", ReplyAction="http://tempuri.org/IService1/distanceResponse")]
        System.Threading.Tasks.Task<double> distanceAsync(double lon1, double lon2, double lat1, double lat2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/searchNeighbour", ReplyAction="http://tempuri.org/IService1/searchNeighbourResponse")]
        senzor.ServiceReference1.userAddress searchNeighbour(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/searchNeighbour", ReplyAction="http://tempuri.org/IService1/searchNeighbourResponse")]
        System.Threading.Tasks.Task<senzor.ServiceReference1.userAddress> searchNeighbourAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/storeMeasurement", ReplyAction="http://tempuri.org/IService1/storeMeasurementResponse")]
        bool storeMeasurement(string username, string parameter);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/storeMeasurement", ReplyAction="http://tempuri.org/IService1/storeMeasurementResponse")]
        System.Threading.Tasks.Task<bool> storeMeasurementAsync(string username, string parameter);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : senzor.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<senzor.ServiceReference1.IService1>, senzor.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public senzor.ServiceReference1.CompositeType GetDataUsingDataContract(senzor.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<senzor.ServiceReference1.CompositeType> GetDataUsingDataContractAsync(senzor.ServiceReference1.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public bool register(string username, double latitude, double longitude, string IPaddress, int port) {
            return base.Channel.register(username, latitude, longitude, IPaddress, port);
        }
        
        public System.Threading.Tasks.Task<bool> registerAsync(string username, double latitude, double longitude, string IPaddress, int port) {
            return base.Channel.registerAsync(username, latitude, longitude, IPaddress, port);
        }
        
        public double distance(double lon1, double lon2, double lat1, double lat2) {
            return base.Channel.distance(lon1, lon2, lat1, lat2);
        }
        
        public System.Threading.Tasks.Task<double> distanceAsync(double lon1, double lon2, double lat1, double lat2) {
            return base.Channel.distanceAsync(lon1, lon2, lat1, lat2);
        }
        
        public senzor.ServiceReference1.userAddress searchNeighbour(string username) {
            return base.Channel.searchNeighbour(username);
        }
        
        public System.Threading.Tasks.Task<senzor.ServiceReference1.userAddress> searchNeighbourAsync(string username) {
            return base.Channel.searchNeighbourAsync(username);
        }
        
        public bool storeMeasurement(string username, string parameter) {
            return base.Channel.storeMeasurement(username, parameter);
        }
        
        public System.Threading.Tasks.Task<bool> storeMeasurementAsync(string username, string parameter) {
            return base.Channel.storeMeasurementAsync(username, parameter);
        }
    }
}