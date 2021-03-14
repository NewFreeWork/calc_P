using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using forms_plus.Controls;
using Plugin.SimpleAudioPlayer;

namespace forms_plus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]

  
    public partial class SettingPage : ContentPage
    {
        private bool pickerSelectUPOnOff = false;
        private bool pickerSelectUPDisp = false;
        private bool pickerSelectNdigit = false;
        private bool pickerSelectQNum = false;

        private bool accessible = true;
        ISimpleAudioPlayer player;

        public SettingPage()
        {
            InitializeComponent();
            InitSound();
        }
        private void InitSound()
        {
            // player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            // player.Load("Sounds/Start.wav");
        }
        private void PlayBtnSound()
        {
            player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("Sounds/Start.wav");
            player.Play();
        }

        private void SetStage()
        {
            try
            {
                switch (LearnSetSington.Instance.setNdigit)
                {
                    case 1:
                        if (LearnSetSington.Instance.setUpONOFF == false)
                        {
                            LearnSetSington.Instance.setStage = 1;
                        }
                        else 
                        {
                            LearnSetSington.Instance.setStage = 2;
                        }
                        break;
                    case 2:                    
                            LearnSetSington.Instance.setStage = 3;
                        break;
                    case 3:
                        if (LearnSetSington.Instance.setUpONOFF == true)
                        {
                            LearnSetSington.Instance.setStage = 4;
                        }
                        else 
                        {
                            LearnSetSington.Instance.setStage = 5;
                        }
                        break;
                    default:                    
                            LearnSetSington.Instance.setStage = 0;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private async void Start_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;

                    if ((pickerSelectUPOnOff == false)
                        || (pickerSelectUPDisp == false)
                        || (pickerSelectNdigit == false)
                        || (pickerSelectQNum == false))
                    {
                        await DisplayAlert("알림", "설정을 선택해 주세요.", "확인");
                    }
                    else
                    {
                        SetStage();

                        PlayBtnSound();

                        if (LearnSetSington.Instance.IsTest == true)
                        {
                            await Navigation.PushAsync(new TestPage());
                        }
                        else
                        {
                            await Navigation.PushAsync(new LearnningPage());
                        }
                    }
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                accessible = true;
            }
        }

        private void OnPickerSelectedIndexChanged_UP_Display(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            string selectedUP;

            if (selectedIndex != -1)
            {
                selectedUP = Convert.ToString(picker.Items[selectedIndex]);
                if (selectedUP == "ON")
                {
                    LearnSetSington.Instance.setUpDispOnOff = true;
                }
                else 
                {
                    LearnSetSington.Instance.setUpDispOnOff = false;
                }

                pickerSelectUPDisp = true;


            }
        }

        private void OnPickerSelectedIndexChanged_UP_OnOff(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            string selectedUpOnOff;

            if (selectedIndex != -1)
            {
                selectedUpOnOff = Convert.ToString(picker.Items[selectedIndex]);
                if (selectedUpOnOff == "ON")
                {
                    LearnSetSington.Instance.setUpONOFF = true;
                }
                else
                {
                    LearnSetSington.Instance.setUpONOFF = false;
                }

                pickerSelectUPOnOff = true;
            }
        }

        private void OnPickerSelectedIndexChanged_Ndigit(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            string selectedNdigit;

            if (selectedIndex != -1)
            {
                selectedNdigit = Convert.ToString(picker.Items[selectedIndex]);
                LearnSetSington.Instance.setNdigit = Int32.Parse(selectedNdigit);

                pickerSelectNdigit = true;
            }
        }

        private void OnPickerSelectedIndexChanged_QNum(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            string selectedQNum;

            if (selectedIndex != -1)
            {
                selectedQNum = Convert.ToString(picker.Items[selectedIndex]);
                LearnSetSington.Instance.setQ_Num = Int32.Parse(selectedQNum);

                pickerSelectQNum = true;
            }
        }
    }

   
}