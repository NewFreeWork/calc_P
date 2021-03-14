using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using forms_plus.Data;
using System.IO;
using forms_plus.Controls;

namespace forms_plus
{
    public partial class App : Application
    {
        static RankingDatabase RankingInfoDB;
        static CalendarLearnDatabase CalendarLearnInfoDB;
        static CalendarTestDatabase CalendarTestInfoDB;
        static LoginDatabase LoginInfoDB;
        public static RankingDatabase RkInfoDatabase
        {
            get 
            {
                if (RankingInfoDB == null)
                {
                    RankingInfoDB = new RankingDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "RangkingInfo1.db3"));
                }
                return RankingInfoDB;
            }
        }
        public static CalendarLearnDatabase CalLearnInfoDatabase
        {
            get
            {
                if (CalendarLearnInfoDB == null)
                {
                    CalendarLearnInfoDB = new CalendarLearnDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CalendarLearnInfo1.db3"));
                }
                return CalendarLearnInfoDB;
            }
        }

        public static CalendarTestDatabase CalTestInfoDatabase
        {
            get
            {
                if (CalendarTestInfoDB == null)
                {
                    CalendarTestInfoDB = new CalendarTestDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "CalendarTestInfo1.db3"));
                }
                return CalendarTestInfoDB;
            }
        }

        public static LoginDatabase LoginInfoDatabase
        {
            get
            {
                if (LoginInfoDB == null)
                {
                    LoginInfoDB = new LoginDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "LoginInfo.db3"));
                }
                return LoginInfoDB;
            }
        }

        public App()
        {
            InitializeComponent();
#if false       //kindbiny_20200415 네비게이션 페이지로 변경
            MainPage = new MainPage();
#else
            //MainPage = new NavigationPage(new MainPage());
            MainPage = new NavigationPage(new SplashPage());
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
