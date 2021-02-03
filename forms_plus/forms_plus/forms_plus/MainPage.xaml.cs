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
        }

        private void Entry_InputUserName(object sender, TextChangedEventArgs e)
        {
            UserInfo.Instance.userName = e.NewTextValue;
        }
        
        private async void Btn_Menupage_Go(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());           
        }


    }
}
