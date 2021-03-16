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
    public partial class SettingPage_Stage : ContentPage
    {
        private bool accessible = true;
        ISimpleAudioPlayer player;
        public SettingPage_Stage()
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
            player.Load("Sounds/Blop.mp3");
            player.Play();
        }
        private async void BtnStep1_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    LearnSetSington.Instance.setUpONOFF = false;
                    LearnSetSington.Instance.setUpDispOnOff = false;
                    LearnSetSington.Instance.setNdigit = 1;
                    LearnSetSington.Instance.setQ_Num = 10;
                    LearnSetSington.Instance.setStage = 1;

                    PlayBtnSound();

                    if (LearnSetSington.Instance.IsTest == true)
                    {
                        await Navigation.PushAsync(new TestPage());
                    }
                    else
                    {
                        await Navigation.PushAsync(new LearnningMultipleChoicePage());
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
        private async void BtnStep2_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    LearnSetSington.Instance.setUpONOFF = true;
                    LearnSetSington.Instance.setUpDispOnOff = false;
                    LearnSetSington.Instance.setNdigit = 1;
                    LearnSetSington.Instance.setQ_Num = 10;
                    LearnSetSington.Instance.setStage = 2;

                    PlayBtnSound();

                    if (LearnSetSington.Instance.IsTest == true)
                    {
                        await Navigation.PushAsync(new TestPage());
                    }
                    else
                    {
                        await Navigation.PushAsync(new LearnningMultipleChoicePage());
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
        private async void BtnStep3_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    LearnSetSington.Instance.setUpONOFF = true;
                    LearnSetSington.Instance.setUpDispOnOff = true;
                    LearnSetSington.Instance.setNdigit = 2;
                    LearnSetSington.Instance.setQ_Num = 10;
                    LearnSetSington.Instance.setStage = 3;

                    PlayBtnSound();

                    if (LearnSetSington.Instance.IsTest == true)
                    {
                        await Navigation.PushAsync(new TestPage());
                    }
                    else
                    {
                        await Navigation.PushAsync(new LearnningPage());
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
        private async void BtnStep4_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    LearnSetSington.Instance.setUpONOFF = true;
                    LearnSetSington.Instance.setUpDispOnOff = true;
                    LearnSetSington.Instance.setNdigit = 3;
                    LearnSetSington.Instance.setQ_Num = 10;
                    LearnSetSington.Instance.setStage = 4;

                    PlayBtnSound();

                    if (LearnSetSington.Instance.IsTest == true)
                    {
                        await Navigation.PushAsync(new TestPage());
                    }
                    else
                    {
                        await Navigation.PushAsync(new LearnningPage());
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
        private async void BtnStep5_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    LearnSetSington.Instance.setUpONOFF = true;
                    LearnSetSington.Instance.setUpDispOnOff = false;
                    LearnSetSington.Instance.setNdigit = 3;
                    LearnSetSington.Instance.setQ_Num = 10;
                    LearnSetSington.Instance.setStage = 5;

                    PlayBtnSound();

                    if (LearnSetSington.Instance.IsTest == true)
                    {
                        await Navigation.PushAsync(new TestPage());
                    }
                    else
                    {
                        await Navigation.PushAsync(new LearnningPage());
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
    }
}