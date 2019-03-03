using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DallelniApp.View.User
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CompanyRegistration : ContentPage
	{
		public CompanyRegistration ()
		{
			InitializeComponent ();
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new WelcomePage();
        }
    }
}