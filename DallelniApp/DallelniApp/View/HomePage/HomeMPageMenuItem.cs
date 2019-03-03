using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DallelniApp.View.HomePage
{

    public class HomeMPageMenuItem
    {
        public HomeMPageMenuItem()
        {
            NextPage = typeof(HomeMPageDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        public Type NextPage { get; set; }

        public ObservableCollection<HomeMPageMenuItem> MenuItems()
        {
            ObservableCollection<HomeMPageMenuItem> items = new ObservableCollection<HomeMPageMenuItem>
            {
                new HomeMPageMenuItem
                {
                    Title="الرئيسية" , Url="home.png" , NextPage=typeof(MainPage)
                },
                new HomeMPageMenuItem
                {
                    Title="كيفية الإستخدام" , Url="questions.png"
                },
                new HomeMPageMenuItem
                {
                    Title="عن التطبيق" , Url="attention.png"
                },
                new HomeMPageMenuItem
                {
                    Title="الشروط والأحكام" , Url="file.png"
                },
                new HomeMPageMenuItem
                {
                    Title="الإعدادات" , Url="settings.png"
                },
                new HomeMPageMenuItem
                {
                    Title="تواصل معنا" , Url="phonecall.png"
                },
                new HomeMPageMenuItem
                {
                    Title="مشاركة التطبيق" , Url="share.png"
                },
                new HomeMPageMenuItem
                {
                    Title="تسجيل الخروج" , Url="lo.png"
                }

            };
            return items;
        }
    }
}