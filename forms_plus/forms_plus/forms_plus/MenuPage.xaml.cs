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
    public partial class MenuPage : ContentPage
    {
        private bool accessible = true;
        ISimpleAudioPlayer player;
        public MenuPage()
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
        private async void Learn_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    LearnSetSington.Instance.IsTest = false;
                    PlayBtnSound();
                    await Navigation.PushAsync(new SettingPage(), false);
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                accessible = true;
            }
        }

        private async void LearnStage_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    LearnSetSington.Instance.IsTest = false;
                    PlayBtnSound();
                    await Navigation.PushAsync(new SettingPage_Stage(), false);
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                accessible = true;
            }
        }

        private async void Test_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    LearnSetSington.Instance.IsTest = true;
                    PlayBtnSound();
                    await Navigation.PushAsync(new SettingPage(), false);
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                accessible = true;
            }
        }

        private async void TestStage_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    LearnSetSington.Instance.IsTest = true;
                    PlayBtnSound();
                    await Navigation.PushAsync(new SettingPage_Stage(), false);
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                accessible = true;
            }
        }

        /*kindbiny_20200502 Todo Clicked 추가*/
        private async void ToDo_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
                    await Navigation.PushAsync(new TodoPage(), false);
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                accessible = true;
            }
        }

        private async void Ranking_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
                    await Navigation.PushAsync(new RankingPage(), false);
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                accessible = true;
            }
        }
    }
    
}