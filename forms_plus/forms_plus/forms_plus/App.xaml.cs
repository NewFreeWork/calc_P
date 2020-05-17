using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using forms_plus.Data;
using System.IO;

namespace forms_plus
{
    public partial class App : Application
    {
        static RankingDatabase databaseStage1;
        static RankingDatabase databaseStage2;
        static RankingDatabase databaseStage3;
        static RankingDatabase databaseStage4;
        static RankingDatabase databaseStage5;

        public static RankingDatabase Database1
        {
            get 
            {
                if (databaseStage1 == null)
                {
                    databaseStage1 = new RankingDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DB_RankingStage1.db3"));
                }
                return databaseStage1;
            }
        }

        public static RankingDatabase Database2
        {
            get
            {
                if (databaseStage2 == null)
                {
                    databaseStage2 = new RankingDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DB_RankingStage2.db3"));
                }
                return databaseStage2;
            }
        }

        public static RankingDatabase Database3
        {
            get
            {
                if (databaseStage3 == null)
                {
                    databaseStage3 = new RankingDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DB_RankingStage3.db3"));
                }
                return databaseStage3;
            }
        }

        public static RankingDatabase Database4
        {
            get
            {
                if (databaseStage4 == null)
                {
                    databaseStage4 = new RankingDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DB_RankingStage4.db3"));
                }
                return databaseStage4;
            }
        }

        public static RankingDatabase Database5
        {
            get
            {
                if (databaseStage5 == null)
                {
                    databaseStage5 = new RankingDatabase(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "DB_RankingStage5.db3"));
                }
                return databaseStage5;
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
