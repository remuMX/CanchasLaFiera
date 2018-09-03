using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public class Serializer
    {
        public int id_cancha { get; set; }

        public string rfc { get; set; }

        public DateTime entrada { get; set; }

        public DateTime salida { get; set; }

        public bool arbitro { get; set; }

        public decimal total { get; set; }

        public Serializer(int id_cancha, string rfc, DateTime entrada, DateTime salida, bool arbitro, decimal total)
        {
            this.id_cancha = id_cancha;
            this.rfc = rfc;
            this.entrada = entrada;
            this.salida = salida;
            this.arbitro = arbitro;
            this.total = total;
        }

        public Serializer()
        {
        }
    }

    public partial class NuevaReservacion : Form
    {
        string canchasBD="", reservacionesBD="", clientesBD="";
        DataTable dtReservaciones, dtCanchas, dtClientes;
        decimal total=0, costoCancha=0, costoArbitro=0, costodeHoras=0;
        int horas = 0; int id_response;
        string rfc, nombre;

        private void dtpFecha_ValueChanged(object sender, EventArgs e)
        {
            ChangeLabels();
        }

        private void dtpHora_ValueChanged(object sender, EventArgs e)
        {
            ChangeLabels();
        }

        private void cbHoras_SelectedValueChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbHoras.SelectedItem.ToString());
            horas = Convert.ToInt32(cbHoras.SelectedItem.ToString());
            ChangeLabels();
        }

        private void checkBArbitro_CheckedChanged(object sender, EventArgs e)
        {
            ChangeLabels();
        }

        private void tbRFC_TextChanged(object sender, EventArgs e)
        {
            ((DataTable)dgvClientes.DataSource).DefaultView.RowFilter = string.Format("rfc like'%{0}%'", tbRFC.Text.Trim().Replace("'", "''"));
            dgvClientes.Refresh();
        }

        private void cbHoras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NuevoCliente nCliente = new NuevoCliente();
            nCliente.ShowDialog();
            RefreshDGV();
            
        }

        public void ChangeLabels()
        {
            costoArbitro= Convert.ToDecimal((checkBArbitro.Checked) ? 1.5 : 1);
            total = Convert.ToDecimal((costoArbitro * costoCancha) * horas);
            lblCancha.Text = "$" + costoCancha.ToString();
            lblCostoArbitro.Text = "$" + costoArbitro*costoCancha;
            lblTotal.Text = "Total: $" + total.ToString();
            lblHoras.Text = cbHoras.Text + " hrs";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            Reservar();
        }

        async void Reservar()
        {
            DateTime date = Convert.ToDateTime(dtpFecha.Value.ToString().Substring(0, 10) + " " + dtpHora.Value.ToString().Substring(11, 14));
            DateTime date2 = date.AddHours(Convert.ToInt32(cbHoras.SelectedItem.ToString()));

            Serializer serializer = new Serializer(Convert.ToInt32( cbTipoCancha.SelectedValue.ToString()), rfc, date, date2, checkBArbitro.Checked, total);
                
            using (var httpClient = new HttpClient())
            {
                

                string json = JsonConvert.SerializeObject(serializer);
                var url = "http://localhost:49824/v1/api/reservaciones";
                

                var response = await httpClient.PostAsync(url, new StringContent(json, Encoding.UTF8, "application/json"));
                string responseStr =  await response.Content.ReadAsStringAsync();

                if (responseStr =="true") 
                {
                    MessageBox.Show("Reservacion creada!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Ocurrio un error, intente de nuevo o revise los datos del cliente");
                }
            }


        }

        private void dgvClientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in dgvClientes.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                rfc = (string)dgvClientes.CurrentRow.Cells[0].Value;
                nombre = (string)dgvClientes.CurrentRow.Cells[1].Value;
                lblCliente.Text = "Cliente seleccionado RFC: " + rfc + "\n Cliente: " + nombre;

            }
        }

        private void cbTipoCancha_ValueMemberChanged(object sender, EventArgs e)
        {
           
        }

        private void cbTipoCancha_SelectedValueChanged(object sender, EventArgs e)
        {
            foreach (DataRow item in dtCanchas.Rows)
            {

                if (item["id_cancha"].ToString() == cbTipoCancha.SelectedValue.ToString())
                {
                    costoCancha = Convert.ToDecimal((double)item["costo"]);
                }
            }

            ChangeLabels();

        }

        async void RefreshDGV()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responseClientes = await client.GetAsync("http://localhost:49824/v1/api/clientes"))
                {
                    using (HttpContent content = responseClientes.Content)
                    {
                        clientesBD = await content.ReadAsStringAsync();
                        //MessageBox.Show(canchasBD);
                        dtClientes = (DataTable)JsonConvert.DeserializeObject(clientesBD, (typeof(DataTable)));
                        dgvClientes.DataSource = dtClientes;
                    }
                }
            }
         }

        async void GetInitialValuesAsync()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage responseCanchas = await client.GetAsync("http://localhost:49824/v1/api/canchas"))
                {
                    using(HttpContent content = responseCanchas.Content)
                    {
                         canchasBD = await content.ReadAsStringAsync();
                        //MessageBox.Show(canchasBD);
                        dtCanchas = (DataTable)JsonConvert.DeserializeObject(canchasBD, (typeof(DataTable)));
                    }
                }

                using (HttpResponseMessage responseClientes = await client.GetAsync("http://localhost:49824/v1/api/clientes"))
                {
                    using(HttpContent content = responseClientes.Content)
                    {
                         clientesBD = await content.ReadAsStringAsync();
                        //MessageBox.Show(clientesBD);
                        dtClientes = (DataTable)JsonConvert.DeserializeObject(clientesBD, (typeof(DataTable)));
                    }
                }
                
                using (HttpResponseMessage responseReservaciones = await client.GetAsync("http://localhost:49824/v1/api/reservaciones/activas"))
                {
                    using (HttpContent content = responseReservaciones.Content)
                    {
                        reservacionesBD = await content.ReadAsStringAsync();
                        //MessageBox.Show(reservacionesBD);
                        dtReservaciones = (DataTable)JsonConvert.DeserializeObject(reservacionesBD, (typeof(DataTable)));
                    }
                }
            }
            InitializeComponent();

            cbTipoCancha.DataSource = dtCanchas;
            cbTipoCancha.DisplayMember = "tipo_cancha";
            cbTipoCancha.ValueMember = "id_cancha";

            foreach (DataRow item in dtCanchas.Rows)
            {

                if (item["id_cancha"].ToString() == cbTipoCancha.SelectedValue.ToString())
                {
                    costoCancha = Convert.ToDecimal((double)item["costo"]);
                }
            }

            for (int i = 0; i < 14; i++)
            {
                cbHoras.Items.Add(i+1);
            }

            dgvClientes.DataSource = dtClientes;
            dtpFecha.MinDate = DateTime.Now;
            dtpHora.MinDate = DateTime.Parse("08:00:00");
            dtpHora.MaxDate = DateTime.Parse("22:00:00");
            
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        public NuevaReservacion()
        {
            GetInitialValuesAsync();
        }

        private void NuevaReservacion_Load(object sender, EventArgs e)
        {
            
        }


        
    }
}
