using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace forms_plus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RankingStage1Page : ContentPage
    {
        public RankingStage1Page()
        {
            InitializeComponent();

            PrintListStage1();
        }

        public async void PrintListStage1()
        {
            listx.ItemsSource = await App.Database1.SortScore(false);
        }

        private async void Btn_DeleteHistory(object sender, EventArgs e)
        {
            bool anwser = await DisplayAlert("기록 지우기", "기록을 모두 지우시겠습니까?", "네", "아니오");

            if (anwser == true)
            {
                await App.Database1.DeleteItemAsync();
                listx.ItemsSource = await App.Database1.SortScore(false);
            }
        }        
    }
}