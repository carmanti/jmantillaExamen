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
    public partial class Resumen : ContentPage
    {
        public Resumen(string nombre, double pagoInicial, double pagoMensual, string usuario)
        {
            InitializeComponent();
            txtNombre.Text = nombre;
            lblUsuario.Text = usuario;

            double total = (pagoMensual*5)+pagoInicial;

            lblTotal.Text = Convert.ToString(total);

        }
    }
}