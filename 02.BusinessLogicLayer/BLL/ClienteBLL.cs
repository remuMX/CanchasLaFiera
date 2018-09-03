using BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ClienteBLL
    {
        private ClienteDAL clienteDAL = ClienteDAL.Instance();

        private static volatile ClienteBLL instance = null;
        private static readonly object padlock = new object();

        private ClienteBLL() { }

        public static ClienteBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ClienteBLL();
            return instance;
        }

        public bool Add(Cliente cliente)
        {
            return (clienteDAL.Add(cliente) > 0) ? true : false;
        }

        public Clientes GetAll()
        {
            return clienteDAL.GetAll();
        }



    }
}
