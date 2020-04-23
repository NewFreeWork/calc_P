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

  
    public partial class SettingPage : ContentPage
    {
        private bool pickerSelectUPOnOff = false;
        private bool pickerSelectUPDisp = false;
        private bool pickerSelectNdigit = false;
        private bool pickerSelectQNum = false;

        public SettingPage()
        {
            InitializeComponent();
        }

        private async void StartLearn_Clicked(object sender, EventArgs e)
        {
            if ((pickerSelectUPOnOff == false)
                || (pickerSelectUPDisp == false)
                || (pickerSelectNdigit == false)
                || (pickerSelectQNum == false))
            {
                await DisplayAlert("알림","설정을 선택해 주세요.","확인");
            }
            else
            {
                pickerSelectUPOnOff = false;
                pickerSelectUPDisp = false;
                pickerSelectNdigit = false;
                pickerSelectQNum = false;

                await Navigation.PushAsync(new LearnningPage());
            }
        }

        private void OnPickerSelectedIndexChanged_UP_Display(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            string selectedUP;

            if (selectedIndex != -1)
            {
                selectedUP = Convert.ToString(picker.Items[selectedIndex]);
                if (selectedUP == "ON")
                {
                    LearnSetSington.Instance.setUpDispOnOff = true;
                }
                else 
                {
                    LearnSetSington.Instance.setUpDispOnOff = false;
                }

                pickerSelectUPDisp = true;


            }
        }

        private void OnPickerSelectedIndexChanged_UP_OnOff(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            string selectedUpOnOff;

            if (selectedIndex != -1)
            {
                selectedUpOnOff = Convert.ToString(picker.Items[selectedIndex]);
                if (selectedUpOnOff == "ON")
                {
                    LearnSetSington.Instance.setUpONOFF = true;
                }
                else
                {
                    LearnSetSington.Instance.setUpONOFF = false;
                }

                pickerSelectUPOnOff = true;
            }
        }

        private void OnPickerSelectedIndexChanged_Ndigit(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            string selectedNdigit;

            if (selectedIndex != -1)
            {
                selectedNdigit = Convert.ToString(picker.Items[selectedIndex]);
                LearnSetSington.Instance.setNdigit = Int32.Parse(selectedNdigit);

                pickerSelectNdigit = true;
            }
        }

        private void OnPickerSelectedIndexChanged_QNum(object sender, EventArgs e)
        {
            var picker = (Picker)sender;
            int selectedIndex = picker.SelectedIndex;
            string selectedQNum;

            if (selectedIndex != -1)
            {
                selectedQNum = Convert.ToString(picker.Items[selectedIndex]);
                LearnSetSington.Instance.setQ_Num = Int32.Parse(selectedQNum);

                pickerSelectQNum = true;
            }
        }
    }

    public class LearnSetSington
    {

        private static LearnSetSington instance = null;
        public static LearnSetSington Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LearnSetSington();
                }
                return instance;
            }
        }

        private LearnSetSington()
        {
        }

        public int setNdigit; // 선언할 변수들 
        public bool setUpONOFF; // 선언할 변수들 
        public bool setUpDispOnOff; // 선언할 변수들 
        public int setQ_Num; // 선언할 변수들 
    }
}