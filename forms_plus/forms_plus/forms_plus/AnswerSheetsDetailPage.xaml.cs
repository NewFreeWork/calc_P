using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using forms_plus.ViewModel;

namespace forms_plus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnswerSheetsDetailPage : ContentPage
    {
        private bool accessible = true;
        public AnswerSheetsDetailPage()
        {
            InitializeComponent();

            this.BindingContext = new FontSizeViewModel();


            DrawLayout();
            PrintDetailData();
        }

        private void DrawLayout()
        {
            switch (LearnSetSington.Instance.setNdigit)
            {
                case 1:
                    Label_FirstNum100s.IsVisible = false;
                    Label_FirstNum10s.IsVisible = false;
                    Label_SecNum100s.IsVisible = false;
                    Label_SecNum10s.IsVisible = false;
                    Label_Up100s.IsVisible = false;
                    Label_Up10s.IsVisible = false;
                    Label_RightUp100s.IsVisible = false;
                    Label_RightUp10s.IsVisible = false;
                    Label_1000s.IsVisible = false;
                    Label_100s.IsVisible = false;
                    break;
                case 2:
                    Label_FirstNum100s.IsVisible = false;
                    Label_SecNum100s.IsVisible = false;

                    if (LearnSetSington.Instance.setUpDispOnOff == false)
                    {
                        Label_Up100s.IsVisible = false;
                        Label_Up10s.IsVisible = false;
                        Label_RightUp100s.IsVisible = false;
                        Label_RightUp10s.IsVisible = false;
                    }
                    else
                    {
                        Label_Up100s.IsVisible = false;
                        Label_RightUp100s.IsVisible = false;                        
                    }

                    Label_1000s.IsVisible = false;
                    break;

                case 3:
                    if (LearnSetSington.Instance.setUpDispOnOff == false)
                    {
                        Label_Up100s.IsVisible = false;
                        Label_Up10s.IsVisible = false;
                        Label_RightUp100s.IsVisible = false;
                        Label_RightUp10s.IsVisible = false;
                    }
                    break;
                default:
                    break;
            }
        }
        private void PrintDetailData()
        {
            string QuestionFirstLineString;
            string QuestionSecLineString;
            string RightAnswerString;
            string RightUpString;
            string MyAnswerString;
            string MyUpString;

            char[] qFirstbuf = new char[3] { '0', '0', '0' };
            char[] qSecbuf = new char[3] { '0','0', '0' };
            char[] qRightAnswerBuf = new char[4] { '0', '0', '0', '0' };
            char[] myAnswerBuf = new char[4] { '0', '0', '0', '0' };
            char[] qRightUpBuf = new char[2] { '0', '0' };
            char[] myAnswerUpBuf = new char[2] { '0', '0' };

            int charBufIdx = 0;
            int strBufIdx = 0;
            int right_sum = 0;



            Label_1000s.IsVisible = true;
            Label_100s.IsVisible = true;
            Label_10s.IsVisible = true;
            Label_1s.IsVisible = true;
            Label_Right1000s.IsVisible = true;
            Label_Right100s.IsVisible = true;
            Label_Right10s.IsVisible = true;
            Label_Right1s.IsVisible = true;

            switch (AnswerSheetsData.Instance.DetailPageIndex)
            {
                case 1:
                    QuestionFirstLineString = Convert.ToString(AnswerSheetsData.Instance.Q_first1);
                    QuestionSecLineString = Convert.ToString(AnswerSheetsData.Instance.Q_sec1);
                    RightAnswerString = Convert.ToString(AnswerSheetsData.Instance.Q_RightAnswer1);
                    MyAnswerString = Convert.ToString(AnswerSheetsData.Instance.MyAnswer1);
                    if (LearnSetSington.Instance.setUpDispOnOff == true)
                    {
                        RightUpString = Convert.ToString(AnswerSheetsData.Instance.Q_RightUp1);
                        MyUpString = Convert.ToString(AnswerSheetsData.Instance.MyUpAnswer1);
                    }
                    else 
                    {
                        RightUpString = "0";
                        MyUpString = "0";
                    }
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer1;
                    break;
                case 2:
                    QuestionFirstLineString = Convert.ToString(AnswerSheetsData.Instance.Q_first2);
                    QuestionSecLineString = Convert.ToString(AnswerSheetsData.Instance.Q_sec2);
                    RightAnswerString = Convert.ToString(AnswerSheetsData.Instance.Q_RightAnswer2);
                    MyAnswerString = Convert.ToString(AnswerSheetsData.Instance.MyAnswer2);
                    if (LearnSetSington.Instance.setUpDispOnOff == true)
                    {
                        RightUpString = Convert.ToString(AnswerSheetsData.Instance.Q_RightUp2);
                        MyUpString = Convert.ToString(AnswerSheetsData.Instance.MyUpAnswer2);
                    }
                    else
                    {
                        RightUpString = "0";
                        MyUpString = "0";
                    }
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer2;
                    break;
                case 3:
                    QuestionFirstLineString = Convert.ToString(AnswerSheetsData.Instance.Q_first3);
                    QuestionSecLineString = Convert.ToString(AnswerSheetsData.Instance.Q_sec3);
                    RightAnswerString = Convert.ToString(AnswerSheetsData.Instance.Q_RightAnswer3);
                    MyAnswerString = Convert.ToString(AnswerSheetsData.Instance.MyAnswer3);
                    if (LearnSetSington.Instance.setUpDispOnOff == true)
                    {
                        RightUpString = Convert.ToString(AnswerSheetsData.Instance.Q_RightUp3);
                        MyUpString = Convert.ToString(AnswerSheetsData.Instance.MyUpAnswer3);
                    }
                    else
                    {
                        RightUpString = "0";
                        MyUpString = "0";
                    }
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer3;
                    break;
                case 4:
                    QuestionFirstLineString = Convert.ToString(AnswerSheetsData.Instance.Q_first4);
                    QuestionSecLineString = Convert.ToString(AnswerSheetsData.Instance.Q_sec4);
                    RightAnswerString = Convert.ToString(AnswerSheetsData.Instance.Q_RightAnswer4);
                    MyAnswerString = Convert.ToString(AnswerSheetsData.Instance.MyAnswer4);
                    if (LearnSetSington.Instance.setUpDispOnOff == true)
                    {
                        RightUpString = Convert.ToString(AnswerSheetsData.Instance.Q_RightUp4);
                        MyUpString = Convert.ToString(AnswerSheetsData.Instance.MyUpAnswer4);
                    }
                    else
                    {
                        RightUpString = "0";
                        MyUpString = "0";
                    }
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer4;
                    break;
                case 5:
                    QuestionFirstLineString = Convert.ToString(AnswerSheetsData.Instance.Q_first5);
                    QuestionSecLineString = Convert.ToString(AnswerSheetsData.Instance.Q_sec5);
                    RightAnswerString = Convert.ToString(AnswerSheetsData.Instance.Q_RightAnswer5);
                    MyAnswerString = Convert.ToString(AnswerSheetsData.Instance.MyAnswer5);
                    if (LearnSetSington.Instance.setUpDispOnOff == true)
                    {
                        RightUpString = Convert.ToString(AnswerSheetsData.Instance.Q_RightUp5);
                        MyUpString = Convert.ToString(AnswerSheetsData.Instance.MyUpAnswer5);
                    }
                    else
                    {
                        RightUpString = "0";
                        MyUpString = "0";
                    }
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer5;
                    break;
                case 6:
                    QuestionFirstLineString = Convert.ToString(AnswerSheetsData.Instance.Q_first6);
                    QuestionSecLineString = Convert.ToString(AnswerSheetsData.Instance.Q_sec6);
                    RightAnswerString = Convert.ToString(AnswerSheetsData.Instance.Q_RightAnswer6);
                    MyAnswerString = Convert.ToString(AnswerSheetsData.Instance.MyAnswer6);
                    if (LearnSetSington.Instance.setUpDispOnOff == true)
                    {
                        RightUpString = Convert.ToString(AnswerSheetsData.Instance.Q_RightUp6);
                        MyUpString = Convert.ToString(AnswerSheetsData.Instance.MyUpAnswer6);
                    }
                    else
                    {
                        RightUpString = "0";
                        MyUpString = "0";
                    }
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer6;
                    break;
                case 7:
                    QuestionFirstLineString = Convert.ToString(AnswerSheetsData.Instance.Q_first7);
                    QuestionSecLineString = Convert.ToString(AnswerSheetsData.Instance.Q_sec7);
                    RightAnswerString = Convert.ToString(AnswerSheetsData.Instance.Q_RightAnswer7);
                    MyAnswerString = Convert.ToString(AnswerSheetsData.Instance.MyAnswer7);
                    if (LearnSetSington.Instance.setUpDispOnOff == true)
                    {
                        RightUpString = Convert.ToString(AnswerSheetsData.Instance.Q_RightUp7);
                        MyUpString = Convert.ToString(AnswerSheetsData.Instance.MyUpAnswer7);
                    }
                    else
                    {
                        RightUpString = "0";
                        MyUpString = "0";
                    }
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer7;
                    break;
                case 8:
                    QuestionFirstLineString = Convert.ToString(AnswerSheetsData.Instance.Q_first8);
                    QuestionSecLineString = Convert.ToString(AnswerSheetsData.Instance.Q_sec8);
                    RightAnswerString = Convert.ToString(AnswerSheetsData.Instance.Q_RightAnswer8);
                    MyAnswerString = Convert.ToString(AnswerSheetsData.Instance.MyAnswer8);
                    if (LearnSetSington.Instance.setUpDispOnOff == true)
                    {
                        RightUpString = Convert.ToString(AnswerSheetsData.Instance.Q_RightUp8);
                        MyUpString = Convert.ToString(AnswerSheetsData.Instance.MyUpAnswer8);
                    }
                    else
                    {
                        RightUpString = "0";
                        MyUpString = "0";
                    }
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer8;
                    break;
                case 9:
                    QuestionFirstLineString = Convert.ToString(AnswerSheetsData.Instance.Q_first9);
                    QuestionSecLineString = Convert.ToString(AnswerSheetsData.Instance.Q_sec9);
                    RightAnswerString = Convert.ToString(AnswerSheetsData.Instance.Q_RightAnswer9);
                    MyAnswerString = Convert.ToString(AnswerSheetsData.Instance.MyAnswer9);
                    if (LearnSetSington.Instance.setUpDispOnOff == true)
                    {
                        RightUpString = Convert.ToString(AnswerSheetsData.Instance.Q_RightUp9);
                        MyUpString = Convert.ToString(AnswerSheetsData.Instance.MyUpAnswer9);
                    }
                    else
                    {
                        RightUpString = "0";
                        MyUpString = "0";
                    }
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer9;
                    break;
                case 10:
                default:
                    QuestionFirstLineString = Convert.ToString(AnswerSheetsData.Instance.Q_first10);
                    QuestionSecLineString = Convert.ToString(AnswerSheetsData.Instance.Q_sec10);
                    RightAnswerString = Convert.ToString(AnswerSheetsData.Instance.Q_RightAnswer10);
                    MyAnswerString = Convert.ToString(AnswerSheetsData.Instance.MyAnswer10);
                    if (LearnSetSington.Instance.setUpDispOnOff == true)
                    {
                        RightUpString = Convert.ToString(AnswerSheetsData.Instance.Q_RightUp10);
                        MyUpString = Convert.ToString(AnswerSheetsData.Instance.MyUpAnswer10);
                    }
                    else
                    {
                        RightUpString = "0";
                        MyUpString = "0";
                    }
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer10;
                    break;
            }

            charBufIdx = 0;
            for (strBufIdx = QuestionFirstLineString.Length - 1; strBufIdx >= 0; strBufIdx--, charBufIdx++)
            {
                qFirstbuf[charBufIdx] = QuestionFirstLineString[strBufIdx];
                qSecbuf[charBufIdx] = QuestionSecLineString[strBufIdx];
            }

            charBufIdx = 0;
            for (strBufIdx = RightAnswerString.Length - 1; strBufIdx >= 0; strBufIdx--, charBufIdx++)
            {
                qRightAnswerBuf[charBufIdx] = RightAnswerString[strBufIdx];              
            }

            charBufIdx = 0;
            for (strBufIdx = MyAnswerString.Length - 1; strBufIdx >= 0; strBufIdx--, charBufIdx++)
            {
                if (MyAnswerString == "0")
                {
                    myAnswerBuf[charBufIdx] = '0';
                }
                else
                {
                    myAnswerBuf[charBufIdx] = MyAnswerString[strBufIdx];
                }
            }          

            if (LearnSetSington.Instance.setUpDispOnOff == true)
            {
                charBufIdx = 0;
                for (strBufIdx = RightUpString.Length - 1; strBufIdx >= 0; strBufIdx--, charBufIdx++)
                {
                    qRightUpBuf[charBufIdx] = RightUpString[strBufIdx];
                }
                    
                charBufIdx = 0;
                for (strBufIdx = MyUpString.Length - 1; strBufIdx >= 0; strBufIdx--, charBufIdx++)
                {
                    myAnswerUpBuf[charBufIdx] = MyUpString[strBufIdx];
                }
            }

            Label_FirstNum1s.Text = qFirstbuf[0].ToString();
            Label_FirstNum10s.Text = qFirstbuf[1].ToString();
            Label_FirstNum100s.Text = qFirstbuf[2].ToString();

            Label_SecNum1s.Text = qSecbuf[0].ToString();
            Label_SecNum10s.Text = qSecbuf[1].ToString();
            Label_SecNum100s.Text =qSecbuf[2].ToString();


            Label_Right1s.Text =qRightAnswerBuf[0].ToString();
            Label_Right10s.Text =qRightAnswerBuf[1].ToString();
            Label_Right100s.Text =qRightAnswerBuf[2].ToString();
            Label_Right1000s.Text =qRightAnswerBuf[3].ToString();

            if (LearnSetSington.Instance.setUpDispOnOff == true)
            {
                Label_RightUp10s.Text = qRightUpBuf[0].ToString();
                Label_RightUp100s.Text = qRightUpBuf[1].ToString();
                Label_Up10s.Text = myAnswerUpBuf[0].ToString();
                Label_Up100s.Text = myAnswerUpBuf[1].ToString();
            }

            Label_1s.Text =myAnswerBuf[0].ToString();
            Label_10s.Text =myAnswerBuf[1].ToString();
            Label_100s.Text =myAnswerBuf[2].ToString();
            Label_1000s.Text =myAnswerBuf[3].ToString();

            if (LearnSetSington.Instance.setUpDispOnOff == true)
            {
                if (Label_RightUp10s.Text == Label_Up10s.Text)
                {
                    Label_Up10s.TextColor = Color.Blue;
                }
                else
                {
                    Label_Up10s.TextColor = Color.Red;
                }

                if (Label_RightUp100s.Text == Label_Up100s.Text)
                {
                    Label_Up100s.TextColor = Color.Blue;
                }
                else
                {
                    Label_Up100s.TextColor = Color.Red;
                }
            }

            if (Label_Right1s.Text == Label_1s.Text)
            {
                Label_1s.TextColor = Color.Blue;
            }
            else
            {
                Label_1s.TextColor = Color.Red;
            }

            if (Label_Right10s.Text == Label_10s.Text)
            {
                Label_10s.TextColor = Color.Blue;
            }
            else
            {
                Label_10s.TextColor = Color.Red;
            }

            if (Label_Right100s.Text == Label_100s.Text)
            {
                Label_100s.TextColor = Color.Blue;
            }
            else
            {
                Label_100s.TextColor = Color.Red;
            }

            if (Label_Right1000s.Text == Label_1000s.Text)
            {
                Label_1000s.TextColor = Color.Blue;
            }
            else
            {
                Label_1000s.TextColor = Color.Red;
            }

            if (LearnSetSington.Instance.setUpDispOnOff == true && Label_RightUp100s.Text == "1")
            {
                Label_RightUp100s.IsVisible = true;              
                Label_Up100s.IsVisible = true;                
            }
            else
            {
                Label_RightUp100s.IsVisible = false;
                Label_Up100s.IsVisible = false;
                Label_RightUp100s.Text = "0";
                Label_Up100s.Text = "0";             
            }

            if (LearnSetSington.Instance.setUpDispOnOff == true && Label_RightUp10s.Text == "1")
            {
                Label_RightUp10s.IsVisible = true;
                Label_Up10s.IsVisible = true;                
            }
            else
            {
                Label_RightUp10s.IsVisible = false;
                Label_Up10s.IsVisible = false;
                Label_RightUp10s.Text = "0";
                Label_Up10s.Text = "0";                
            }

            if (Label_Up10s.IsVisible == false && Label_Up100s.IsVisible == false)
            {
                Label_UpName.IsVisible = false;
            }
            else 
            {
                Label_UpName.IsVisible = true;
            }

            if (right_sum < 10)
            {
                Label_1000s.IsVisible = false;
                Label_100s.IsVisible = false;
                Label_10s.IsVisible = false;
                Label_Right1000s.IsVisible = false;
                Label_Right100s.IsVisible = false;
                Label_Right10s.IsVisible = false;


                Label_1000s.Text = "0";
                Label_100s.Text = "0";
                Label_10s.Text = "0";
                Label_Right1000s.Text = "0";
                Label_Right100s.Text = "0";
                Label_Right10s.Text = "0";

            }
            else if (right_sum < 100)
            {
                Label_1000s.IsVisible = false;
                Label_100s.IsVisible = false;
                Label_Right1000s.IsVisible = false;
                Label_Right100s.IsVisible = false;

                Label_1000s.Text = "0";
                Label_100s.Text = "0";
                Label_Right1000s.Text = "0";
                Label_Right100s.Text = "0";
            }
            else if (right_sum < 1000)
            {
                Label_1000s.IsVisible = false;
                Label_Right1000s.IsVisible = false;

                Label_1000s.Text = "0";
                Label_Right1000s.Text = "0";
            }
            else 
            {
            
            }
        }

        private async void Button_Back_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    await Navigation.PopModalAsync();
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                accessible = true;
            }           
        }
    }
}