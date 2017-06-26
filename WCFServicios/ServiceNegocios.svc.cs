using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace WCFServicios
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "ServiceNegocios" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select ServiceNegocios.svc or ServiceNegocios.svc.cs at the Solution Explorer and start debugging.
    public class ServiceNegocios : IServiceNegocios
    {
        String con ="Server=.;Initial Catalog=Negocios2017;Integrated Security=true;";
        String uspListaClientes = "SP_LISTA_CLIENTES";
        String uspListaPedidos = "SP_LISTA_PEDIDOS";

        public List<Cliente> ListaClientes()
        {
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                myConnection.Open();

                using (SqlCommand cmd = new SqlCommand(uspListaClientes, myConnection))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        List<Cliente> clientes = new List<Cliente>();
                        while (dr.Read())
                        {
                            Cliente cliente = new Cliente();
                            cliente.IdCliente = dr[0].ToString();
                            cliente.NombreCliente = dr[1].ToString();
                            cliente.Direccion = dr[2].ToString();
                            cliente.Pais = dr[3].ToString();
                            cliente.Telefono = dr[4].ToString();
                            clientes.Add(cliente);
                        }

                        return clientes;
                    }
                }
            }
        }

        public List<Cliente> Clientes()
        {

            return ListaClientes();
        }

        public List<Cliente> ClientesPorNombre(string nombre)
        {
            if (nombre == null) nombre = string.Empty;

            return ListaClientes().Where(c => c.NombreCliente.StartsWith(nombre)).ToList();
        }

        public List<Pedido> ListaPedidos()
        {
            using (SqlConnection myConnection = new SqlConnection(con))
            {
                myConnection.Open();
                using (SqlCommand cmd = new SqlCommand(uspListaPedidos, myConnection))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    List<Pedido> listaPedidos = new List<Pedido>();

                    while (reader.Read())
                    {
                        Pedido pedido = new Pedido();
                        pedido.IdPedido = int.Parse(reader[0].ToString());
                        pedido.FechaPedido = (DateTime)reader[1];
                        pedido.DireccionDestinatario = reader[3].ToString();
                        pedido.EmpleadoPedido = reader[4].ToString();

                        listaPedidos.Add(pedido);
                    }

                    return listaPedidos;
                }
            }

        }

        public List<Pedido> PedidoPorCliente(string cliente)
        {
            return ListaPedidos().Where(p => p.ClientePedido == cliente).ToList();
        }

        public List<Pedido> PedidoPorFechas(DateTime fechaInicial, DateTime fechaFinal)
        {
            return ListaPedidos().Where(p => p.FechaPedido >= fechaInicial && p.FechaPedido <= fechaFinal).ToList();
        }

        public List<Pedido> PedidoPorYear(int anio)
        {
            return ListaPedidos().Where(p => p.FechaPedido.Year == anio).ToList();
        }
    }
}
