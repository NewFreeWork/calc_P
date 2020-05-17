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
    public partial class RankingStage2Page : ContentPage
    {
        public RankingStage2Page()
        {
            InitializeComponent();
            PrintListStage2();
        }

        public async void PrintListStage2()
        {
            listx.ItemsSource = await App.Database2.SortScore(false);
        }
    }
}