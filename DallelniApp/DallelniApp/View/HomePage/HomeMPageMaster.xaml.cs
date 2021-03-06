﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DallelniApp.View.HomePage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeMPageMaster : ContentPage
    {
        public ListView ListView;

        public HomeMPageMaster()
        {
            InitializeComponent();

            BindingContext = new HomeMPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class HomeMPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<HomeMPageMenuItem> MenuItems { get; set; }

            public HomeMPageMasterViewModel()
            {
                HomeMPageMenuItem mv = new HomeMPageMenuItem();
                MenuItems = mv.MenuItems();
            }
            
            
            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}