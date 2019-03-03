using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace DallelniApp.Model
{
    public class Item
    {
        public int id { get; set; }
        public string RestairantImg { get; set; }
        public string RestairantTitle { get; set; }
        public string Discound { get; set; }
        public string MainImage { get; set; }
        public string ItemTxt { get; set; }
        public string Desecription { get; set; }
        public int MainPrice { get; set; }
        public int FinalPrice { get; set; }
        public ObservableCollection<string> Imgs { get; set; }

        public ObservableCollection<Item> GetAllItems()
        {
            return new ObservableCollection<Item>{
                new Item
                {
                    RestairantImg="Res1.jpg",
                    RestairantTitle="مطعم جولد تشكن",
                    Discound=50.ToString(),
                    MainImage="item.png",
                    ItemTxt="وجبة شهية لشخص واحد",
                    Desecription="أستمتع بوجبة شهية من ساندوتش البرجر ورقائق البطاطس المقرمشة وحلقات البصل",
                    MainPrice=60,
                    Imgs= new ObservableCollection<string>
                    {
                        "item.png","item2.png","item.png","item2.png"
                    }
                },
                new Item
                {
                    RestairantImg="Res2.jpg",
                    RestairantTitle="مطعم جولد تشكن",
                    Discound=25.ToString(),
                    MainImage="item2.png",
                    ItemTxt="وجبة شهية لشخص واحد",
                    Desecription="أستمتع بوجبة شهية من ساندوتش البرجر ورقائق البطاطس المقرمشة وحلقات البصل",
                    MainPrice=80

                },
                new Item
                {
                    RestairantImg="Res3.jpg",
                    RestairantTitle="مطعم جولد تشكن",
                    Discound=60.ToString(),
                    MainImage="item.png",
                    ItemTxt="وجبة شهية لشخص واحد",
                    Desecription="أستمتع بوجبة شهية من ساندوتش البرجر ورقائق البطاطس المقرمشة وحلقات البصل",
                    MainPrice=150

                }
            };
        }
    }


}
