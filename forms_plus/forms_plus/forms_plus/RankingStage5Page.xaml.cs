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
    public partial class RankingStage5Page : ContentPage
    {
        public RankingStage5Page()
        {
            InitializeComponent();
            PrintListStage5();
        }

        public async void PrintListStage5()
        {
            listx.ItemsSource = await App.Database5.SortScore(false);
        }
    }
}