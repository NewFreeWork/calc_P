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
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void Learn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingPage());
        }

        private async void LearnStage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SettingPage_Stage());
        }
    }
    
}