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
    public partial class RankingStage3Page : ContentPage
    {
        public RankingStage3Page()
        {
            InitializeComponent(); 
            PrintListStage3();
        }

        public async void PrintListStage3()
        {
            listx.ItemsSource = await App.Database3.SortScore(false);
        }

        private async void Btn_DeleteHistory(object sender, EventArgs e)
        {
            bool anwser = await DisplayAlert("기록 지우기", "기록을 모두 지우시겠습니까?", "네", "아니오");

            if (anwser == true)
            {
                await App.Database3.DeleteItemAsync();
                listx.ItemsSource = await App.Database3.SortScore(false);
            }
        }
    }
}