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
    public class Canchas: BindingList<Cancha>
    {
    }

    public class Cancha
    {
        public int id_cancha { get; set; }

        public string tipo_cancha { get; set; }

        public decimal costo { get; set; }

        public bool status { get; set; }

        public Cancha(int id_cancha, string tipo_cancha, decimal costo, bool status)
        {
            this.id_cancha = id_cancha;
            this.tipo_cancha = tipo_cancha;
            this.costo = costo;
            this.status = status;
        }

        public Cancha()
        {
        }
    }


    public class CanchaDAL
    {
        private DataAccess dataAccess = DataAccess.Instance();

        private static volatile CanchaDAL instance = null;
        private static readonly object padlock = new object();

        private CanchaDAL() { }

        public static CanchaDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new CanchaDAL();
            return instance;
        }


        public Canchas GetAll()
        {
            try
            {
                DataTable response = dataAccess.Query("stp_canchas_getall");
                Canchas canchas = new Canchas();
                foreach (DataRow item in response.Rows)
                {
                    Cancha cancha = new Cancha()
                    {
                        id_cancha = (int)item["id_cancha"],
                        tipo_cancha = (string)item["tipo_cancha"],
                        costo = (decimal)item["costo"]
                    };
                    canchas.Add(cancha);
                }
                return canchas;
            }catch(Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }

        }


    }
}
