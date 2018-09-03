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
using Newtonsoft.Json;

namespace Client
{
    public partial class NuevoCliente : Form
    {
        private string responseStr;
        public NuevoCliente()
        {
            InitializeComponent();
        }



        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbRFC_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void tbNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            PostNuevoCliente(tbRFC.Text, tbNombre.Text, tbTelefono.Text);

        }

        async void PostNuevoCliente(string rfc, string nombre, string telefono)
        {
            var values = new Dictionary<string, string>
            {
                {"rfc", rfc},
                {"nombre", nombre},
                {"telefono", telefono}
            };
            using(var httpClient = new HttpClient())
            {
                using (var content = new FormUrlEncodedContent(values))
                {
                    var url = "http://localhost:49824/v1/api/clientes";
                    var response = await httpClient.PostAsync(url, content);
                    responseStr = await response.Content.ReadAsStringAsync();
                    if (responseStr == "true")
                    {
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Ocurrio un error, intente de nuevo o revise los datos del cliente");
                    }
                }
            }
        }
    }
}
