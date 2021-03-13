using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;

namespace forms_plus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnningMultipleChoicePage : ContentPage
    {
        private int PassQuestionNum = 1;
        private bool accessible = true;
        public LearnningMultipleChoicePage()
        {
            InitializeComponent();

            var fontsize = (DeviceDisplay.MainDisplayInfo.Height > 1280) ? 25 : 20;

            Label_PassQNUM.FontSize = fontsize;
            Label_slash.FontSize = fontsize;
            Label_TotalQNUM.FontSize = fontsize;
            ConfirmButton.FontSize = fontsize+5;

            Init_AnswerButton();
            MakeQuestionMultipleChoice();
            MakeMultipleChoice(ResultData.Instance.rightSum);
        }

        private void init_ResultDataMultipleChoice()
        {
            ResultData.Instance.input1000s = -1;
            ResultData.Instance.input100s = -1;
            ResultData.Instance.input10s = -1;
            ResultData.Instance.input1s = -1;
            ResultData.Instance.inputUp100s = -1;
            ResultData.Instance.inputUp10s = -1;
            ResultData.Instance.rightAnswer1000s = 0;
            ResultData.Instance.rightAnswer100s = 0;
            ResultData.Instance.rightAnswerUp100s = 0;
            ResultData.Instance.rightAnswerUp10s = 0;
            ResultData.Instance.question_first100s = 0;
            ResultData.Instance.question_first10s = 0;
            ResultData.Instance.question_first1s = 0;
            ResultData.Instance.question_sec100s = 0;
            ResultData.Instance.question_sec10s = 0;
            ResultData.Instance.question_sec1s = 0;
            ResultData.Instance.rightSum = 0;
        }

        private void MakeQuestionMultipleChoice()
        {
            Random rnd = new Random();
            int question_first1s;
            int question_sec1s;
            int question_sum;

            init_ResultDataMultipleChoice();

            if (LearnSetSington.Instance.setUpONOFF == true)
            {
                do
                {
                    question_first1s = rnd.Next(1, 10);
                    question_sec1s = rnd.Next(1, 10);
                                        
                } while (question_first1s + question_sec1s < 10);
            }
            else
            {
                question_first1s = rnd.Next(1, 9);
                question_sec1s = rnd.Next(1, 10 - question_first1s);
            }

            Label_FirstNum1s.Text = question_first1s.ToString();
            Label_SecNum1s.Text = question_sec1s.ToString();

            ResultData.Instance.question_first1s = question_first1s;
            ResultData.Instance.question_sec1s = question_sec1s;

            question_sum = question_first1s + question_sec1s;
            ResultData.Instance.rightSum = question_sum;

            if (question_sum >= 10)
            {
                ResultData.Instance.rightAnswer10s = 1;
                ResultData.Instance.rightAnswer1s = question_sum - 10;
            }
            else 
            {
                ResultData.Instance.rightAnswer10s = 0;
                ResultData.Instance.rightAnswer1s = question_sum;
            }
        }

        private void MakeMultipleChoice(int rightSum)
        {
            Random rnd = new Random();
            int question_first1s;
            int question_sec1s;
            int question_sum;
            int loopIdx = 0;
            int posIdx = 0;

            int[] multipleAanswer = new int[4];
            int[] btnPosition = new int[4];

            multipleAanswer[0] = rightSum;
            for (loopIdx = 1; loopIdx < btnPosition.Length; loopIdx++)
            {
                if (LearnSetSington.Instance.setUpONOFF == true)
                {
                    question_first1s = rnd.Next(1, 10);
                    question_sec1s = rnd.Next(1, 10);

                    if (question_first1s + question_sec1s < 10)
                    {
                        loopIdx--;
                        continue;
                    }
                }
                else 
                {
                    question_first1s = rnd.Next(1, 9);
                    question_sec1s = rnd.Next(1, 10 - question_first1s);
                }

                question_sum = question_first1s + question_sec1s;

                if ((question_sum == rightSum)
                    || (question_sum == multipleAanswer[1])
                    || (question_sum == multipleAanswer[2])
                    || (question_sum == multipleAanswer[3]))
                {
                    loopIdx--;
                }
                else 
                {
                    multipleAanswer[loopIdx] = question_sum;
                }
            }

            loopIdx = 0;
            posIdx = 0;
            while (loopIdx < 4)
            {
                posIdx = rnd.Next(0, 4);

                if (btnPosition[posIdx] == 0)
                {
                    btnPosition[posIdx] = multipleAanswer[loopIdx++];
                }
            }

            AnswerButton1.Text = btnPosition[0].ToString();
            AnswerButton2.Text = btnPosition[1].ToString();
            AnswerButton3.Text = btnPosition[2].ToString();
            AnswerButton4.Text = btnPosition[3].ToString();
        }

        private void Init_AnswerButton()
        {
            AnswerButton1.BorderColor = Color.White;
            AnswerButton2.BorderColor = Color.White;
            AnswerButton3.BorderColor = Color.White;
            AnswerButton4.BorderColor = Color.White;

            AnswerButton1.BorderWidth = 3;
            AnswerButton2.BorderWidth = 3;
            AnswerButton3.BorderWidth = 3;
            AnswerButton4.BorderWidth = 3;
        }

        private void AnswerButton1_Clicked(object sender, EventArgs e)
        {
            ResultData.Instance.inputSum = Int32.Parse(AnswerButton1.Text);
            AnswerButton1.BorderColor = Color.Red;
            AnswerButton2.BorderColor = Color.White;
            AnswerButton3.BorderColor = Color.White;
            AnswerButton4.BorderColor = Color.White;
            AnswerButton1.BorderWidth = 5;

            Label_SelectedAnswer.Text = AnswerButton1.Text;

        }
        private void AnswerButton2_Clicked(object sender, EventArgs e)
        {
            ResultData.Instance.inputSum = Int32.Parse(AnswerButton2.Text);
            AnswerButton1.BorderColor = Color.White;
            AnswerButton2.BorderColor = Color.Red;
            AnswerButton3.BorderColor = Color.White;
            AnswerButton4.BorderColor = Color.White;
            AnswerButton2.BorderWidth = 5;

            Label_SelectedAnswer.Text = AnswerButton2.Text;
        }
        private void AnswerButton3_Clicked(object sender, EventArgs e)
        {
            ResultData.Instance.inputSum = Int32.Parse(AnswerButton3.Text);
            AnswerButton1.BorderColor = Color.White;
            AnswerButton2.BorderColor = Color.White;
            AnswerButton3.BorderColor = Color.Red;
            AnswerButton4.BorderColor = Color.White;
            AnswerButton3.BorderWidth = 5;

            Label_SelectedAnswer.Text = AnswerButton3.Text;
        }
        private void AnswerButton4_Clicked(object sender, EventArgs e)
        {
            ResultData.Instance.inputSum = Int32.Parse(AnswerButton4.Text);
            AnswerButton1.BorderColor = Color.White;
            AnswerButton2.BorderColor = Color.White;
            AnswerButton3.BorderColor = Color.White;
            AnswerButton4.BorderColor = Color.Red;
            AnswerButton4.BorderWidth = 5;

            Label_SelectedAnswer.Text = AnswerButton4.Text;
        }

        private int ConvertThreeFigure(int _100s, int _10s, int _1s)
        {
            int total = 0;

            total = (_100s * 100) + (_10s * 10) + _1s;

            return total;
        }
        private async void Result_Clicked(object sender, EventArgs e)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;

                    if ((AnswerButton1.BorderColor == Color.White)
                        && (AnswerButton2.BorderColor == Color.White)
                        && (AnswerButton3.BorderColor == Color.White)
                        && (AnswerButton4.BorderColor == Color.White))
                    {
                        await DisplayAlert("알림", "정답을 선택해주세요!", "확인");
                    }
                    else
                    {
                        AnswerSheetsData.Instance.SetAnswerSheetsData(
                                                                      ConvertThreeFigure(ResultData.Instance.question_first100s, ResultData.Instance.question_first10s, ResultData.Instance.question_first1s),
                                                                      ConvertThreeFigure(ResultData.Instance.question_sec100s, ResultData.Instance.question_sec10s, ResultData.Instance.question_sec1s),
                                                                      ConvertThreeFigure(0, ResultData.Instance.rightAnswerUp100s, ResultData.Instance.rightAnswerUp10s),
                                                                      ResultData.Instance.rightSum,
                                                                      ConvertThreeFigure(0, ResultData.Instance.inputUp100s, ResultData.Instance.inputUp10s),
                                                                      ResultData.Instance.inputSum,
                                                                      1);
                        AnswerSheetsData.Instance.DetailPageIndex = 1;
                        await Navigation.PushModalAsync(new AnswerSheetsDetailPage());

                        //await Navigation.PushModalAsync(new LearnResultPage());

                        Init_AnswerButton();

                        Label_SelectedAnswer.Text = "?";

                        if (PassQuestionNum < LearnSetSington.Instance.setQ_Num)
                        {
                            PassQuestionNum++;
                            Label_PassQNUM.Text = Convert.ToString(PassQuestionNum);
                            MakeQuestionMultipleChoice();
                            MakeMultipleChoice(ResultData.Instance.rightSum);
                        }
                        else
                        {
                            String Date = StringDate.Instance.DateYMD_to_String(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                            App.CalLearnInfoDatabase.SaveCalendarLearnInfo(UserInfo.Instance.userName,
                                                  LearnSetSington.Instance.setStage,
                                                  Date,
                                                  true);

                            await Navigation.PopAsync();
                        }
                    }
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