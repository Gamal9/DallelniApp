using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DallelniApp.Model
{
    public class UserOffers
    {
        public string Offer { get; set; }
        public string Restaurant { get; set; }
        public int Count { get; set; }
        public int CountBack { get; set; }

        public ObservableCollection<UserOffers> GetAllOffers()
        {
            return new ObservableCollection<UserOffers>
            {
                new UserOffers
                {
                    Offer="وجبة لشخص واحد",Restaurant="مطعم جولدن تشكن",Count=10,CountBack=0
                },
                new UserOffers
                {
                    Offer="وجبة لشخص واحد",Restaurant="مطعم جولدن تشكن",Count=10,CountBack=0
                },
                new UserOffers
                {
                    Offer="وجبة لشخص واحد",Restaurant="مطعم جولدن تشكن",Count=10,CountBack=0
                },
                new UserOffers
                {
                    Offer="وجبة لشخص واحد",Restaurant="مطعم جولدن تشكن",Count=10,CountBack=0
                },
            };
        }
    }
}
