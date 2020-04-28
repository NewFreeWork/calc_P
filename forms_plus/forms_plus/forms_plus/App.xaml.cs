using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace forms_plus
{
    public partial class App : Application
    {
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
