using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace jmantillaExamen
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Registro : ContentPage
    {
        public Registro(string usuario)
        {
            InitializeComponent();
            lblUsuario.Text = usuario;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {

            //double datoSeguimientoUno = Convert.ToDouble(txtDatoSeguimientoUno.Text) * 0.3;
            double pagoAdicional = 4000 * 0.05;
            double pagoInicial= Convert.ToDouble(txtMontoInicial.Text);
            double pagoMensual = ((4000 - pagoInicial) / 5) + pagoAdicional;
            string nombre = txtNombre.Text;
            lblPagoMensual.Text = Convert.ToString(pagoMensual);

            
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            string usuario = lblUsuario.Text;
            double pagoAdicional = 4000 * 0.05;
            string nombre = txtNombre.Text;
            double pagoInicial = Convert.ToDouble(txtMontoInicial.Text);
            double pagoMensual = ((4000 - pagoInicial) / 5) + pagoAdicional;
            DisplayAlert("Guardado con Exito", nombre, "Cerrar");
            Navigation.PushAsync(new Resumen(nombre, pagoInicial, pagoMensual, usuario));
        }
    }
}