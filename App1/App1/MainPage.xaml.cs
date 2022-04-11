using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            int numero, outroNumero, resultado;

            numero = int.Parse(txtNumero.Text);
            outroNumero = int.Parse(txtoutroNumero.Text);
            resultado = numero + outroNumero;

            DisplayAlert("Calculo", $"{numero} + {outroNumero} = {resultado}", "OK");

            txtNumero.Text = "";
            txtoutroNumero.Text = "";
        }

        private void btnCalcularSub_Clicked(object sender, EventArgs e)
        {
            int numero, outroNumero, resultado;

            numero = int.Parse(txtNumero.Text);
            outroNumero = int.Parse(txtoutroNumero.Text);
            resultado = numero - outroNumero;

            DisplayAlert("Calculo", $"{numero} - {outroNumero} = {resultado}", "OK");

            txtNumero.Text = "";
            txtoutroNumero.Text = "";
        }

        private void btnCalcularDiv_Clicked(object sender, EventArgs e)
        {
            int numero, outroNumero, resultado;

            numero = int.Parse(txtNumero.Text);
            outroNumero = int.Parse(txtoutroNumero.Text);
            resultado = numero / outroNumero;

            DisplayAlert("Calculo", $"{numero} / {outroNumero} = {resultado}", "OK");

            txtNumero.Text = "";
            txtoutroNumero.Text = "";
        }

        private void btnCalcularMulti_Clicked(object sender, EventArgs e)
        {
            int numero, outroNumero, resultado;

            numero = int.Parse(txtNumero.Text);
            outroNumero = int.Parse(txtoutroNumero.Text);
            resultado = numero * outroNumero;

            DisplayAlert("Calculo", $"{numero} * {outroNumero} = {resultado}", "OK");

            txtNumero.Text = "";
            txtoutroNumero.Text = "";
        }
    }

}
