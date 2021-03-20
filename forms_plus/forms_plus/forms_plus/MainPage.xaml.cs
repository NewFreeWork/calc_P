using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using forms_plus.Controls;
using Plugin.SimpleAudioPlayer;
using MarcTron.Plugin;

namespace forms_plus
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private bool accessible = true;
        ISimpleAudioPlayer player;
        private int isDoubleClicked = 0;
        private bool _shouldSetEvents = true;
        public MainPage()
        {
            InitializeComponent();
            //UserInfo.Instance.userName = " ";           

            accessible = true;
            isDoubleClicked = 0;
            //Ctr_Ad.IsVisible = false;

            IntroEffect();
            SetEvents();
            Print_UserName();
            
        }
        private void SetBtnEntryIsVisible(bool set)
        {
            Entry_InsertName.IsVisible = set;
            Btn_Start.IsVisible = set;
            Label_Copyright.IsVisible = set;
        }

        private void SetTextIsVisible(bool set)
        {
            Label_Plus.IsVisible = set;
            Label_PlusEng.IsVisible = set;
            Label_PlusKr.IsVisible = set;
        }

        private async Task IntroEffect()
        {
            SetBtnEntryIsVisible(false);
            SetTextIsVisible(false);
            await Label_PlusKr.FadeTo(0, 0);
            await Label_PlusEng.FadeTo(0, 0);
            await Label_Plus.FadeTo(0, 0);
            SetTextIsVisible(true);
            await Label_PlusKr.FadeTo(1, 1200);
            await Label_PlusEng.FadeTo(1, 700);
            await Label_Plus.FadeTo(1, 600);
            await Label_Plus.FadeTo(1, 600);

            SetBtnEntryIsVisible(true);
        }

        void SetEvents()
        {
            if (_shouldSetEvents)
            {
                _shouldSetEvents = false;
#if false
                CrossMTAdmob.Current.OnRewardedVideoStarted += Current_OnRewardedVideoStarted;
                CrossMTAdmob.Current.OnRewarded += Current_OnRewarded;
                CrossMTAdmob.Current.OnRewardedVideoAdClosed += Current_OnRewardedVideoAdClosed;
                CrossMTAdmob.Current.OnRewardedVideoAdFailedToLoad += Current_OnRewardedVideoAdFailedToLoad;
                CrossMTAdmob.Current.OnRewardedVideoAdLeftApplication += Current_OnRewardedVideoAdLeftApplication;
                CrossMTAdmob.Current.OnRewardedVideoAdLoaded += Current_OnRewardedVideoAdLoaded;
                CrossMTAdmob.Current.OnRewardedVideoAdOpened += Current_OnRewardedVideoAdOpened;
                CrossMTAdmob.Current.OnRewardedVideoAdCompleted += Current_OnRewardedVideoAdCompleted;
#endif
                CrossMTAdmob.Current.OnInterstitialLoaded += Current_OnInterstitialLoaded;
                CrossMTAdmob.Current.OnInterstitialOpened += Current_OnInterstitialOpened;
                CrossMTAdmob.Current.OnInterstitialClosed += Current_OnInterstitialClosed;
            }
        }

        private void Current_OnInterstitialClosed(object sender, EventArgs e)
        {
            //Debug.WriteLine("OnInterstitialClosed");
            System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();
        }

        private void Current_OnInterstitialOpened(object sender, EventArgs e)
        {
            //Debug.WriteLine("OnInterstitialOpened");
        }

        private void Current_OnInterstitialLoaded(object sender, EventArgs e)
        {
            //Debug.WriteLine("OnInterstitialLoaded");
        }


        private void PlayBtnSound()
        {
            player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("Sounds/Start.mp3");
            player.Play();
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
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
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
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                accessible = true;
            }
        }

        protected override bool OnBackButtonPressed()
        {
            try
            {
                if (isDoubleClicked == 0)
                {
                    isDoubleClicked = 1;

                    DependencyService.Get<Toast>().Show("'뒤로가기' 버튼을 한번 더 누르시면 앱이 종료됩니다. 다음에 또 만나요:)");                    
                }
                else if (isDoubleClicked == 1)
                {
                    isDoubleClicked = 2;
                    Label_Copyright.IsVisible = false;
                    Label_PlusEng.IsVisible = false;
                    Label_PlusKr.IsVisible = false;
                    Label_Plus.IsVisible = false;
                    Btn_Start.IsVisible = false;
                    Entry_InsertName.IsVisible = false;
                    //Ctr_Ad.IsVisible = true;
                    CrossMTAdmob.Current.ShowInterstitial();

                    Device.StartTimer(TimeSpan.FromSeconds(5), () =>
                    {
                        // called every 1 second
                        // do stuff here
                        System.Diagnostics.Process.GetCurrentProcess().CloseMainWindow();

                        return false; // return true to repeat counting, false to stop timer
                    });
                }
                else
                {
                    isDoubleClicked = 0;
                    return base.OnBackButtonPressed();
                }

                return true;
            }
            catch (Exception ex)
            {
                isDoubleClicked = 0;
                Console.WriteLine(ex.Message);
                return true;
            }



        }

       

    }
}
