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
    public partial class AnswerSheetsDetailPage : ContentPage
    {
        public AnswerSheetsDetailPage()
        {
            InitializeComponent();

            PrintDetailData();
        }

        private void PrintDetailData()
        {
            string QuestionFirstLineString;
            string QuestionSecLineString;
            string RightAnswerString;
            string RightUpString;
            string MyAnswerString;
            string MyUpString;

            char[] qFirstbuf = new char[3];
            char[] qSecbuf = new char[3];
            char[] qRightAnswerBuf = new char[4];
            char[] myAnswerBuf = new char[4];
            char[] qRightUpBuf = new char[2];
            char[] myAnswerUpBuf = new char[2];

            int charBufIdx = 0;
            int strBufIdx = 0;
            int right_sum = 0;

            switch (AnswerSheetsData.Instance.DetailPageIndex)
            {
                case 1:
                    QuestionFirstLineString = AnswerSheetsData.Instance.Q_first1.ToString();
                    QuestionSecLineString = AnswerSheetsData.Instance.Q_sec1.ToString();
                    RightAnswerString = AnswerSheetsData.Instance.Q_RightAnswer1.ToString();
                    RightUpString = AnswerSheetsData.Instance.Q_RightUp1.ToString();
                    MyAnswerString = AnswerSheetsData.Instance.MyAnswer1.ToString();
                    MyUpString = AnswerSheetsData.Instance.MyUpAnswer1.ToString();
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer1;
                    break;
                case 2:
                    QuestionFirstLineString = AnswerSheetsData.Instance.Q_first2.ToString();
                    QuestionSecLineString = AnswerSheetsData.Instance.Q_sec2.ToString();
                    RightAnswerString = AnswerSheetsData.Instance.Q_RightAnswer2.ToString();
                    RightUpString = AnswerSheetsData.Instance.Q_RightUp2.ToString();
                    MyAnswerString = AnswerSheetsData.Instance.MyAnswer2.ToString();
                    MyUpString = AnswerSheetsData.Instance.MyUpAnswer2.ToString();
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer2;
                    break;
                case 3:
                    QuestionFirstLineString = AnswerSheetsData.Instance.Q_first3.ToString();
                    QuestionSecLineString = AnswerSheetsData.Instance.Q_sec3.ToString();
                    RightAnswerString = AnswerSheetsData.Instance.Q_RightAnswer3.ToString();
                    RightUpString = AnswerSheetsData.Instance.Q_RightUp3.ToString();
                    MyAnswerString = AnswerSheetsData.Instance.MyAnswer3.ToString();
                    MyUpString = AnswerSheetsData.Instance.MyUpAnswer3.ToString();
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer3;
                    break;
                case 4:
                    QuestionFirstLineString = AnswerSheetsData.Instance.Q_first4.ToString();
                    QuestionSecLineString = AnswerSheetsData.Instance.Q_sec4.ToString();
                    RightAnswerString = AnswerSheetsData.Instance.Q_RightAnswer4.ToString();
                    RightUpString = AnswerSheetsData.Instance.Q_RightUp4.ToString();
                    MyAnswerString = AnswerSheetsData.Instance.MyAnswer4.ToString();
                    MyUpString = AnswerSheetsData.Instance.MyUpAnswer4.ToString();
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer4;
                    break;
                case 5:
                    QuestionFirstLineString = AnswerSheetsData.Instance.Q_first5.ToString();
                    QuestionSecLineString = AnswerSheetsData.Instance.Q_sec5.ToString();
                    RightAnswerString = AnswerSheetsData.Instance.Q_RightAnswer5.ToString();
                    RightUpString = AnswerSheetsData.Instance.Q_RightUp5.ToString();
                    MyAnswerString = AnswerSheetsData.Instance.MyAnswer5.ToString();
                    MyUpString = AnswerSheetsData.Instance.MyUpAnswer5.ToString();
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer5;
                    break;
                case 6:
                    QuestionFirstLineString = AnswerSheetsData.Instance.Q_first6.ToString();
                    QuestionSecLineString = AnswerSheetsData.Instance.Q_sec6.ToString();
                    RightAnswerString = AnswerSheetsData.Instance.Q_RightAnswer6.ToString();
                    RightUpString = AnswerSheetsData.Instance.Q_RightUp6.ToString();
                    MyAnswerString = AnswerSheetsData.Instance.MyAnswer6.ToString();
                    MyUpString = AnswerSheetsData.Instance.MyUpAnswer6.ToString();
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer6;
                    break;
                case 7:
                    QuestionFirstLineString = AnswerSheetsData.Instance.Q_first7.ToString();
                    QuestionSecLineString = AnswerSheetsData.Instance.Q_sec7.ToString();
                    RightAnswerString = AnswerSheetsData.Instance.Q_RightAnswer7.ToString();
                    RightUpString = AnswerSheetsData.Instance.Q_RightUp7.ToString();
                    MyAnswerString = AnswerSheetsData.Instance.MyAnswer7.ToString();
                    MyUpString = AnswerSheetsData.Instance.MyUpAnswer7.ToString();
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer7;
                    break;
                case 8:
                    QuestionFirstLineString = AnswerSheetsData.Instance.Q_first8.ToString();
                    QuestionSecLineString = AnswerSheetsData.Instance.Q_sec8.ToString();
                    RightAnswerString = AnswerSheetsData.Instance.Q_RightAnswer8.ToString();
                    RightUpString = AnswerSheetsData.Instance.Q_RightUp8.ToString();
                    MyAnswerString = AnswerSheetsData.Instance.MyAnswer8.ToString();
                    MyUpString = AnswerSheetsData.Instance.MyUpAnswer8.ToString();
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer8;
                    break;
                case 9:
                    QuestionFirstLineString = AnswerSheetsData.Instance.Q_first9.ToString();
                    QuestionSecLineString = AnswerSheetsData.Instance.Q_sec9.ToString();
                    RightAnswerString = AnswerSheetsData.Instance.Q_RightAnswer9.ToString();
                    RightUpString = AnswerSheetsData.Instance.Q_RightUp9.ToString();
                    MyAnswerString = AnswerSheetsData.Instance.MyAnswer9.ToString();
                    MyUpString = AnswerSheetsData.Instance.MyUpAnswer9.ToString();
                    right_sum = AnswerSheetsData.Instance.Q_RightAnswer9;
                    break;
                case 10:
                default:
                    QuestionFirstLineString = AnswerSheetsData.Instance.Q_first10.ToString();
                    QuestionSecLineString = AnswerSheetsData.Instance.Q_sec10.ToString();
                    RightAnswerString = AnswerSheetsData.Instance.Q_RightAnswer10.ToString();
                    RightUpString = AnswerSheetsData.Instance.Q_RightUp10.ToString();
                    MyAnswerString = AnswerSheetsData.Instance.MyAnswer10.ToString();
                    MyUpString = AnswerSheetsData.Instance.MyUpAnswer10.ToString();
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
                myAnswerBuf[charBufIdx] = MyAnswerString[strBufIdx];
            }

            charBufIdx = 0;
            for (strBufIdx = RightUpString.Length - 1; strBufIdx >= 0; strBufIdx--, charBufIdx++)
            {
                qRightUpBuf[charBufIdx] = RightUpString[strBufIdx];
                myAnswerUpBuf[charBufIdx] = MyUpString[strBufIdx];
            }

            Label_FirstNum1s.Text = qFirstbuf[0].ToString();
            Label_FirstNum10s.Text = qFirstbuf[1].ToString();
            Label_FirstNum100s.Text = qFirstbuf[2].ToString();

            Label_SecNum1s.Text = qSecbuf[0].ToString();
            Label_SecNum10s.Text = qSecbuf[1].ToString();
            Label_SecNum100s.Text = qSecbuf[2].ToString();

            Label_RightUp10s.Text = qRightUpBuf[0].ToString();
            Label_RightUp100s.Text = qRightUpBuf[1].ToString();

            Label_Right1s.Text = qRightAnswerBuf[0].ToString();
            Label_Right10s.Text = qRightAnswerBuf[1].ToString();
            Label_Right100s.Text = qRightAnswerBuf[2].ToString();
            Label_Right1000s.Text = qRightAnswerBuf[3].ToString();

            Label_Up10s.Text = myAnswerUpBuf[0].ToString();
            Label_Up100s.Text = myAnswerUpBuf[1].ToString();

            Label_1s.Text = myAnswerBuf[0].ToString();
            Label_10s.Text = myAnswerBuf[1].ToString();
            Label_100s.Text = myAnswerBuf[2].ToString();
            Label_1000s.Text = myAnswerBuf[3].ToString();

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

            if (LearnSetSington.Instance.setUpDispOnOff == false)
            {
                Label_RightUp100s.IsVisible = false;
                Label_RightUp10s.IsVisible = false;
                Label_Up100s.IsVisible = false;
                Label_Up10s.IsVisible = false;
            }
            else
            {
                Label_RightUp100s.IsVisible = true;
                Label_RightUp10s.IsVisible = true;
                Label_Up100s.IsVisible = true;
                Label_Up10s.IsVisible = true;
            }

            Label_1000s.IsVisible = true;
            Label_100s.IsVisible = true;
            Label_10s.IsVisible = true;
            Label_1s.IsVisible = true;
            Label_Right1000s.IsVisible = true;
            Label_Right100s.IsVisible = true;
            Label_Right10s.IsVisible = true;
            Label_Right1s.IsVisible = true;


            if (right_sum < 10)
            {
                Label_1000s.IsVisible = false;
                Label_100s.IsVisible = false;
                Label_10s.IsVisible = false;
                Label_Right1000s.IsVisible = false;
                Label_Right100s.IsVisible = false;
                Label_Right10s.IsVisible = false;

            }
            else if (right_sum < 100)
            {
                Label_1000s.IsVisible = false;
                Label_100s.IsVisible = false;
                Label_Right1000s.IsVisible = false;
                Label_Right100s.IsVisible = false;
            }
            else if (right_sum < 1000)
            {
                Label_1000s.IsVisible = false;
                Label_Right1000s.IsVisible = false;
            }
            else 
            {
            
            }
        }

        private async void Button_Back_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
        }
    }
}