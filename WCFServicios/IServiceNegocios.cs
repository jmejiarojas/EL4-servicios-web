using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFServicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IServiceNegocios" in both code and config file together.
    [ServiceContract]
    public interface IServiceNegocios
    {
        [OperationContract]
        List<Cliente> Clientes();

        [OperationContract]
        List<Cliente> ClientesPorNombre(String nombre);

        [OperationContract]
        List<Pedido> PedidoPorCliente(String cliente);

        [OperationContract]
        List<Pedido> PedidoPorYear(int anio);

        [OperationContract]
        List<Pedido> PedidoPorFechas(DateTime fechaInicial, DateTime fechaFinal);
        
    }

    [DataContract]
    public class Cliente
    {
        [DataMember]
        public String IdCliente { get; set; }

        [DataMember]
        public String NombreCliente { get; set; }

        [DataMember]
        public String Direccion { get; set; }

        [DataMember]
        public String Pais { get; set; }

        [DataMember]
        public String  Telefono { get; set; }
    }

    [DataContract]
    public class Pedido
    {
        [DataMember]
        public int IdPedido { get; set; }

        [DataMember]
        public DateTime FechaPedido { get; set; }

        [DataMember]
        public String ClientePedido { get; set; }

        [DataMember]
        public String DireccionDestinatario { get; set; }

        [DataMember]
        public String EmpleadoPedido { get; set; }
    }
}
