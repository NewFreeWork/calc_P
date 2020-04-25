using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace forms_plus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SettingPage_Stage : ContentPage
    {
        private bool pickerSelectUpOnOff = false;
        private bool pickerSelectUpDisp = false;
        private bool pickerSelectNdigit = false;
        private bool pickerSelectQNumf = false;
        public SettingPage_Stage()
        {
            InitializeComponent();
        }

        private async void BtnStep1_Clicked(object sender, EventArgs e)
        {
            LearnSetSington.Instance.setUpONOFF = false;
            LearnSetSington.Instance.setUpDispOnOff = false;
            LearnSetSington.Instance.setNdigit = 1;
            LearnSetSington.Instance.setQ_Num = 10;

            await Navigation.PushAsync(new LearnningMultipleChoicePage());
        }
        private async void BtnStep2_Clicked(object sender, EventArgs e)
        {
            LearnSetSington.Instance.setUpONOFF = true;
            LearnSetSington.Instance.setUpDispOnOff = false;
            LearnSetSington.Instance.setNdigit = 1;
            LearnSetSington.Instance.setQ_Num = 10;

            await Navigation.PushAsync(new LearnningMultipleChoicePage());
        }
        private async void BtnStep3_Clicked(object sender, EventArgs e)
        {
            LearnSetSington.Instance.setUpONOFF = true;
            LearnSetSington.Instance.setUpDispOnOff = true;
            LearnSetSington.Instance.setNdigit = 2;
            LearnSetSington.Instance.setQ_Num = 10;

            await Navigation.PushAsync(new LearnningPage());
        }
        private async void BtnStep4_Clicked(object sender, EventArgs e)
        {
            LearnSetSington.Instance.setUpONOFF = true;
            LearnSetSington.Instance.setUpDispOnOff = true;
            LearnSetSington.Instance.setNdigit = 3;
            LearnSetSington.Instance.setQ_Num = 10;

            await Navigation.PushAsync(new LearnningPage());
        }
        private async void BtnStep5_Clicked(object sender, EventArgs e)
        {
            LearnSetSington.Instance.setUpONOFF = true;
            LearnSetSington.Instance.setUpDispOnOff = false;
            LearnSetSington.Instance.setNdigit = 3;
            LearnSetSington.Instance.setQ_Num = 10;

            await Navigation.PushAsync(new LearnningPage());
        }
    }
}