using DallelniApp.Model;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;

namespace DallelniApp.ViewModel
{
    public class ItemsViewModel : INotifyPropertyChanged
    {
        public ItemsViewModel()
        {
            IsRunning = true;
            DataGetter(); 
        }

        public bool IsRunning { get; set; }

        private ObservableCollection<Item> _items;
        public ObservableCollection<Item> Items
        {
            get { return _items; }
            set { _items = value; OnPropertyChanged(); }
        }

        private void DataGetter()
        {
            Item ResItem = new Item();
            var list = ResItem.GetAllItems();
            foreach (var item in list)
            {
                var x = int.Parse(item.Discound);
                item.Discound += " %";
                item.FinalPrice = x * item.MainPrice / 100;
            }
            Items = list;
            IsRunning = false;
        }

        public ICommand RefreshCommand
        {
            get
            {
                return new RelayCommand(DataGetter);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
