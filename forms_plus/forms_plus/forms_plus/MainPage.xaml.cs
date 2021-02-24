using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace forms_plus
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //UserInfo.Instance.userName = " ";

            Print_UserName();
        }

        private void Print_UserName()
        {
            String Name = App.LoginInfoDatabase.GetUserNameAsync();

            UserInfo.Instance.userName = " ";

            if (Name == "")
            {
                UserInfo.Instance.userName = " ";
            }
            else 
            {
                UserInfo.Instance.userName = Name;
                Entry_InsertName.Text = Name;
            }
        }

        private void Entry_InputUserName(object sender, TextChangedEventArgs e)
        {
            UserInfo.Instance.userName = e.NewTextValue;

            if (Entry_InsertName.Text == "")
            {
                Entry_InsertName.HorizontalTextAlignment = TextAlignment.Start;
            }
            else 
            {
                Entry_InsertName.HorizontalTextAlignment = TextAlignment.Center;
            }
        }
        
        private async void Btn_Menupage_Go(object sender, EventArgs e)
        {
            if (UserInfo.Instance.userName == " ")
            {
                await DisplayAlert("확인", "이름을 입력해주세요.", "OK");
            }
            else
            {
                App.LoginInfoDatabase.ClearAllUserName();
                App.LoginInfoDatabase.SaveLoginUserName(UserInfo.Instance.userName);
                await Navigation.PushAsync(new MenuPage()); 
            }
        }


    }
}
