﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xamarin.Essentials;
using System.Threading;
using forms_plus.ViewModel;

namespace forms_plus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnningMultipleChoicePage : ContentPage
    {
        private int PassQuestionNum = 1;

        private int old_firstNum1s = 0;
        private int old_secNum1s = 0;

        private bool accessible = true;

        int[] arr = new int[10];

        public LearnningMultipleChoicePage()
        {
            InitializeComponent();

            this.BindingContext = new FontSizeViewModel();

            arr[0] = 1;
            arr[1] = 2;
            arr[2] = 3;
            arr[3] = 4;
            arr[4] = 5;
            arr[5] = 6;
            arr[6] = 7;
            arr[7] = 8;
            arr[8] = 3;
            arr[9] = 4;

            accessible = true;

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

        private int GetNewRandomNum(int startNum, int endNum, int oldNum)
        {
            Random rnd = new Random();
            int newNum = 0;

            do
            {
                newNum = rnd.Next(startNum, endNum);
            } while (newNum == oldNum);

            return newNum;
        }

        private int GetLimitedRandomNum(int firstNum)
        {
            Random rnd = new Random();
            int ret = 0;
            int limit = 10 - firstNum;

            ret = rnd.Next(1, limit);

            return ret;
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
                question_first1s = 0;
                do
                {
                    int temp = rnd.Next(0, 10);
                    if (arr[temp] != 0)
                    {
                        question_first1s = arr[temp];
                        arr[temp] = 0;
                    }
                } while (question_first1s == 0);
                do
                {
                    question_sec1s = GetNewRandomNum(1, 10, question_first1s);
                } while (question_first1s + question_sec1s < 10);

                old_firstNum1s = question_first1s;
                old_secNum1s = question_sec1s;
            }
            else
            {
                question_first1s = 0;
                do
                {
                    int temp = rnd.Next(0, 10);
                    if (arr[temp] != 0)
                    {
                        question_first1s = arr[temp];
                        arr[temp] = 0;
                    }
                } while (question_first1s == 0);

                question_sec1s = GetLimitedRandomNum(question_first1s);

                old_firstNum1s = question_first1s;
                old_secNum1s = question_sec1s;
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
            Label_RightOrWrong.IsVisible = false;
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
            if (accessible == true)
            {
                ResultData.Instance.inputSum = Int32.Parse(AnswerButton1.Text);
                AnswerButton1.BorderColor = Color.Red;
                AnswerButton2.BorderColor = Color.White;
                AnswerButton3.BorderColor = Color.White;
                AnswerButton4.BorderColor = Color.White;
                AnswerButton1.BorderWidth = 5;

                Label_SelectedAnswer.Text = AnswerButton1.Text;
                ConfirmResultPrint(ResultData.Instance.inputSum, ResultData.Instance.rightSum);
            }

        }
        private void AnswerButton2_Clicked(object sender, EventArgs e)
        {
            if (accessible == true)
            {
                ResultData.Instance.inputSum = Int32.Parse(AnswerButton2.Text);
                AnswerButton1.BorderColor = Color.White;
                AnswerButton2.BorderColor = Color.Red;
                AnswerButton3.BorderColor = Color.White;
                AnswerButton4.BorderColor = Color.White;
                AnswerButton2.BorderWidth = 5;

                Label_SelectedAnswer.Text = AnswerButton2.Text;
                ConfirmResultPrint(ResultData.Instance.inputSum, ResultData.Instance.rightSum);
            }
        }
        private void AnswerButton3_Clicked(object sender, EventArgs e)
        {
            if (accessible == true)
            {
                ResultData.Instance.inputSum = Int32.Parse(AnswerButton3.Text);
                AnswerButton1.BorderColor = Color.White;
                AnswerButton2.BorderColor = Color.White;
                AnswerButton3.BorderColor = Color.Red;
                AnswerButton4.BorderColor = Color.White;
                AnswerButton3.BorderWidth = 5;

                Label_SelectedAnswer.Text = AnswerButton3.Text;
                ConfirmResultPrint(ResultData.Instance.inputSum, ResultData.Instance.rightSum);
            }
        }
        private void AnswerButton4_Clicked(object sender, EventArgs e)
        {
            if (accessible == true)
            {
                ResultData.Instance.inputSum = Int32.Parse(AnswerButton4.Text);
                AnswerButton1.BorderColor = Color.White;
                AnswerButton2.BorderColor = Color.White;
                AnswerButton3.BorderColor = Color.White;
                AnswerButton4.BorderColor = Color.Red;
                AnswerButton4.BorderWidth = 5;

                Label_SelectedAnswer.Text = AnswerButton4.Text;

                ConfirmResultPrint(ResultData.Instance.inputSum, ResultData.Instance.rightSum);
            }
        }

        private void PlayRightMusic()
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("Sounds/Right.wav");
            player.Play();
        }

        private void PlayWrongMusic()
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("Sounds/Wrong.wav");
            player.Play();
        }

        public async void ConfirmResultPrint(int inputAnswer, int rightAnswer)
        {
            try
            {
                if (accessible == true)
                {
                    accessible = false;

                    await Label_RightOrWrong.FadeTo(1, 1, Easing.Linear);
                    if (inputAnswer == rightAnswer)
                    {
                        // 정답 출력
                        // 다음 문제
                        Label_RightOrWrong.Text = "○";
                        Label_RightOrWrong.TextColor = Color.Blue;
                        Label_RightOrWrong.IsVisible = true;
                        PlayRightMusic();
                        await Label_RightOrWrong.FadeTo(0, 1500, Easing.SinOut);

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

                            await ShowMessage(LearnSetSington.Instance.setStage.ToString() + "단계 끝", "참 잘했어요!", "확인", stage_finish);
                           
                            //await Navigation.PopAsync();
                        }
                    }
                    else
                    {
                        // 땡 출력
                        // 같은 문제
                        Label_RightOrWrong.Text = "X";
                        Label_RightOrWrong.TextColor = Color.Red;
                        Label_RightOrWrong.IsVisible = true;
                        PlayWrongMusic();
                        await Label_RightOrWrong.FadeTo(0, 2000, Easing.SinOut);

                        Label_SelectedAnswer.Text = "?";
                        Init_AnswerButton();
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

        private int ConvertThreeFigure(int _100s, int _10s, int _1s)
        {
            int total = 0;

            total = (_100s * 100) + (_10s * 10) + _1s;

            return total;
        }
        private async void stage_finish()
        {
            await Navigation.PopAsync();
        }

        public async Task ShowMessage(string message,
            string title,
            string buttonText,
            Action afterHideCallback)
        {
            await DisplayAlert(
                title,
                message,
                buttonText);

            afterHideCallback?.Invoke();
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

                           // await DisplayAlert(LearnSetSington.Instance.setStage.ToString() + "단계 끝", "참 잘했어요!", "확인");

                            await ShowMessage(LearnSetSington.Instance.setStage.ToString() + "단계 끝", "참 잘했어요!", "확인", async () =>
                            {
                                await ShowMessage("OK was pressed", "Message", "OK", stage_finish);
                            });

                            //stage_finish();
                            
                            //await Navigation.PopAsync();
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