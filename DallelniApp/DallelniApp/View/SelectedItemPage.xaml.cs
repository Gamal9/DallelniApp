using DallelniApp.Model;
using DallelniApp.View.HomePage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DallelniApp.View
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SelectedItemPage : ContentPage
	{
		public SelectedItemPage (Item item)
		{
			InitializeComponent ();
            this.BindingContext = item;
		}

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            App.Current.MainPage = new HomeMPage();
        }
    }
}