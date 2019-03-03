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
	public partial class Register : ContentPage
	{
		public Register ()
		{
			InitializeComponent ();

            EntryFName.Completed += (Object sender, EventArgs e) =>
            {
                EntryLName.Focus();
            };
            EntryLName.Completed += (Object sender, EventArgs e) =>
            {
                EntryBirth.Focus();
            };
            EntryBirth.Completed += (Object sender, EventArgs e) =>
            {
                PickGender.Focus();
            };
            PickGender.SelectedIndexChanged += (Object sender, EventArgs e) =>
            {
                EntryEmail.Focus();
            };
            EntryEmail.Completed += (Object sender, EventArgs e) =>
            {
                EntryPhone.Focus();
            };
            EntryPhone.Completed += (Object sender, EventArgs e) =>
            {
                EntryPass.Focus();
            };
            EntryPass.Completed += (Object sender, EventArgs e) =>
            {
                PickCountry.Focus();
            };
            PickCountry.SelectedIndexChanged += (Object sender, EventArgs e) =>
            {
                PickCity.Focus();
            };
            PickCountry.SelectedIndexChanged += (Object sender, EventArgs e) =>
            {
                Swit.Focus();
            };
        }

        private void EntryFName_Unfocused(object sender, FocusEventArgs e)
        {
            Lbl1.IsVisible = (EntryFName.Text == "") ? true : false;
        }

        private void EntryLName_Unfocused(object sender, FocusEventArgs e)
        {
            Lbl2.IsVisible = (EntryLName.Text == "") ? true : false;
        }

        private void EntryBirth_Unfocused(object sender, FocusEventArgs e)
        {
            Lbl7.IsVisible = (EntryBirth.Text == "") ? true : false;
        }

        private void PickGender_Unfocused(object sender, FocusEventArgs e)
        {
            Lbl4.IsVisible = (PickGender.SelectedIndex == -1) ? true : false;
        }

        private void EntryEmail_Unfocused(object sender, FocusEventArgs e)
        {
            Lbl5.IsVisible = (EntryEmail.Text == "") ? true : false;
        }

        private void EntryPhone_Unfocused(object sender, FocusEventArgs e)
        {
            Lbl6.IsVisible = (EntryPhone.Text == "") ? true : false;
        }

        private void EntryPass_Unfocused(object sender, FocusEventArgs e)
        {
            Lbl2.IsVisible = (EntryPass.Text == "") ? true : false;
        }

        private void PickCountry_Unfocused(object sender, FocusEventArgs e)
        {
            Lbl8.IsVisible = (PickCountry.SelectedIndex == -1) ? true : false;
        }

        private void PickCity_Unfocused(object sender, FocusEventArgs e)
        {
            Lbl9.IsVisible = (PickCity.SelectedIndex == -1) ? true : false;
        }

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            App.Current.MainPage = new HomeMPage();
        }

        private void TapGestureRecognizer_Tapped_1(object sender, EventArgs e)
        {
            App.Current.MainPage = new WelcomePage();
        }
    }
}