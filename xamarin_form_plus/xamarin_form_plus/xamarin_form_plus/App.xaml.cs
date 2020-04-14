using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace xamarin_form_plus
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

#if false       //kindbiny_20200412
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
