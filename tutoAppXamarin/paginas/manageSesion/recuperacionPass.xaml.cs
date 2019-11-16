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
    public partial class recuperacionPass : ContentPage
    {
        public recuperacionPass()
        {
            InitializeComponent();
            btnEviar.Clicked += BtnEviar_Clicked;
        }

        private void BtnEviar_Clicked(object sender, EventArgs e)
        {
            //TODO: Llamar al back para que genere token y lo envie al email
            this.Navigation.PushAsync(new paginas.manageSesion.wirteTokenEmail());
        }
    }
}