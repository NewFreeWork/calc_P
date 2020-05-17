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
    }
}