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
    public partial class LearnSettingPage : ContentPage
    {
        public LearnSettingPage()
        {
            InitializeComponent();
        }
      
        private async void StartLearn_Clicked(object sender, EventArgs e)
        {
            bool setUpOnOff = false;

            if (EntryUp.Text == "O")
            {
                setUpOnOff = true;
            }
            
            LearnSetSington.Instance.setNdigit = Int32.Parse(EntryNdigit.Text);          
            LearnSetSington.Instance.setUpOnOff = setUpOnOff;
            LearnSetSington.Instance.setQ_Num = Int32.Parse(EntryQNum.Text);

            await Navigation.PushAsync(new LearnningPage());
        }
    }
}