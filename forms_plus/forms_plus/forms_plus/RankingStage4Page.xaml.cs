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
    public partial class RankingStage4Page : ContentPage
    {
        public RankingStage4Page()
        {
            InitializeComponent(); 
            PrintListStage4();
        }

        public async void PrintListStage4()
        {
            listx.ItemsSource = await App.Database4.SortScore(false);
        }
    }
}