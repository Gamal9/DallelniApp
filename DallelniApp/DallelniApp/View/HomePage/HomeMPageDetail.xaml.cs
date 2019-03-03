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
    public partial class HomeMPageDetail : ContentPage
    {
        bool x;
        public HomeMPageDetail()
        {
            InitializeComponent();
            x = false;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            (App.Current.MainPage as MasterDetailPage).IsPresented = !x;
            x = !x;
        }
    }
}