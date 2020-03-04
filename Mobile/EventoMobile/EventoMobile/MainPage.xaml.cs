using EventoMobile.Rest_Servidor_Client;
using Festival.or;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Linq;

namespace EventoMobile
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private static readonly string URL_GET = "http://localhost:50030/api/juri";
        private static readonly string erroDefaul = "Algo errado";
        private List<Jurado> juri;
        public MainPage()
        {
            InitializeComponent();
            btnObter.Clicked += btnObter_Clicked;

            ClienteRest cliente = new ClienteRest();
            string resultado = string.Empty;
            try
            {
                resultado = cliente.obterDados(URL_GET);
            }
            catch (Exception)
            {
                lblWelcome.Text = erroDefaul;
                throw new Exception(erroDefaul);
            }
            juri = JsonConvert.DeserializeObject<List<Jurado>>(resultado);
            Jurado jurado = juri.Take(1).FirstOrDefault<Jurado>();

            foreach (Jurado juradoAtual in juri)
            {
                cmbJuri.Items.Add(juradoAtual.ToString());
            }
        }

        private void btnObter_Clicked(object sender, EventArgs e)
        {
            ClienteRest cliente = new ClienteRest();
            string resultado = string.Empty;
            try
            {
                resultado = cliente.obterDados(URL_GET);
            }
            catch (Exception)
            {
                lblWelcome.Text = erroDefaul;
                throw new Exception(erroDefaul);
            }
            juri = JsonConvert.DeserializeObject<List<Jurado>>(resultado);
            Jurado jurado = juri.Take(1).FirstOrDefault<Jurado>();
            lblWelcome.Text = jurado.nome;
 


        }
    }
}
