using BOL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ReservacionBLL
    {
        private ReservacionDAL reservacionDAL = ReservacionDAL.Instance();

        private static volatile ReservacionBLL instance = null;
        private static readonly object padlock = new object();

        private ReservacionBLL() { }

        public static ReservacionBLL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ReservacionBLL();
            return instance;
        }


        public bool Add(Reservacion reservacion)
        {
            return (reservacionDAL.Add(reservacion) > 0) ? true : false;
        }

        public bool ChangeStatus(Reservacion reservacion)
        {
            return (reservacionDAL.ChangeStatus(reservacion) > 0) ? true : false;
        }

        public DataTable GetActivas()
        {
            return reservacionDAL.GetActivas();
        }

        public DataTable GetAll()
        {
            return reservacionDAL.GetAll();
        }

        public DataTable GetEspera()
        {
            return reservacionDAL.GetEspera();
        }
    }
}
