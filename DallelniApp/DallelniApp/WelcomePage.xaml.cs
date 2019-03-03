using DallelniApp.View;
using DallelniApp.View.HomePage;
using DallelniApp.View.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DallelniApp
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class WelcomePage : ContentPage
	{
		public WelcomePage ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            FlowDirection = FlowDirection.RightToLeft;
        }

        private void Button_Clicked_1(object sender, EventArgs e)
        {
            FlowDirection = FlowDirection.LeftToRight ;
        }

        private void Button_Clicked_2(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new Register()));
        }

        private void Button_Clicked_3(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new NavigationPage(new Login()));
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new HomeMPage();
        }

        private void Button_Clicked_4(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new CompanyRegistration());
        }
    }
}