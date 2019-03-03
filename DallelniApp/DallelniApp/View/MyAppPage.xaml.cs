using DallelniApp.Model;
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
	public partial class MyAppPage : ContentPage
	{
        bool x;
		public MyAppPage ()
		{
			InitializeComponent ();
            x = false;
		}

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            (App.Current.MainPage as MasterDetailPage).IsPresented = !x;
            x = !x;
        }

        private void List_FlowItemTapped(object sender, ItemTappedEventArgs e)
        {
            var item = e.Item as Item;
            App.Current.MainPage = new SelectedItemPage(item);
        }
    }
}