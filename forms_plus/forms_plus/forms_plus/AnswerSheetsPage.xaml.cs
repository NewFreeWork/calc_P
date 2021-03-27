using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using Plugin.SimpleAudioPlayer;
using forms_plus.ViewModel;

namespace forms_plus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnswerSheetsPage : ContentPage
    {
        private bool accessible = true;
        ISimpleAudioPlayer player;

        public AnswerSheetsPage()
        {
            InitializeComponent();

            InitSound();
            this.BindingContext = new FontSizeViewModel();

            PrintData();

            App.RkInfoDatabase.SaveRankingInfo(UserInfo.Instance.userName,
                                            LearnSetSington.Instance.setStage,
                                            AnswerSheetsData.Instance.MyScore,
                                            AnswerSheetsData.Instance.TotalTime,
                                            LearnSetSington.Instance.setQ_Num);


            String Date = StringDate.Instance.DateYMD_to_String(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

            App.CalTestInfoDatabase.SaveCalendarTestInfo(UserInfo.Instance.userName,
                                            LearnSetSington.Instance.setStage,
                                            Date,
                                            AnswerSheetsData.Instance.MyScore,
                                            AnswerSheetsData.Instance.TotalTime);
           
        }

        protected override bool OnBackButtonPressed()
        {
            try
            {

                Delete_CurrentPage();


                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return true;
            }
        }
        private async void Delete_CurrentPage()
        {
            try
            {
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 1]);
                Navigation.RemovePage(Navigation.NavigationStack[Navigation.NavigationStack.Count - 2]);
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

#if false // int to string
        private Color Is_RightAnswer(string rightAnswer, string myAnswer, string rightUp, string myUp)
        {
            if ((rightAnswer != myAnswer)||(rightUp != myUp))
                return Color.Red;
            else
                return Color.Blue;
        }
        private void PrintData()
        {
            int Score = 0;
            int RightCnt = 0;
            int TestNum = 0;

            if (AnswerSheetsData.Instance.Q_first1 != "")
            {
                Label_Q1.Text = AnswerSheetsData.Instance.Q_first1 + " + " + AnswerSheetsData.Instance.Q_sec1+ " = " + AnswerSheetsData.Instance.MyAnswer1;
                Label_Q1.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer1, AnswerSheetsData.Instance.MyAnswer1, AnswerSheetsData.Instance.Q_RightUp1, AnswerSheetsData.Instance.MyUpAnswer1);
                if (Label_Q1.TextColor == Color.Blue)
                {
                    Button_Q1.Text = "O";
                    Button_Q1.TextColor = Color.Blue;
                    RightCnt++;
                }
                else
                {
                    Button_Q1.Text = "X";
                    Button_Q1.TextColor = Color.Red;
                }
                Label_Q1.IsVisible = true;
                Label_Idx1.IsVisible = true;
                Button_Q1.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q1.IsVisible = false;
                Label_Idx1.IsVisible = false;
                Button_Q1.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first2 != "")
            {
                Label_Q2.Text = AnswerSheetsData.Instance.Q_first2 + " + " + AnswerSheetsData.Instance.Q_sec2 + " = " + AnswerSheetsData.Instance.MyAnswer2;
                Label_Q2.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer2, AnswerSheetsData.Instance.MyAnswer2, AnswerSheetsData.Instance.Q_RightUp2, AnswerSheetsData.Instance.MyUpAnswer2);
                if (Label_Q2.TextColor == Color.Blue)
                {
                    Button_Q2.Text = "O";
                    Button_Q2.TextColor = Color.Blue;
                    RightCnt++;
                }
                else
                {
                    Button_Q2.Text = "X";
                    Button_Q2.TextColor = Color.Red;
                }
                Label_Q2.IsVisible = true;
                Label_Idx2.IsVisible = true;
                Button_Q2.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q2.IsVisible = false;
                Label_Idx2.IsVisible = false;
                Button_Q2.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first3 != "")
            {
                Label_Q3.Text = AnswerSheetsData.Instance.Q_first3 + " + " + AnswerSheetsData.Instance.Q_sec3 + " = " + AnswerSheetsData.Instance.MyAnswer3;
                Label_Q3.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer3, AnswerSheetsData.Instance.MyAnswer3, AnswerSheetsData.Instance.Q_RightUp3, AnswerSheetsData.Instance.MyUpAnswer3);
                if (Label_Q3.TextColor == Color.Blue)
                {
                    Button_Q3.Text = "O";
                    Button_Q3.TextColor = Color.Blue;
                    RightCnt++;
                }
                else
                {
                    Button_Q3.Text = "X";
                    Button_Q3.TextColor = Color.Red;
                }
                Label_Q3.IsVisible = true;
                Label_Idx3.IsVisible = true;
                Button_Q3.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q3.IsVisible = false;
                Label_Idx3.IsVisible = false;
                Button_Q3.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first4 != "")
            {
                Label_Q4.Text = AnswerSheetsData.Instance.Q_first4 + " + " + AnswerSheetsData.Instance.Q_sec4 + " = " + AnswerSheetsData.Instance.MyAnswer4;
                Label_Q4.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer4, AnswerSheetsData.Instance.MyAnswer4, AnswerSheetsData.Instance.Q_RightUp4, AnswerSheetsData.Instance.MyUpAnswer4);
                if (Label_Q4.TextColor == Color.Blue)
                {
                    Button_Q4.Text = "O";
                    Button_Q4.TextColor = Color.Blue;
                    RightCnt++;
                }
                else
                {
                    Button_Q4.Text = "X";
                    Button_Q4.TextColor = Color.Red;
                }
                Label_Q4.IsVisible = true;
                Label_Idx4.IsVisible = true;
                Button_Q4.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q4.IsVisible = false;
                Label_Idx4.IsVisible = false;
                Button_Q4.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first5 != "")
            {
                Label_Q5.Text = AnswerSheetsData.Instance.Q_first5 + " + " + AnswerSheetsData.Instance.Q_sec5 + " = " + AnswerSheetsData.Instance.MyAnswer5;
                Label_Q5.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer5, AnswerSheetsData.Instance.MyAnswer5, AnswerSheetsData.Instance.Q_RightUp5, AnswerSheetsData.Instance.MyUpAnswer5);
                if (Label_Q5.TextColor == Color.Blue)
                {
                    Button_Q5.Text = "O";
                    Button_Q5.TextColor = Color.Blue;
                    RightCnt++;
                }
                else
                {
                    Button_Q5.Text = "X";
                    Button_Q5.TextColor = Color.Red;
                }
                Label_Q5.IsVisible = true;
                Label_Idx5.IsVisible = true;
                Button_Q5.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q5.IsVisible = false;
                Label_Idx5.IsVisible = false;
                Button_Q5.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first6 != "")
            {
                Label_Q6.Text = AnswerSheetsData.Instance.Q_first6 + " + " + AnswerSheetsData.Instance.Q_sec6 + " = " + AnswerSheetsData.Instance.MyAnswer6;
                Label_Q6.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer6, AnswerSheetsData.Instance.MyAnswer6, AnswerSheetsData.Instance.Q_RightUp6, AnswerSheetsData.Instance.MyUpAnswer6);
                if (Label_Q6.TextColor == Color.Blue)
                {
                    Button_Q6.Text = "O";
                    Button_Q6.TextColor = Color.Blue;
                    RightCnt++;
                }
                else
                {
                    Button_Q6.Text = "X";
                    Button_Q6.TextColor = Color.Red;
                }
                Label_Q6.IsVisible = true;
                Label_Idx6.IsVisible = true;
                Button_Q6.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q6.IsVisible = false;
                Label_Idx6.IsVisible = false;
                Button_Q6.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first7 != "")
            {
                Label_Q7.Text = AnswerSheetsData.Instance.Q_first7 + " + " + AnswerSheetsData.Instance.Q_sec7 + " = " + AnswerSheetsData.Instance.MyAnswer7;
                Label_Q7.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer7, AnswerSheetsData.Instance.MyAnswer7, AnswerSheetsData.Instance.Q_RightUp7, AnswerSheetsData.Instance.MyUpAnswer7);
                if (Label_Q7.TextColor == Color.Blue)
                {
                    Button_Q7.Text = "O";
                    Button_Q7.TextColor = Color.Blue;
                    RightCnt++;
                }
                else
                {
                    Button_Q7.Text = "X";
                    Button_Q7.TextColor = Color.Red;
                }
                Label_Q7.IsVisible = true;
                Label_Idx7.IsVisible = true;
                Button_Q7.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q7.IsVisible = false;
                Label_Idx7.IsVisible = false;
                Button_Q7.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first8 != "")
            {
                Label_Q8.Text = AnswerSheetsData.Instance.Q_first8 + " + " + AnswerSheetsData.Instance.Q_sec8 + " = " + AnswerSheetsData.Instance.MyAnswer8;
                Label_Q8.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer8, AnswerSheetsData.Instance.MyAnswer8, AnswerSheetsData.Instance.Q_RightUp8, AnswerSheetsData.Instance.MyUpAnswer8);
                if (Label_Q8.TextColor == Color.Blue)
                {
                    Button_Q8.Text = "O";
                    Button_Q8.TextColor = Color.Blue;
                    RightCnt++;
                }
                else
                {
                    Button_Q8.Text = "X";
                    Button_Q8.TextColor = Color.Red;
                }
                Label_Q8.IsVisible = true;
                Label_Idx8.IsVisible = true;
                Button_Q8.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q8.IsVisible = false;
                Label_Idx8.IsVisible = false;
                Button_Q8.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first9 != "")
            {
                Label_Q9.Text = AnswerSheetsData.Instance.Q_first9 + " + " + AnswerSheetsData.Instance.Q_sec9 + " = " + AnswerSheetsData.Instance.MyAnswer9;
                Label_Q9.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer9, AnswerSheetsData.Instance.MyAnswer9, AnswerSheetsData.Instance.Q_RightUp9, AnswerSheetsData.Instance.MyUpAnswer9);
                if (Label_Q9.TextColor == Color.Blue)
                {
                    Button_Q9.Text = "O";
                    Button_Q9.TextColor = Color.Blue;
                    RightCnt++;
                }
                else
                {
                    Button_Q9.Text = "X";
                    Button_Q9.TextColor = Color.Red;
                }
                Label_Q9.IsVisible = true;
                Label_Idx9.IsVisible = true;
                Button_Q9.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q9.IsVisible = false;
                Label_Idx9.IsVisible = false;
                Button_Q9.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first10 != "")
            {
                Label_Q10.Text = AnswerSheetsData.Instance.Q_first10 + " + " + AnswerSheetsData.Instance.Q_sec10 + " = " + AnswerSheetsData.Instance.MyAnswer10;
                Label_Q10.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer10, AnswerSheetsData.Instance.MyAnswer10, AnswerSheetsData.Instance.Q_RightUp10, AnswerSheetsData.Instance.MyUpAnswer10);
                if (Label_Q1.TextColor == Color.Blue)
                {
                    Button_Q10.Text = "O";
                    Button_Q10.TextColor = Color.Blue;
                    RightCnt++;
                }
                else
                {
                    Button_Q10.Text = "X";
                    Button_Q10.TextColor = Color.Red;
                }
                Label_Q10.IsVisible = true;
                Label_Idx10.IsVisible = true;
                Button_Q10.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q10.IsVisible = false;
                Label_Idx10.IsVisible = false;
                Button_Q10.IsVisible = false;

            }


            Score = (RightCnt * 10 / TestNum) * 10;
            Label_Score.Text = Score.ToString() + "점";

            if (Score == 100)
            {
                Label_Stamp.Text = "EXCELLENT!!";
                Label_Stamp.TextColor = Color.Blue;
            }
            else if ((Score < 100) && (Score >= 80))
            {
                Label_Stamp.Text = "VERY GOOD!!";
                Label_Stamp.TextColor = Color.SkyBlue;
            }
            else if ((Score < 80) && (Score >= 60))
            {
                Label_Stamp.Text = " GOOD!! ";
                Label_Stamp.TextColor = Color.Gold;
            }
            else if ((Score < 60) && (Score >= 40))
            {
                Label_Stamp.Text = " FAIR!! ";
                Label_Stamp.TextColor = Color.Orange;
            }
            else if ((Score < 40) && (Score >= 20))
            {
                Label_Stamp.Text = " POOR!! ";
                Label_Stamp.TextColor = Color.OrangeRed;
            }
            else
            {
                Label_Stamp.Text = "VERY BAD!! ";
                Label_Stamp.TextColor = Color.Red;
            }

            Label_Time.Text = AnswerSheetsData.Instance.TotalTime;

        }
#else
        private Color Is_RightAnswer(int rightAnswer, int myAnswer, int rightUp, int myUp)
        {
            if (LearnSetSington.Instance.setUpDispOnOff == true)
            {
                if ((rightAnswer != myAnswer) || (rightUp != myUp))
                {
                    return Color.Red;
                }
                else
                {
                    return Color.FromHex("5151FD");
                }
            }
            else
            {
                if (rightAnswer != myAnswer)
                {
                    return Color.Red;
                }
                else
                {
                    return Color.FromHex("5151FD");
                }

            }
        }
        private void PrintData()
        {
            int Score = 0;
            int RightCnt = 0;
            int TestNum = 0;

            if (AnswerSheetsData.Instance.Q_first1 != 0)
            {
                Label_Q1.Text = AnswerSheetsData.Instance.Q_first1.ToString() + " + " + AnswerSheetsData.Instance.Q_sec1.ToString() + " = " + AnswerSheetsData.Instance.MyAnswer1.ToString();
                Label_Q1.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer1, AnswerSheetsData.Instance.MyAnswer1, AnswerSheetsData.Instance.Q_RightUp1, AnswerSheetsData.Instance.MyUpAnswer1);
                if (Label_Q1.TextColor == Color.FromHex("5151FD"))
                {
                    Button_Q1.Text = "O";
                    Button_Q1.TextColor = Color.FromHex("5151FD");
                    RightCnt++;
                }
                else
                {
                    Button_Q1.Text = "X";
                    Button_Q1.TextColor = Color.Red;
                }
                Label_Q1.IsVisible = true;
                Label_Idx1.IsVisible = true;
                Button_Q1.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q1.IsVisible = false;
                Label_Idx1.IsVisible = false;
                Button_Q1.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first2 != 0)
            {
                Label_Q2.Text = AnswerSheetsData.Instance.Q_first2.ToString() + " + " + AnswerSheetsData.Instance.Q_sec2.ToString() + " = " + AnswerSheetsData.Instance.MyAnswer2.ToString();
                Label_Q2.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer2, AnswerSheetsData.Instance.MyAnswer2, AnswerSheetsData.Instance.Q_RightUp2, AnswerSheetsData.Instance.MyUpAnswer2);
                if (Label_Q2.TextColor == Color.FromHex("5151FD"))
                {
                    Button_Q2.Text = "O";
                    Button_Q2.TextColor = Color.FromHex("5151FD");
                    RightCnt++;
                }
                else
                {
                    Button_Q2.Text = "X";
                    Button_Q2.TextColor = Color.Red;
                }
                Label_Q2.IsVisible = true;
                Label_Idx2.IsVisible = true;
                Button_Q2.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q2.IsVisible = false;
                Label_Idx2.IsVisible = false;
                Button_Q2.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first3 != 0)
            {
                Label_Q3.Text = AnswerSheetsData.Instance.Q_first3.ToString() + " + " + AnswerSheetsData.Instance.Q_sec3.ToString() + " = " + AnswerSheetsData.Instance.MyAnswer3.ToString();
                Label_Q3.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer3, AnswerSheetsData.Instance.MyAnswer3, AnswerSheetsData.Instance.Q_RightUp3, AnswerSheetsData.Instance.MyUpAnswer3);
                if (Label_Q3.TextColor == Color.FromHex("5151FD"))
                {
                    Button_Q3.Text = "O";
                    Button_Q3.TextColor = Color.FromHex("5151FD");
                    RightCnt++;
                }
                else
                {
                    Button_Q3.Text = "X";
                    Button_Q3.TextColor = Color.Red;
                }
                Label_Q3.IsVisible = true;
                Label_Idx3.IsVisible = true;
                Button_Q3.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q3.IsVisible = false;
                Label_Idx3.IsVisible = false;
                Button_Q3.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first4 != 0)
            {
                Label_Q4.Text = AnswerSheetsData.Instance.Q_first4.ToString() + " + " + AnswerSheetsData.Instance.Q_sec4.ToString() + " = " + AnswerSheetsData.Instance.MyAnswer4.ToString();
                Label_Q4.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer4, AnswerSheetsData.Instance.MyAnswer4, AnswerSheetsData.Instance.Q_RightUp4, AnswerSheetsData.Instance.MyUpAnswer4);
                if (Label_Q4.TextColor == Color.FromHex("5151FD"))
                {
                    Button_Q4.Text = "O";
                    Button_Q4.TextColor = Color.FromHex("5151FD");
                    RightCnt++;
                }
                else
                {
                    Button_Q4.Text = "X";
                    Button_Q4.TextColor = Color.Red;
                }
                Label_Q4.IsVisible = true;
                Label_Idx4.IsVisible = true;
                Button_Q4.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q4.IsVisible = false;
                Label_Idx4.IsVisible = false;
                Button_Q4.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first5 != 0)
            {
                Label_Q5.Text = AnswerSheetsData.Instance.Q_first5.ToString() + " + " + AnswerSheetsData.Instance.Q_sec5.ToString() + " = " + AnswerSheetsData.Instance.MyAnswer5.ToString();
                Label_Q5.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer5, AnswerSheetsData.Instance.MyAnswer5, AnswerSheetsData.Instance.Q_RightUp5, AnswerSheetsData.Instance.MyUpAnswer5);
                if (Label_Q5.TextColor == Color.FromHex("5151FD"))
                {
                    Button_Q5.Text = "O";
                    Button_Q5.TextColor = Color.FromHex("5151FD");
                    RightCnt++;
                }
                else
                {
                    Button_Q5.Text = "X";
                    Button_Q5.TextColor = Color.Red;
                }
                Label_Q5.IsVisible = true;
                Label_Idx5.IsVisible = true;
                Button_Q5.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q5.IsVisible = false;
                Label_Idx5.IsVisible = false;
                Button_Q5.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first6 != 0)
            {
                Label_Q6.Text = AnswerSheetsData.Instance.Q_first6.ToString() + " + " + AnswerSheetsData.Instance.Q_sec6.ToString() + " = " + AnswerSheetsData.Instance.MyAnswer6.ToString();
                Label_Q6.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer6, AnswerSheetsData.Instance.MyAnswer6, AnswerSheetsData.Instance.Q_RightUp6, AnswerSheetsData.Instance.MyUpAnswer6);
                if (Label_Q6.TextColor == Color.FromHex("5151FD"))
                {
                    Button_Q6.Text = "O";
                    Button_Q6.TextColor = Color.FromHex("5151FD");
                    RightCnt++;
                }
                else
                {
                    Button_Q6.Text = "X";
                    Button_Q6.TextColor = Color.Red;
                }
                Label_Q6.IsVisible = true;
                Label_Idx6.IsVisible = true;
                Button_Q6.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q6.IsVisible = false;
                Label_Idx6.IsVisible = false;
                Button_Q6.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first7 != 0)
            {
                Label_Q7.Text = AnswerSheetsData.Instance.Q_first7.ToString() + " + " + AnswerSheetsData.Instance.Q_sec7.ToString() + " = " + AnswerSheetsData.Instance.MyAnswer7.ToString();
                Label_Q7.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer7, AnswerSheetsData.Instance.MyAnswer7, AnswerSheetsData.Instance.Q_RightUp7, AnswerSheetsData.Instance.MyUpAnswer7);
                if (Label_Q7.TextColor == Color.FromHex("5151FD"))
                {
                    Button_Q7.Text = "O";
                    Button_Q7.TextColor = Color.FromHex("5151FD");
                    RightCnt++;
                }
                else
                {
                    Button_Q7.Text = "X";
                    Button_Q7.TextColor = Color.Red;
                }
                Label_Q7.IsVisible = true;
                Label_Idx7.IsVisible = true;
                Button_Q7.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q7.IsVisible = false;
                Label_Idx7.IsVisible = false;
                Button_Q7.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first8 != 0)
            {
                Label_Q8.Text = AnswerSheetsData.Instance.Q_first8.ToString() + " + " + AnswerSheetsData.Instance.Q_sec8.ToString() + " = " + AnswerSheetsData.Instance.MyAnswer8.ToString();
                Label_Q8.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer8, AnswerSheetsData.Instance.MyAnswer8, AnswerSheetsData.Instance.Q_RightUp8, AnswerSheetsData.Instance.MyUpAnswer8);
                if (Label_Q8.TextColor == Color.FromHex("5151FD"))
                {
                    Button_Q8.Text = "O";
                    Button_Q8.TextColor = Color.FromHex("5151FD");
                    RightCnt++;
                }
                else
                {
                    Button_Q8.Text = "X";
                    Button_Q8.TextColor = Color.Red;
                }
                Label_Q8.IsVisible = true;
                Label_Idx8.IsVisible = true;
                Button_Q8.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q8.IsVisible = false;
                Label_Idx8.IsVisible = false;
                Button_Q8.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first9 != 0)
            {
                Label_Q9.Text = AnswerSheetsData.Instance.Q_first9.ToString() + " + " + AnswerSheetsData.Instance.Q_sec9.ToString() + " = " + AnswerSheetsData.Instance.MyAnswer9.ToString();
                Label_Q9.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer9, AnswerSheetsData.Instance.MyAnswer9, AnswerSheetsData.Instance.Q_RightUp9, AnswerSheetsData.Instance.MyUpAnswer9);
                if (Label_Q9.TextColor == Color.FromHex("5151FD"))
                {
                    Button_Q9.Text = "O";
                    Button_Q9.TextColor = Color.FromHex("5151FD");
                    RightCnt++;
                }
                else
                {
                    Button_Q9.Text = "X";
                    Button_Q9.TextColor = Color.Red;
                }
                Label_Q9.IsVisible = true;
                Label_Idx9.IsVisible = true;
                Button_Q9.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q9.IsVisible = false;
                Label_Idx9.IsVisible = false;
                Button_Q9.IsVisible = false;

            }

            if (AnswerSheetsData.Instance.Q_first10 != 0)
            {
                Label_Q10.Text = AnswerSheetsData.Instance.Q_first10.ToString() + " + " + AnswerSheetsData.Instance.Q_sec10.ToString() + " = " + AnswerSheetsData.Instance.MyAnswer10.ToString();
                Label_Q10.TextColor = Is_RightAnswer(AnswerSheetsData.Instance.Q_RightAnswer10, AnswerSheetsData.Instance.MyAnswer10, AnswerSheetsData.Instance.Q_RightUp10, AnswerSheetsData.Instance.MyUpAnswer10);
                if (Label_Q10.TextColor == Color.FromHex("5151FD"))
                {
                    Button_Q10.Text = "O";
                    Button_Q10.TextColor = Color.FromHex("5151FD");
                    RightCnt++;
                }
                else
                {
                    Button_Q10.Text = "X";
                    Button_Q10.TextColor = Color.Red;
                }
                Label_Q10.IsVisible = true;
                Label_Idx10.IsVisible = true;
                Button_Q10.IsVisible = true;
                TestNum++;
            }
            else
            {
                Label_Q10.IsVisible = false;
                Label_Idx10.IsVisible = false;
                Button_Q10.IsVisible = false;

            }


            Score = (RightCnt * 10 / TestNum) * 10;
            Label_Score.Text = Score.ToString() + "점";
            AnswerSheetsData.Instance.MyScore = Score;

            if (Score == 100)
            {
                Label_Stamp.Text = "EXCELLENT!!";
                Label_Stamp.TextColor = Color.Blue;
            }
            else if ((Score < 100) && (Score >= 80))
            {
                Label_Stamp.Text = "VERY GOOD!!";
                Label_Stamp.TextColor = Color.SkyBlue;
            }
            else if ((Score < 80) && (Score >= 60))
            {
                Label_Stamp.Text = " GOOD!! ";
                Label_Stamp.TextColor = Color.Gold;
            }
            else if ((Score < 60) && (Score >= 40))
            {
                Label_Stamp.Text = " FAIR!! ";
                Label_Stamp.TextColor = Color.Orange;
            }
            else if ((Score < 40) && (Score >= 20))
            {
                Label_Stamp.Text = " POOR!! ";
                Label_Stamp.TextColor = Color.OrangeRed;
            }
            else 
            {
                Label_Stamp.Text = "VERY BAD!! ";
                Label_Stamp.TextColor = Color.Red;
            }

            Label_Time.Text = AnswerSheetsData.Instance.TotalTime;

        }
#endif
        private void InitSound()
        {
            // player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            // player.Load("Sounds/Start.wav");
        }
        private void PlayBtnSound()
        {
            player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("Sounds/Blop.mp3");
            player.Play();
        }

        private async void Home_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();

                    for (int PageIdx = Navigation.NavigationStack.Count; PageIdx > 3; PageIdx--)
                    {
                        Navigation.RemovePage(Navigation.NavigationStack[PageIdx - 1]);
                    }
                    await Navigation.PopAsync();

                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                accessible = true;
            }
           
        }

        private async void Detail_Answer1_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
                    AnswerSheetsData.Instance.DetailPageIndex = 1;
                    await Navigation.PushModalAsync(new AnswerSheetsDetailPage());
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                accessible = true;
            }
        }
        private async void Detail_Answer2_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
                    AnswerSheetsData.Instance.DetailPageIndex = 2;
                    await Navigation.PushModalAsync(new AnswerSheetsDetailPage());
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                accessible = true;
            }
           
        }
        private async void Detail_Answer3_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
                    AnswerSheetsData.Instance.DetailPageIndex = 3;
                    await Navigation.PushModalAsync(new AnswerSheetsDetailPage());
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                accessible = true;
            }
        }
        private async void Detail_Answer4_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
                    AnswerSheetsData.Instance.DetailPageIndex = 4;
                    await Navigation.PushModalAsync(new AnswerSheetsDetailPage());
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                accessible = true;
            }
        }
        private async void Detail_Answer5_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
                    AnswerSheetsData.Instance.DetailPageIndex = 5;
                    await Navigation.PushModalAsync(new AnswerSheetsDetailPage());
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                accessible = true;
            }
        }
        private async void Detail_Answer6_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
                    AnswerSheetsData.Instance.DetailPageIndex = 6;
                    await Navigation.PushModalAsync(new AnswerSheetsDetailPage());
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                accessible = true;
            }
        }
        private async void Detail_Answer7_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
                    AnswerSheetsData.Instance.DetailPageIndex = 7;
                    await Navigation.PushModalAsync(new AnswerSheetsDetailPage());
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                accessible = true;
            }
        }
        private async void Detail_Answer8_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
                    AnswerSheetsData.Instance.DetailPageIndex = 8;
                    await Navigation.PushModalAsync(new AnswerSheetsDetailPage());
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                accessible = true;
            }
        }
        private async void Detail_Answer9_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
                    AnswerSheetsData.Instance.DetailPageIndex = 9;
                    await Navigation.PushModalAsync(new AnswerSheetsDetailPage());
                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                accessible = true;
            }
        }
        private async void Detail_Answer10_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;
                    PlayBtnSound();
                    AnswerSheetsData.Instance.DetailPageIndex = 10;
                    await Navigation.PushModalAsync(new AnswerSheetsDetailPage());
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