using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOL
{
    public class Clientes: BindingList<Cliente>
    {
    }

    public class Cliente
    {
        public string rfc { get; set; }

        public string nombre { get; set; }

        public string telefono { get; set; }

        public bool status { get; set; }

        public Cliente(string rfc, string nombre, string telefono, bool status)
        {
            this.rfc = rfc;
            this.nombre = nombre;
            this.telefono = telefono;
            this.status = status;
        }

        public Cliente()
        {
        }
    }


    public class ClienteDAL
    {
        private DataAccess dataAccess = DataAccess.Instance();

        private static volatile ClienteDAL instance = null;
        private static readonly object padlock = new object();

        private ClienteDAL() { }

        public static ClienteDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ClienteDAL();
            return instance;
        }


        public int Add(Cliente cliente)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[3];
                parameters[0] = new SqlParameter("@rfc", cliente.rfc);
                parameters[1] = new SqlParameter("@nombre", cliente.nombre);
                parameters[2] = new SqlParameter("@telefono", cliente.telefono);

                return dataAccess.Execute("stp_clientes_add", parameters);
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }

        public Clientes GetAll()
        {
            try
            {
                DataTable resultado = dataAccess.Query("stp_clientes_getall");

                Clientes listClientes = new Clientes();

                foreach (DataRow item in resultado.Rows)
                {
                    Cliente cliente = new Cliente()
                    {
                        nombre = (string)item["nombre"],
                        rfc = (string)item["rfc"],
                        status = (bool)item["status"],
                        telefono = (string)item["telefono"]
                    };

                    listClientes.Add(cliente);

                }

                return listClientes;
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }






    }
}
