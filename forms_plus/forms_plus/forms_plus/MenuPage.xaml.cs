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
    public partial class MenuPage : ContentPage
    {
        private bool accessible = true;
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void Learn_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    LearnSetSington.Instance.IsTest = false;
                    await Navigation.PushAsync(new SettingPage());
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
                    await Navigation.PushAsync(new SettingPage_Stage());
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
                    await Navigation.PushAsync(new SettingPage());
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
                    await Navigation.PushAsync(new SettingPage_Stage());
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
                    await Navigation.PushAsync(new TodoPage());
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
                    await Navigation.PushAsync(new RankingPage());
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