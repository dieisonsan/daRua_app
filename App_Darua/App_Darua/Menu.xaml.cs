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
	public partial class Menu : ContentPage
	{
		public Menu ()
		{
			InitializeComponent ();
		}

        void OnButtonClicked(object sender, EventArgs args) {
            Navigation.PushAsync(new Login());}
        void  OnButtonOpcao1(object sender, EventArgs args) {
             Navigation.PushAsync(new Paginas.Opcao1());}

        void OnButtonOpcao2(object sender, EventArgs args) {
             Navigation.PushAsync(new Paginas.Opcao2());}

        void OnButtonOpcao3(object sender, EventArgs args) => Navigation.PushAsync(new Paginas.Opcao3());

    }
}