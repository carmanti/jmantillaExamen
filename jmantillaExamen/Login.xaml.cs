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
    public partial class Login : ContentPage
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnIniciar_Clicked(object sender, EventArgs e)
        {
            string usuario = "estudiante2023";
            string contraseña = "uisrael2023";
            if (usuario == txtUsuario.Text && contraseña == txtContraseña.Text)
            {
                DisplayAlert("Bienvenido", usuario, "Cerrar");
                Navigation.PushAsync(new Registro(usuario));
            }
            else
            {
                DisplayAlert("ALERTA", "Uusuario/Contraseña incorrecto", "Cerrar");
            }

        }
    
    }
}