using DallelniApp.Model;
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
	public partial class Profile : ContentPage
	{
        bool x;
        bool Check1, Check2;
        int rout1 = 180;
        int rout2 = 180;
        public Profile ()
		{
			InitializeComponent ();
            UserOffers offer = new UserOffers();
            list.ItemsSource = offer.GetAllOffers();
            x = false;
            Check1 = false;
            Check2 = false;
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            (App.Current.MainPage as MasterDetailPage).IsPresented = !x;
            x = !x;
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            rout1 = (rout1 > 360) ? rout1 - 360 : rout1;
            list.IsVisible = !Check1;
            Check1 = !Check1;
            await ImgMinus1.RotateTo(rout1);
            await ImgMinus1.RotateTo(rout1, 500, Easing.SpringOut);
            rout1 += 180;
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            rout2 = (rout2 > 360) ? rout2 - 360 : rout2;
            Tbl2.IsVisible = !Check2;
            Check2 = !Check2;
            await ImgMinus2.RotateTo(rout1);
            await ImgMinus2.RotateTo(rout1, 500, Easing.SpringOut);
            rout1 += 180;
        }
    }
}