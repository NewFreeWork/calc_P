using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace forms_plus
{
    public class SplashPage : ContentPage
    {
        Image splashImage;

        public SplashPage()
        {
            //SplashPage 상단 네비게이션 바를 안보이도록 설정
            NavigationPage.SetHasNavigationBar(this, false);

            var sub = new AbsoluteLayout();
            string imgFile = "Splash.jpg";
            if (Device.RuntimePlatform == Device.UWP) imgFile = "Assets\\" + imgFile;
            splashImage = new Image
            {
                Source = imgFile,
                WidthRequest = 360, //가로크기
                HeightRequest = 680 //세로크기
            };

            AbsoluteLayout.SetLayoutFlags(splashImage,
                AbsoluteLayoutFlags.PositionProportional);
            AbsoluteLayout.SetLayoutBounds(splashImage,
                new Rectangle(0.5, 0.5, AbsoluteLayout.AutoSize, AbsoluteLayout.AutoSize));

            sub.Children.Add(splashImage);

            //this.BackgroundColor = Color.FromHex("#429de3");
            this.BackgroundColor = Color.White;
            this.Content = sub;
        }

        //사라질때 크기 효과
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            //2초동안 머문다.   
            await splashImage.ScaleTo(1, 300);
            /*
            // 1.5초 동안 0.9배 작아진다.
            await splashImage.ScaleTo(0.9, 1500, Easing.Linear);
            // 1.2초 동안 150배 커진다.
            await splashImage.ScaleTo(150, 2000, Easing.CubicIn);
            */
            await splashImage.FadeTo(1, 700);
            await splashImage.FadeTo(0, 500);
            // MainPage로 이동한다.
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }
    }
}
