using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App1_ConsultarCEP.Servico.Modelo;
using App1_ConsultarCEP.Servico;

namespace App1_ConsultarCEP
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            btBuscar.Clicked += BuscarCEP;
        }

        private void BuscarCEP(object sender, EventArgs args)
        {
            string cep = txtCEP.Text.Trim();
            Endereco end = ViaCEP_Servico.BuscaEndereco(cep);

            lblResultado.Text = string.Format("Endereço: \n {0}, \n {1}, \n {2}, \n {3}", end.Logradouro,end.Complemento, end.Localidade, end.Bairro);

            //"\r\n"
        }
    }
}
