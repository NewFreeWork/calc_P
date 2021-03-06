﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace forms_plus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RankingStage2Page : ContentPage
    {
        private bool accessible = true;
        public RankingStage2Page()
        {
            InitializeComponent();
            PrintListStage2();
        }

        public async void PrintListStage2()
        {
            listx.ItemsSource = await App.RkInfoDatabase.GetRankingsAsync("2");
            //listx.ItemsSource = await App.RkInfoDatabase.SortScore(false);
        }
        private void PlayBtnSound()
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("Sounds/Blop.mp3");
            player.Play();
        }

        private async void Btn_DeleteHistory(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
                    bool anwser = await DisplayAlert("기록 지우기", "기록을 모두 지우시겠습니까?", "네", "아니오");

                    if (anwser == true)
                    {
                        await App.RkInfoDatabase.DeleteStageAsync("2");
                        listx.ItemsSource = await App.RkInfoDatabase.GetRankingsAsync("2");
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