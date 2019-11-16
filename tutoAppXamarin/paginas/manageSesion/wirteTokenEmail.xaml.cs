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
    public partial class wirteTokenEmail : ContentPage
    {
        public wirteTokenEmail()
        {
            InitializeComponent();
            btnAceptar.Clicked += BtnAceptar_Clicked;
        }

        private void BtnAceptar_Clicked(object sender, EventArgs e)
        {
            //TODO: Verificar que el token sea correcto
            this.Navigation.PushAsync(new paginas.manageSesion.recuperacionNewPassword());
        }
    }
}