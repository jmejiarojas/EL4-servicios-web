﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace APP_MVC_TEST_WCF.ReferenciaNegocios {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Cliente", Namespace="http://schemas.datacontract.org/2004/07/WCFServicios")]
    [System.SerializableAttribute()]
    public partial class Cliente : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string IdClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NombreClienteField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string PaisField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string TelefonoField;
        
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
        public string Direccion {
            get {
                return this.DireccionField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionField, value) != true)) {
                    this.DireccionField = value;
                    this.RaisePropertyChanged("Direccion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string IdCliente {
            get {
                return this.IdClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.IdClienteField, value) != true)) {
                    this.IdClienteField = value;
                    this.RaisePropertyChanged("IdCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NombreCliente {
            get {
                return this.NombreClienteField;
            }
            set {
                if ((object.ReferenceEquals(this.NombreClienteField, value) != true)) {
                    this.NombreClienteField = value;
                    this.RaisePropertyChanged("NombreCliente");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Pais {
            get {
                return this.PaisField;
            }
            set {
                if ((object.ReferenceEquals(this.PaisField, value) != true)) {
                    this.PaisField = value;
                    this.RaisePropertyChanged("Pais");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Telefono {
            get {
                return this.TelefonoField;
            }
            set {
                if ((object.ReferenceEquals(this.TelefonoField, value) != true)) {
                    this.TelefonoField = value;
                    this.RaisePropertyChanged("Telefono");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Pedido", Namespace="http://schemas.datacontract.org/2004/07/WCFServicios")]
    [System.SerializableAttribute()]
    public partial class Pedido : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ClientePedidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string DireccionDestinatarioField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string EmpleadoPedidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.DateTime FechaPedidoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdPedidoField;
        
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
        public string ClientePedido {
            get {
                return this.ClientePedidoField;
            }
            set {
                if ((object.ReferenceEquals(this.ClientePedidoField, value) != true)) {
                    this.ClientePedidoField = value;
                    this.RaisePropertyChanged("ClientePedido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string DireccionDestinatario {
            get {
                return this.DireccionDestinatarioField;
            }
            set {
                if ((object.ReferenceEquals(this.DireccionDestinatarioField, value) != true)) {
                    this.DireccionDestinatarioField = value;
                    this.RaisePropertyChanged("DireccionDestinatario");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmpleadoPedido {
            get {
                return this.EmpleadoPedidoField;
            }
            set {
                if ((object.ReferenceEquals(this.EmpleadoPedidoField, value) != true)) {
                    this.EmpleadoPedidoField = value;
                    this.RaisePropertyChanged("EmpleadoPedido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.DateTime FechaPedido {
            get {
                return this.FechaPedidoField;
            }
            set {
                if ((this.FechaPedidoField.Equals(value) != true)) {
                    this.FechaPedidoField = value;
                    this.RaisePropertyChanged("FechaPedido");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int IdPedido {
            get {
                return this.IdPedidoField;
            }
            set {
                if ((this.IdPedidoField.Equals(value) != true)) {
                    this.IdPedidoField = value;
                    this.RaisePropertyChanged("IdPedido");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReferenciaNegocios.IServiceNegocios")]
    public interface IServiceNegocios {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNegocios/Clientes", ReplyAction="http://tempuri.org/IServiceNegocios/ClientesResponse")]
        APP_MVC_TEST_WCF.ReferenciaNegocios.Cliente[] Clientes();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNegocios/Clientes", ReplyAction="http://tempuri.org/IServiceNegocios/ClientesResponse")]
        System.Threading.Tasks.Task<APP_MVC_TEST_WCF.ReferenciaNegocios.Cliente[]> ClientesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNegocios/ClientesPorNombre", ReplyAction="http://tempuri.org/IServiceNegocios/ClientesPorNombreResponse")]
        APP_MVC_TEST_WCF.ReferenciaNegocios.Cliente[] ClientesPorNombre(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNegocios/ClientesPorNombre", ReplyAction="http://tempuri.org/IServiceNegocios/ClientesPorNombreResponse")]
        System.Threading.Tasks.Task<APP_MVC_TEST_WCF.ReferenciaNegocios.Cliente[]> ClientesPorNombreAsync(string nombre);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNegocios/PedidoPorCliente", ReplyAction="http://tempuri.org/IServiceNegocios/PedidoPorClienteResponse")]
        APP_MVC_TEST_WCF.ReferenciaNegocios.Pedido[] PedidoPorCliente(string cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNegocios/PedidoPorCliente", ReplyAction="http://tempuri.org/IServiceNegocios/PedidoPorClienteResponse")]
        System.Threading.Tasks.Task<APP_MVC_TEST_WCF.ReferenciaNegocios.Pedido[]> PedidoPorClienteAsync(string cliente);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNegocios/PedidoPorYear", ReplyAction="http://tempuri.org/IServiceNegocios/PedidoPorYearResponse")]
        APP_MVC_TEST_WCF.ReferenciaNegocios.Pedido[] PedidoPorYear(int anio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNegocios/PedidoPorYear", ReplyAction="http://tempuri.org/IServiceNegocios/PedidoPorYearResponse")]
        System.Threading.Tasks.Task<APP_MVC_TEST_WCF.ReferenciaNegocios.Pedido[]> PedidoPorYearAsync(int anio);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNegocios/PedidoPorFechas", ReplyAction="http://tempuri.org/IServiceNegocios/PedidoPorFechasResponse")]
        APP_MVC_TEST_WCF.ReferenciaNegocios.Pedido[] PedidoPorFechas(System.DateTime fechaInicial, System.DateTime fechaFinal);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServiceNegocios/PedidoPorFechas", ReplyAction="http://tempuri.org/IServiceNegocios/PedidoPorFechasResponse")]
        System.Threading.Tasks.Task<APP_MVC_TEST_WCF.ReferenciaNegocios.Pedido[]> PedidoPorFechasAsync(System.DateTime fechaInicial, System.DateTime fechaFinal);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceNegociosChannel : APP_MVC_TEST_WCF.ReferenciaNegocios.IServiceNegocios, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceNegociosClient : System.ServiceModel.ClientBase<APP_MVC_TEST_WCF.ReferenciaNegocios.IServiceNegocios>, APP_MVC_TEST_WCF.ReferenciaNegocios.IServiceNegocios {
        
        public ServiceNegociosClient() {
        }
        
        public ServiceNegociosClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceNegociosClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceNegociosClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceNegociosClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public APP_MVC_TEST_WCF.ReferenciaNegocios.Cliente[] Clientes() {
            return base.Channel.Clientes();
        }
        
        public System.Threading.Tasks.Task<APP_MVC_TEST_WCF.ReferenciaNegocios.Cliente[]> ClientesAsync() {
            return base.Channel.ClientesAsync();
        }
        
        public APP_MVC_TEST_WCF.ReferenciaNegocios.Cliente[] ClientesPorNombre(string nombre) {
            return base.Channel.ClientesPorNombre(nombre);
        }
        
        public System.Threading.Tasks.Task<APP_MVC_TEST_WCF.ReferenciaNegocios.Cliente[]> ClientesPorNombreAsync(string nombre) {
            return base.Channel.ClientesPorNombreAsync(nombre);
        }
        
        public APP_MVC_TEST_WCF.ReferenciaNegocios.Pedido[] PedidoPorCliente(string cliente) {
            return base.Channel.PedidoPorCliente(cliente);
        }
        
        public System.Threading.Tasks.Task<APP_MVC_TEST_WCF.ReferenciaNegocios.Pedido[]> PedidoPorClienteAsync(string cliente) {
            return base.Channel.PedidoPorClienteAsync(cliente);
        }
        
        public APP_MVC_TEST_WCF.ReferenciaNegocios.Pedido[] PedidoPorYear(int anio) {
            return base.Channel.PedidoPorYear(anio);
        }
        
        public System.Threading.Tasks.Task<APP_MVC_TEST_WCF.ReferenciaNegocios.Pedido[]> PedidoPorYearAsync(int anio) {
            return base.Channel.PedidoPorYearAsync(anio);
        }
        
        public APP_MVC_TEST_WCF.ReferenciaNegocios.Pedido[] PedidoPorFechas(System.DateTime fechaInicial, System.DateTime fechaFinal) {
            return base.Channel.PedidoPorFechas(fechaInicial, fechaFinal);
        }
        
        public System.Threading.Tasks.Task<APP_MVC_TEST_WCF.ReferenciaNegocios.Pedido[]> PedidoPorFechasAsync(System.DateTime fechaInicial, System.DateTime fechaFinal) {
            return base.Channel.PedidoPorFechasAsync(fechaInicial, fechaFinal);
        }
    }
}
