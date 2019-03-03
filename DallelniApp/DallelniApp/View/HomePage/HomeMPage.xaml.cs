using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DallelniApp.View.HomePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeMPage : MasterDetailPage
    {
        public HomeMPage()
        {
            InitializeComponent();
            MasterPage.ListView.ItemSelected += ListView_ItemSelected;
            Detail = new MainPage();
        }

        private void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as HomeMPageMenuItem;
            if (item == null)
                return;

            var page = (Page)Activator.CreateInstance(item.NextPage);
            //page.Title = item.Title;

            Detail = page;
            IsPresented = false;

            MasterPage.ListView.SelectedItem = null;
        }
    }
}