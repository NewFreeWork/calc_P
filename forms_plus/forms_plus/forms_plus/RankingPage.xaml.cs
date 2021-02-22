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
    public partial class RankingPage : TabbedPage
    {
        public RankingPage()
        {
            InitializeComponent();

            Children.Add(new RankingStage1Page());
            Children.Add(new RankingStage2Page());
            Children.Add(new RankingStage3Page());
            Children.Add(new RankingStage4Page());
            Children.Add(new RankingStage5Page());
        }
    }
}