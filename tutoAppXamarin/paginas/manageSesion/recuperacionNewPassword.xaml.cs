using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tutoAppXamarin.paginas.manageSesion
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class recuperacionNewPassword : ContentPage
    {
        public recuperacionNewPassword()
        {
            InitializeComponent();
            btnCambiarContrasena.Clicked += BtnCambiarContrasena_ClickedAsync;
        }

        private async void BtnCambiarContrasena_ClickedAsync(object sender, EventArgs e)
        {
            //TODO: Verificar que los dos passwords conincidas
            // Si coinciden entonces hacer los cambios en el back y notificar al usuario
            await DisplayAlert("Felicidades", "Su contraseña fue cambiada Satisfactoriamente", "OK");
            await this.Navigation.PushAsync(new MainPage());
        }
    }
}