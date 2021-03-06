﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using forms_plus.ViewModel;

namespace forms_plus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LearnningPage : ContentPage
    {
        private int sum1000s = 0, sum100s = 0, sum10s = 0, sum1s = 0, totalSum = 0;
        private int up100s = 0, up10s = 0;

        private int iuputSum1000s = 0, iuputSum100s = 0, iuputSum10s = 0, iuputSum1s = 0, iuputTotalSum = 0;
        private int inputUp100s = 0, inputUp10s = 0;

        private int PassQuestionNum = 1;
        private bool btn1000s_flag = false;
        private bool btn100s_flag = false;
        private bool btn10s_flag = false;
        private bool btn1s_flag = false;
        private bool btnUp100s_flag = false;
        private bool btnUp10s_flag = false;

        private int old_firstNum100s = 0, old_firstNum10s = 0, old_firstNum1s = 0;
        private int old_secNum100s = 0, old_secNum10s = 0, old_secNum1s = 0;

        private bool accessible = true;


        public LearnningPage()
        {
            InitializeComponent();
            accessible = true;
            //BindingContext = this;
            this.BindingContext = new FontSizeViewModel();
            DrawLayout();
            Init_Question();
            MakeQuestion();
        }
      
        private void Btn1000s_Clicked(object sender, EventArgs e)
        {
            PlayTinyBtnMusic();
            btn1000s_flag = true;
            btn100s_flag = false;
            btn10s_flag = false;
            btn1s_flag = false;
            btnUp100s_flag = false;
            btnUp10s_flag = false;

            Btn1000s.TextColor = Color.Red;
            Btn100s.TextColor = Color.White;
            Btn10s.TextColor = Color.White;
            Btn1s.TextColor = Color.White;
            Btn_Up100s.TextColor = Color.White;
            Btn_Up10s.TextColor = Color.White;
         
        }
        private void Btn100s_Clicked(object sender, EventArgs e)
        {
            PlayTinyBtnMusic();
            btn1000s_flag = false;
            btn100s_flag = true;
            btn10s_flag = false;
            btn1s_flag = false;
            btnUp100s_flag = false;
            btnUp10s_flag = false;

            Btn1000s.TextColor = Color.White;
            Btn100s.TextColor = Color.Red;
            Btn10s.TextColor = Color.White;
            Btn1s.TextColor = Color.White;
            Btn_Up100s.TextColor = Color.White;
            Btn_Up10s.TextColor = Color.White;

        }
        private void Btn10s_Clicked(object sender, EventArgs e)
        {
            PlayTinyBtnMusic();
            btn1000s_flag = false;
            btn100s_flag = false;
            btn10s_flag = true;
            btn1s_flag = false;
            btnUp100s_flag = false;
            btnUp10s_flag = false;

            Btn1000s.TextColor = Color.White;
            Btn100s.TextColor = Color.White;
            Btn10s.TextColor = Color.Red;
            Btn1s.TextColor = Color.White;
            Btn_Up100s.TextColor = Color.White;
            Btn_Up10s.TextColor = Color.White;

        }
        private void Btn1s_Clicked(object sender, EventArgs e)
        {
            PlayTinyBtnMusic();
            btn1000s_flag = false;
            btn100s_flag = false;
            btn10s_flag = false;
            btn1s_flag = true;
            btnUp100s_flag = false;
            btnUp10s_flag = false;

            Btn1000s.TextColor = Color.White;
            Btn100s.TextColor = Color.White;
            Btn10s.TextColor = Color.White;
            Btn1s.TextColor = Color.Red;
            Btn_Up100s.TextColor = Color.White;
            Btn_Up10s.TextColor = Color.White;

        }
        private void BtnUp100s_Clicked(object sender, EventArgs e)
        {
            PlayTinyBtnMusic();
            btn1000s_flag = false;
            btn100s_flag = false;
            btn10s_flag = false;
            btn1s_flag = false;
            btnUp100s_flag = true;
            btnUp10s_flag = false;

            Btn1000s.TextColor = Color.White;
            Btn100s.TextColor = Color.White;
            Btn10s.TextColor = Color.White;
            Btn1s.TextColor = Color.White;
            Btn_Up100s.TextColor = Color.Red;
            Btn_Up10s.TextColor = Color.White;

        }
        private void BtnUp10s_Clicked(object sender, EventArgs e)
        {
            PlayTinyBtnMusic();
            btn1000s_flag = false;
            btn100s_flag = false;
            btn10s_flag = false;
            btn1s_flag = false;
            btnUp100s_flag = false;
            btnUp10s_flag = true;

            Btn1000s.TextColor = Color.White;
            Btn100s.TextColor = Color.White;
            Btn10s.TextColor = Color.White;
            Btn1s.TextColor = Color.White;
            Btn_Up100s.TextColor = Color.White;
            Btn_Up10s.TextColor = Color.Red;

        }

        private int ConvertThreeFigure(int _100s, int _10s, int _1s)
        {
            int total = 0;

            total = (_100s * 100) + (_10s * 10) + _1s;

            return total;
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

        private void PlayTinyBtnMusic()
        {
            var player = Plugin.SimpleAudioPlayer.CrossSimpleAudioPlayer.Current;
            player.Load("Sounds/TinyBtn.mp3");
            player.Play();
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
                    ResultData.Instance.inputSum = 0;

                    if (((Btn1000s.IsVisible == true) && (Btn1000s.Text == "?"))
                       || ((Btn100s.IsVisible == true) && (Btn100s.Text == "?"))
                       || ((Btn10s.IsVisible == true) && (Btn10s.Text == "?"))
                       || ((Btn1s.IsVisible == true) && (Btn1s.Text == "?"))
                       || ((Btn_Up100s.IsVisible == true) && (Btn_Up100s.Text == "?"))
                       || ((Btn_Up10s.IsVisible == true) && (Btn_Up10s.Text == "?"))
                        )
                    {
                        await DisplayAlert("알림", "숫자를 모두 입력해주세요!", "확인");
                    }
                    else
                    {
                        if (Btn1000s.IsVisible == true)
                        {
                            ResultData.Instance.input1000s = Int32.Parse(Btn1000s.Text);
                            ResultData.Instance.inputSum += (ResultData.Instance.input1000s * 1000);
                        }
                        else
                        {
                            ResultData.Instance.input1000s = -1;
                        }

                        if (Btn100s.IsVisible == true)
                        {
                            ResultData.Instance.input100s = Int32.Parse(Btn100s.Text);
                            ResultData.Instance.inputSum += (ResultData.Instance.input100s * 100);
                        }
                        else
                        {
                            ResultData.Instance.input100s = -1;
                        }

                        if (Btn10s.IsVisible == true)
                        {
                            ResultData.Instance.input10s = Int32.Parse(Btn10s.Text);
                            ResultData.Instance.inputSum += (ResultData.Instance.input10s * 10);
                        }
                        else
                        {
                            ResultData.Instance.input10s = -1;
                        }

                        if (Btn1s.IsVisible == true)
                        {
                            ResultData.Instance.input1s = Int32.Parse(Btn1s.Text);
                            ResultData.Instance.inputSum += (ResultData.Instance.input1s);
                        }
                        else
                        {
                            ResultData.Instance.input1s = -1;
                        }

                        if (Btn_Up100s.IsVisible == true)
                        {
                            ResultData.Instance.inputUp100s = Int32.Parse(Btn_Up100s.Text);
                        }
                        else
                        {
                            //ResultData.Instance.inputUp100s = -1;
                            ResultData.Instance.inputUp100s = 0;
                        }

                        if (Btn_Up10s.IsVisible == true)
                        {
                            ResultData.Instance.inputUp10s = Int32.Parse(Btn_Up10s.Text);
                        }
                        else
                        {
                            //ResultData.Instance.inputUp10s = -1;
                            ResultData.Instance.inputUp100s = 0;
                        }

                        ResultData.Instance.rightAnswer1000s = sum1000s;
                        ResultData.Instance.rightAnswer100s = sum100s;
                        ResultData.Instance.rightAnswer10s = sum10s;
                        ResultData.Instance.rightAnswer1s = sum1s;
                        ResultData.Instance.rightAnswerUp100s = up100s;
                        ResultData.Instance.rightAnswerUp10s = up10s;

                        ResultData.Instance.rightSum = (sum1000s * 1000) + (sum100s * 100) + (sum10s * 10) + sum1s;


                        AnswerSheetsData.Instance.SetAnswerSheetsData(
                                                                    ConvertThreeFigure(ResultData.Instance.question_first100s, ResultData.Instance.question_first10s, ResultData.Instance.question_first1s),
                                                                    ConvertThreeFigure(ResultData.Instance.question_sec100s, ResultData.Instance.question_sec10s, ResultData.Instance.question_sec1s),
                                                                    ConvertThreeFigure(0, ResultData.Instance.rightAnswerUp100s, ResultData.Instance.rightAnswerUp10s),
                                                                    ResultData.Instance.rightSum,
                                                                    ConvertThreeFigure(0, ResultData.Instance.inputUp100s, ResultData.Instance.inputUp10s),
                                                                    ResultData.Instance.inputSum,
                                                                    1);

                        AnswerSheetsData.Instance.DetailPageIndex = 1;

                        if ((ResultData.Instance.rightSum == ResultData.Instance.inputSum)
                           // && (ResultData.Instance.rightAnswerUp100s == ResultData.Instance.inputUp100s)
                           // && (ResultData.Instance.rightAnswerUp10s == ResultData.Instance.inputUp10s)
                           )
                        {
                            PlayRightMusic();
                        }
                        else
                        {
                            PlayWrongMusic();
                        }


                        await Navigation.PushModalAsync(new AnswerSheetsDetailPage());

                        //await Navigation.PushModalAsync(new LearnResultPage());

                      

                        Init_Question();
                        if (PassQuestionNum < LearnSetSington.Instance.setQ_Num)
                        {
                            PassQuestionNum++;
                            MakeQuestion();
                        }
                        else
                        {
                            String Date = StringDate.Instance.DateYMD_to_String(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);

                            App.CalLearnInfoDatabase.SaveCalendarLearnInfo(UserInfo.Instance.userName,
                                                                              LearnSetSington.Instance.setStage,
                                                                              Date,
                                                                              true);

                            await ShowMessage(LearnSetSington.Instance.setStage.ToString() + "단계 끝", "참 잘했어요!", "확인", stage_finish);
                            //await DisplayAlert("멋져요", LearnSetSington.Instance.setStage.ToString()+"단계 성공!!", "확인");
                            //await Navigation.PopAsync();
                        }
                    }

                    accessible = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                accessible = true;
            }
        }

        private  void AnswerButton_Clicked(object sender, EventArgs e)
        {
            Button Param = sender as Button;
            string getText;
            int getValue = 0;

            PlayTinyBtnMusic();

            getText = Param.Text.ToString();
            getValue = Convert.ToInt32(getText);

            if (btn1s_flag == true)
            {
                iuputSum1s = getValue;
                Btn1s.Text = getText;
                Btn1s.TextColor = Color.White;
                btn1s_flag = false;

                if ((LearnSetSington.Instance.setUpDispOnOff == true) && (LearnSetSington.Instance.setNdigit != 1))
                {
                    btnUp10s_flag = true;
                    Btn_Up10s.TextColor = Color.Red;
                }
                else
                {
                    btn10s_flag = true;
                    Btn10s.TextColor = Color.Red;
                }

            }
            else if (btn10s_flag == true)
            {
                iuputSum10s = getValue;
                Btn10s.Text = getText;
                Btn10s.TextColor = Color.White;
                btn10s_flag = false;

                if (LearnSetSington.Instance.setUpDispOnOff == true && (LearnSetSington.Instance.setNdigit == 3))
                {
                    btnUp100s_flag = true;
                    Btn_Up100s.TextColor = Color.Red;
                }
                else
                {
                    btn100s_flag = true;
                    Btn100s.TextColor = Color.Red;
                }
            }
            else if (btn100s_flag == true)
            {
                iuputSum100s = getValue;
                Btn100s.Text = getText;
                Btn100s.TextColor = Color.White;
                btn100s_flag = false;

                btn1000s_flag = true;
                Btn1000s.TextColor = Color.Red;
            }
            else if (btn1000s_flag == true)
            {
                iuputSum1000s = getValue;
                Btn1000s.Text = getText;
                Btn1000s.TextColor = Color.White;
                btn1000s_flag = false;
            }
            else if (btnUp100s_flag == true)
            {
                inputUp100s = getValue;
                Btn_Up100s.Text = getText;
                Btn_Up100s.TextColor = Color.White;
                btnUp100s_flag = false;

                btn100s_flag = true;
                Btn100s.TextColor = Color.Red;
            }
            else if (btnUp10s_flag == true)
            {
                inputUp10s = getValue;
                Btn_Up10s.Text = getText;
                Btn_Up10s.TextColor = Color.White;
                btnUp10s_flag = false;

                btn10s_flag = true;
                Btn10s.TextColor = Color.Red;
            }
            else
            {
                /* do nothing */
            }

        }

        private void Init_Question()
        {
            btn1000s_flag = false;
            btn100s_flag = false;
            btn10s_flag = false;
            btn1s_flag = true;
            btnUp100s_flag = false;
            btnUp10s_flag = false;

            Btn1000s.TextColor = Color.White;
            Btn100s.TextColor = Color.White;
            Btn10s.TextColor = Color.White;
            Btn1s.TextColor = Color.Red;
            Btn_Up100s.TextColor = Color.White;
            Btn_Up10s.TextColor = Color.White;

            Btn1000s.Text = "?";
            Btn100s.Text = "?";
            Btn10s.Text = "?";
            Btn1s.Text = "?";
            Btn_Up100s.Text = "?";
            Btn_Up10s.Text = "?";


            sum1000s = 0;
            sum100s = 0;
            sum10s = 0;
            sum1s = 0;
            up100s = 0;
            up10s = 0;
            totalSum = 0;

            iuputSum1000s = 0;
            iuputSum100s = 0;
            iuputSum10s = 0;
            iuputSum1s = 0;
            iuputTotalSum = 0;
            inputUp100s = 0; 
            inputUp10s = 0;
    }
        private bool Check_finish()
        {
            bool ret = false;
            
            iuputTotalSum = (iuputSum1000s * 1000) + (iuputSum100s * 100) + (iuputSum10s * 10) + iuputSum1s;

            if (iuputTotalSum == totalSum)
            {
                if (LearnSetSington.Instance.setUpDispOnOff == true)
                {
                    if ((inputUp100s == up100s) && (inputUp10s == up10s))
                    {
                        
                        Init_Question();

                        if (PassQuestionNum < LearnSetSington.Instance.setQ_Num)
                        {
                            PassQuestionNum++;
                            MakeQuestion();
                        }
                        else
                        {
                            ret = true;
                        }
                    }
                    else
                    {

                    }
                }
                else
                {
                    
                    Init_Question();

                    if (PassQuestionNum < LearnSetSington.Instance.setQ_Num)
                    {
                        PassQuestionNum++;
                        MakeQuestion();
                    }
                    else
                    {
                        ret = true;
                    }
                }                
            }
            else             
            { 
            
            }

            return ret;
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
        private void MakeQuestion()
        {
            Random rnd = new Random();
            int firstNum100s, firstNum10s, firstNum1s;
            int secNum100s, secNum10s, secNum1s;

            Label_PassQNUM.Text = Convert.ToString(PassQuestionNum);
            Label_TotalQNUM.Text = Convert.ToString(LearnSetSington.Instance.setQ_Num);

            switch (LearnSetSington.Instance.setNdigit)
            {
                case 1:
                    if (LearnSetSington.Instance.setUpONOFF == true)
                    {
                        do
                        {
                            firstNum1s = GetNewRandomNum(1, 10, old_firstNum1s);
                            secNum1s = GetNewRandomNum(1, 10, old_secNum1s);
                        } while (firstNum1s + secNum1s < 10);
                        old_firstNum1s = firstNum1s;
                        old_secNum1s = secNum1s;
                    }
                    else
                    {
                        firstNum1s = GetNewRandomNum(1, 9, old_firstNum1s);
                        secNum1s = GetLimitedRandomNum(firstNum1s);

                        if ((firstNum1s+ secNum1s) == (old_firstNum1s + old_secNum1s))
                        {
                            secNum1s = GetNewRandomNum(1, 9, old_firstNum1s);
                            firstNum1s = GetLimitedRandomNum(secNum1s);
                        }
                        old_firstNum1s = firstNum1s;
                        old_secNum1s = secNum1s;
                    }
                    Label_FirstNum1s.Text = Convert.ToString(firstNum1s);
                    Label_SecNum1s.Text = Convert.ToString(secNum1s);
                    ResultData.Instance.question_first1s = firstNum1s;
                    ResultData.Instance.question_sec1s = secNum1s;
                    sum1s = firstNum1s + secNum1s;
                    if (sum1s >= 10)
                    {
                        sum10s = 1;
                        sum1s -= 10;
                    }
                    else
                    {
                        sum10s = 0;                        
                    }
                    break;

                case 2:
                    if (LearnSetSington.Instance.setUpONOFF == true)
                    {
                        firstNum10s = GetNewRandomNum(1, 10, old_firstNum10s);
                        secNum10s = GetNewRandomNum(1, 10, old_secNum10s);
                        firstNum1s = GetNewRandomNum(1, 10, old_firstNum1s);
                        secNum1s = GetNewRandomNum(1, 10, old_secNum1s);

                        old_firstNum10s = firstNum10s;
                        old_secNum10s = secNum10s;
                        old_firstNum1s = firstNum1s;
                        old_secNum1s = secNum1s;
                    }
                    else
                    {
                        firstNum10s = GetNewRandomNum(1, 9, old_firstNum10s);
                        secNum10s = GetLimitedRandomNum(firstNum10s);
                        firstNum1s = GetNewRandomNum(1, 9, old_firstNum1s);
                        secNum1s = GetLimitedRandomNum(firstNum1s);

                        old_firstNum10s = firstNum10s;
                        old_secNum10s = secNum10s;
                        old_firstNum1s = firstNum1s;
                        old_secNum1s = secNum1s;
                    }

                    Label_FirstNum10s.Text = Convert.ToString(firstNum10s);
                    Label_SecNum10s.Text = Convert.ToString(secNum10s);
                    Label_FirstNum1s.Text = Convert.ToString(firstNum1s);
                    Label_SecNum1s.Text = Convert.ToString(secNum1s);
                    ResultData.Instance.question_first10s = firstNum10s;
                    ResultData.Instance.question_sec10s = secNum10s;
                    ResultData.Instance.question_first1s = firstNum1s;
                    ResultData.Instance.question_sec1s = secNum1s;
                    sum1s = firstNum1s + secNum1s;
                    if (sum1s >= 10)
                    {
                        up10s = 1;                        
                        sum1s -= 10;
                    }
                    else 
                    {
                        up10s = 0;                                                
                    }                    
                   
                    sum10s = up10s + firstNum10s + secNum10s;
                    if (sum10s >= 10)
                    {
                        sum100s = 1;
                        sum10s -= 10;
                    }
                    else 
                    {
                        up100s = 0;                    
                    }                    
                    break;

                case 3:
                    if (LearnSetSington.Instance.setUpONOFF == true)
                    {
                        firstNum100s = GetNewRandomNum(1, 10, old_firstNum100s);
                        secNum100s = GetNewRandomNum(1, 10, old_secNum100s);
                        firstNum10s = GetNewRandomNum(1, 10, old_firstNum10s);
                        secNum10s = GetNewRandomNum(1, 10, old_secNum10s);
                        firstNum1s = GetNewRandomNum(1, 10, old_firstNum1s);
                        secNum1s = GetNewRandomNum(1, 10, old_secNum1s);

                        old_firstNum100s = firstNum100s;
                        old_secNum100s = secNum100s;
                        old_firstNum10s = firstNum10s;
                        old_secNum10s = secNum10s;
                        old_firstNum1s = firstNum1s;
                        old_secNum1s = secNum1s;
                    }
                    else
                    {
                        firstNum100s = GetNewRandomNum(1, 9, old_firstNum100s);
                        secNum100s = GetLimitedRandomNum(firstNum100s);
                        firstNum10s = GetNewRandomNum(1, 9, old_firstNum10s);
                        secNum10s = GetLimitedRandomNum(firstNum10s);
                        firstNum1s = GetNewRandomNum(1, 9, old_firstNum1s);
                        secNum1s = GetLimitedRandomNum(firstNum1s);

                        old_firstNum100s = firstNum100s;
                        old_secNum100s = secNum100s;
                        old_firstNum10s = firstNum10s;
                        old_secNum10s = secNum10s;
                        old_firstNum1s = firstNum1s;
                        old_secNum1s = secNum1s;
                    }

                    Label_FirstNum100s.Text = Convert.ToString(firstNum100s);
                    Label_SecNum100s.Text = Convert.ToString(secNum100s);
                    Label_FirstNum10s.Text = Convert.ToString(firstNum10s);
                    Label_SecNum10s.Text = Convert.ToString(secNum10s);
                    Label_FirstNum1s.Text = Convert.ToString(firstNum1s);
                    Label_SecNum1s.Text = Convert.ToString(secNum1s);
                    ResultData.Instance.question_first100s = firstNum100s;
                    ResultData.Instance.question_sec100s = secNum100s;
                    ResultData.Instance.question_first10s = firstNum10s;
                    ResultData.Instance.question_sec10s = secNum10s;
                    ResultData.Instance.question_first1s = firstNum1s;
                    ResultData.Instance.question_sec1s = secNum1s;
                    sum1s = firstNum1s + secNum1s;

                    if (sum1s >= 10)
                    {
                        up10s = 1;
                        sum1s -= 10;
                    }
                    else
                    {
                        up10s = 0;                        
                    }

                    sum10s = up10s + firstNum10s + secNum10s;
                    if (sum10s >= 10)
                    {
                        up100s = 1;
                        sum10s -= 10;
                    }
                    else
                    {
                        up100s = 0;
                    }

                    sum100s = up100s + firstNum100s + secNum100s;
                    if (sum100s >= 10)
                    {
                        sum1000s = 1;
                        sum100s -= 10;
                    }
                    else
                    {
                        sum1000s = 0;
                    }
                    break;

                default:
                    break;
            }

            totalSum = (sum1000s * 1000) + (sum100s * 100) + (sum10s * 10) + sum1s;

            Btn1000s.IsVisible = true;
            Btn100s.IsVisible = true;
            Btn10s.IsVisible = true;
            Btn1s.IsVisible = true;

            if (totalSum < 10)
            {
                Btn1000s.IsVisible = false;
                Btn100s.IsVisible = false;
                Btn10s.IsVisible = false;
            }
            else if (totalSum < 100)
            {
                Btn1000s.IsVisible = false;
                Btn100s.IsVisible = false;
            }
            else if (totalSum < 1000)
            {
                Btn1000s.IsVisible = false;
            }
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
                    Btn_Up100s.IsVisible = false;
                    Btn_Up10s.IsVisible = false;
                    Btn1000s.IsVisible = false;
                    Btn100s.IsVisible = false;

                    Btn_Up100s.Text = "";
                    Btn_Up10s.Text = "";
                    Btn1000s.Text = "";
                    Btn100s.Text = "";
                    break;
                case 2:
                    Label_FirstNum100s.IsVisible = false;                    
                    Label_SecNum100s.IsVisible = false;
                    if (LearnSetSington.Instance.setUpDispOnOff == false)
                    {
                        Btn_Up100s.IsVisible = false;
                        Btn_Up10s.IsVisible = false;

                        Btn_Up100s.Text = "";
                        Btn_Up10s.Text = "";
                    }
                    else 
                    {
                        Btn_Up100s.IsVisible = false;
                        Btn_Up100s.Text = "";
                    }
                    Btn1000s.IsVisible = false;                    
                    Btn1000s.Text = "";                    
                    break;
                case 3:
                    if (LearnSetSington.Instance.setUpDispOnOff == false)
                    {
                        Btn_Up100s.IsVisible = false;
                        Btn_Up10s.IsVisible = false;
                        Btn_Up100s.Text = "";
                        Btn_Up10s.Text = "";
                    }                    
                    break;
                default:
                    break;
            }
        }
      
    }
}