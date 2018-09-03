using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Pendientes : Form
    {
        private string reservacionesBD;

        async void GetInitialValuesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responseReservaciones = await client.GetAsync("http://localhost:49824/v1/api/canchas"))
                {
                    using (HttpContent content = responseReservaciones.Content)
                        reservacionesBD = await content.ReadAsStringAsync();
                    DataTable data = (DataTable)JsonConvert.DeserializeObject(reservacionesBD, (typeof(DataTable)));
                    
                    InitializeComponent();

                    dataGridView1.DataSource = data;
                }
            }
            
        }

        public Pendientes()
        {
            GetInitialValuesAsync();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
       
        private void Pendientes_Load(object sender, EventArgs e)
        {

        }

        private void txtNoReservacion_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("tipo_cancha like'%{0}%'", txtNoReservacion.Text.Trim().Replace("'", "''"));
            dataGridView1.Refresh();
        }

        private void txtRFC_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dataGridView1.DataSource).DefaultView.RowFilter = string.Format("rfc like'%{0}%'", txtNoReservacion.Text.Trim().Replace("'", "''"));
            dataGridView1.Refresh();
        }

        private void txtNoReservacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetterOrDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
