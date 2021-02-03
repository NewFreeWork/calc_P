using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using forms_plus.Data;
using System.IO;

namespace forms_plus
{
    public partial class App : Application
    {
        static RankingDatabase RankingInfoDB;
    

        public static RankingDatabase RkInfoDatabase
        {
            get 
            {
                if (RankingInfoDB == null)
                {
                    RankingInfoDB = new RankingDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RangkingInfo.db3"));
                }
                return RankingInfoDB;
            }
        }
        public App()
        {
            InitializeComponent();
#if false       //kindbiny_20200415 네비게이션 페이지로 변경
            MainPage = new MainPage();
#else
            MainPage = new NavigationPage(new MainPage());
#endif
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }

   
}
