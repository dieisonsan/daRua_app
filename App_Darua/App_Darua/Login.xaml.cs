using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App_Darua
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Login : ContentPage
	{
		public Login ()
		{
			InitializeComponent ();
		}
        void OnButtonClicked(object sender, EventArgs args) {
            var usuario = edtLogin.Text;
            var senha =   edtSenha.Text;

            if (usuario == "dieison" && senha == "nova") {
                Navigation.PushAsync(new Menu());
            }
        } 
	}
}