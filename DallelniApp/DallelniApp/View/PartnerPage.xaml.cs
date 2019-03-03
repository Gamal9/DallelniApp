using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamanimation;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DallelniApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PartnerPage : ContentPage
	{
        bool x;
        bool Check1,Check2,Check3,Check4;
        int rout1 = 180;
        int rout2 = 180;
        int rout3 = 180;
        int rout4 = 180;
        List<string> Partners;
		public PartnerPage ()
		{
			InitializeComponent ();
            Partners = new List<string>
            {
                "partner1.png","partner2.png","partner3.png","partner4.png","partner1.png","partner2.png","partner3.png","partner4.png","partner1.png","partner2.png","partner3.png","partner4.png"
            };
            
            list1.FlowItemsSource = Partners;
            list2.FlowItemsSource = Partners;
            list3.FlowItemsSource = Partners;
            list4.FlowItemsSource = Partners;
            x = false;
            Check1 = false;
            Check2 = false;
            Check3 = false;
            Check4 = false;

        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            (App.Current.MainPage as MasterDetailPage).IsPresented = !x;
            x = !x;
        }

        private async void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            rout1 = (rout1 > 360) ? rout1 - 360 : rout1;
            list1.IsVisible = !Check1;
            Check1 = !Check1;
            await ImgMinus1.RotateTo(rout1);
            await ImgMinus1.RotateTo(rout1, 500, Easing.SpringOut);
            rout1 += 180;
        }

        private async void TapGestureRecognizer_Tapped_2(object sender, EventArgs e)
        {
            rout2 = (rout2 > 360) ? rout2 - 360 : rout2;
            list2.IsVisible = !Check2;
            Check2 = !Check2;
            await ImgMinus2.RotateTo(rout2);
            await ImgMinus2.RotateTo(rout2, 500, Easing.SpringOut);
            rout2 += 180;
        }

        private async void TapGestureRecognizer_Tapped_3(object sender, EventArgs e)
        {
            rout3 = (rout3 > 360) ? rout3 - 360 : rout3;
            list3.IsVisible = !Check3;
            Check3 = !Check3;
            await ImgMinus3.RotateTo(rout3);
            await ImgMinus3.RotateTo(rout3, 500, Easing.SpringOut);
            rout3 += 180;
        }

        private async void TapGestureRecognizer_Tapped_4(object sender, EventArgs e)
        {
            rout4 = (rout4 > 360) ? rout4 - 360 : rout4;
            list4.IsVisible = !Check4;
            Check4 = !Check4;
            await ImgMinus4.RotateTo(rout4);
            await ImgMinus4.RotateTo(rout4, 500, Easing.SpringOut);
            rout4 += 180;
        }
    }
}