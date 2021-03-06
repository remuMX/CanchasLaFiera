﻿using DAL;
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
    public class Reservaciones: BindingList<Reservacion>
    {
    }

    public class Reservacion
    {
        public int id_reservacion { get; set; }

        public int id_cancha { get; set; }

        public DateTime entrada { get; set; }

        public DateTime salida { get; set; }

        public bool arbitro { get; set; }

        public string rfc { get; set; }

        public char estado_reservacion { get; set; }

        public decimal total { get; set; }

        public Reservacion(int id_reservacion, int id_cancha, DateTime entrada, DateTime salida, bool arbitro, string rfc, char estado_reservacion, decimal total)
        {
            this.id_reservacion = id_reservacion;
            this.id_cancha = id_cancha;
            this.entrada = entrada;
            this.salida = salida;
            this.arbitro = arbitro;
            this.rfc = rfc;
            this.estado_reservacion = estado_reservacion;
            this.total = total;
        }

        public Reservacion()
        {
        }
    }

    public class ReservacionDAL
    {
        private DataAccess dataAccess = DataAccess.Instance();

        private static volatile ReservacionDAL instance = null;
        private static readonly object padlock = new object();

        private ReservacionDAL() { }

        public static ReservacionDAL Instance()
        {
            if (instance == null)
                lock (padlock)
                    if (instance == null)
                        instance = new ReservacionDAL();
            return instance;
        }


        public int Add(Reservacion reservacion)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[6];

                parameters[0] = new SqlParameter("@id_cancha", reservacion.id_cancha);
                parameters[1] = new SqlParameter("@entrada", reservacion.entrada);
                parameters[2] = new SqlParameter("@salida", reservacion.salida);
                parameters[3] = new SqlParameter("@arbitro", reservacion.arbitro);
                parameters[4] = new SqlParameter("@rfc", reservacion.rfc);
                parameters[5] = new SqlParameter("@total", reservacion.total);

                return dataAccess.Execute("stp_reservaciones_add", parameters);
                

            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }

        public int ChangeStatus(Reservacion reservacion)
        {
            try
            {
                SqlParameter[] parameters = new SqlParameter[2];
                parameters[0] = new SqlParameter("@id_reservacion", reservacion.id_reservacion);
                parameters[1] = new SqlParameter("estado_reservacion", reservacion.estado_reservacion);

                return dataAccess.Execute("stp_reservaciones_changestatus", parameters);
            }
            catch (Exception ex)
            {

                throw new ApplicationException(ex.Message);
            }
        }


        public DataTable GetActivas()
        {
            return dataAccess.Query("stp_reservaciones_get_activas");
        }


        public DataTable GetAll()
        {
            return dataAccess.Query("stp_reservaciones_get_all");
        }
        public DataTable GetEspera()
        {
            return dataAccess.Query("stp_reservaciones_get_espera");
        }
    }


}
