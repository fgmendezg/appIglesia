using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace tutoAppXamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            /*TODO: Funcionalidad al dar click en el boton de iniciar sesion
            verificar los datos
            si los datos son correctos llamar al page principal*/
            btnIniciarSesion.Clicked += BtnIniciarSesion_Clicked;
        }

        private void BtnIniciarSesion_Clicked(object sender, EventArgs e)
        {
            ( ( NavigationPage )this.Parent ).PushAsync( new paginas.tp_principal() );
        }

        private void OpenRecuperacionPass(object sender, EventArgs e)
        {
            ((NavigationPage)this.Parent).PushAsync(new paginas.manageSesion.recuperacionPass());
        }
    }
}
