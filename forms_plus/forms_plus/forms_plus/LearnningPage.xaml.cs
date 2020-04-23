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


        public LearnningPage()
        {
            InitializeComponent();
            DrawLayout();
            Init_Question();
            MakeQuestion();
        }
        private void Btn1000s_Clicked(object sender, EventArgs e)
        {
            btn1000s_flag = true;
            btn100s_flag = false;
            btn10s_flag = false;
            btn1s_flag = false;
            btnUp100s_flag = false;
            btnUp10s_flag = false;

            Btn1000s.TextColor = Color.Red;
            Btn100s.TextColor = Color.Black;
            Btn10s.TextColor = Color.Black;
            Btn1s.TextColor = Color.Black;
            Btn_Up100s.TextColor = Color.Black;
            Btn_Up10s.TextColor = Color.Black;
        }
        private void Btn100s_Clicked(object sender, EventArgs e)
        {
            btn1000s_flag = false;
            btn100s_flag = true;
            btn10s_flag = false;
            btn1s_flag = false;
            btnUp100s_flag = false;
            btnUp10s_flag = false;

            Btn1000s.TextColor = Color.Black;
            Btn100s.TextColor = Color.Red;
            Btn10s.TextColor = Color.Black;
            Btn1s.TextColor = Color.Black;
            Btn_Up100s.TextColor = Color.Black;
            Btn_Up10s.TextColor = Color.Black;
        }
        private void Btn10s_Clicked(object sender, EventArgs e)
        {
            btn1000s_flag = false;
            btn100s_flag = false;
            btn10s_flag = true;
            btn1s_flag = false;
            btnUp100s_flag = false;
            btnUp10s_flag = false;

            Btn1000s.TextColor = Color.Black;
            Btn100s.TextColor = Color.Black;
            Btn10s.TextColor = Color.Red;
            Btn1s.TextColor = Color.Black;
            Btn_Up100s.TextColor = Color.Black;
            Btn_Up10s.TextColor = Color.Black;
        }
        private void Btn1s_Clicked(object sender, EventArgs e)
        {
            btn1000s_flag = false;
            btn100s_flag = false;
            btn10s_flag = false;
            btn1s_flag = true;
            btnUp100s_flag = false;
            btnUp10s_flag = false;

            Btn1000s.TextColor = Color.Black;
            Btn100s.TextColor = Color.Black;
            Btn10s.TextColor = Color.Black;
            Btn1s.TextColor = Color.Red;
            Btn_Up100s.TextColor = Color.Black;
            Btn_Up10s.TextColor = Color.Black;
        }
        private void BtnUp100s_Clicked(object sender, EventArgs e)
        {
            btn1000s_flag = false;
            btn100s_flag = false;
            btn10s_flag = false;
            btn1s_flag = false;
            btnUp100s_flag = true;
            btnUp10s_flag = false;

            Btn1000s.TextColor = Color.Black;
            Btn100s.TextColor = Color.Black;
            Btn10s.TextColor = Color.Black;
            Btn1s.TextColor = Color.Black;
            Btn_Up100s.TextColor = Color.Red;
            Btn_Up10s.TextColor = Color.Black;
        }
        private void BtnUp10s_Clicked(object sender, EventArgs e)
        {
            btn1000s_flag = false;
            btn100s_flag = false;
            btn10s_flag = false;
            btn1s_flag = false;
            btnUp100s_flag = false;
            btnUp10s_flag = true;

            Btn1000s.TextColor = Color.Black;
            Btn100s.TextColor = Color.Black;
            Btn10s.TextColor = Color.Black;
            Btn1s.TextColor = Color.Black;
            Btn_Up100s.TextColor = Color.Black;
            Btn_Up10s.TextColor = Color.Red;
        }

        private async void Result_Clicked(object sender, EventArgs e)
        {
            ResultData.Instance.inputSum = 0;

            if (((Btn1000s.IsVisible == true) && (Btn1000s.Text == "?"))
               || ((Btn100s.IsVisible == true) && (Btn100s.Text == "?"))
               || ((Btn10s.IsVisible == true) && (Btn10s.Text == "?"))
               || ((Btn1s.IsVisible == true) && (Btn1s.Text == "?"))
               || ((Btn_Up100s.IsVisible == true) && (Btn_Up100s.Text == "?"))
               || ((Btn_Up10s.IsVisible == true) && (Btn_Up10s.Text == "?"))
                )
            {
                await DisplayAlert("알림","숫자를 모두 입력해주세요!","확인");
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
                    ResultData.Instance.inputUp100s = -1;
                }

                if (Btn_Up10s.IsVisible == true)
                {
                    ResultData.Instance.inputUp10s = Int32.Parse(Btn_Up10s.Text);
                }
                else
                {
                    ResultData.Instance.inputUp10s = -1;
                }

                ResultData.Instance.rightAnswer1000s = sum1000s;
                ResultData.Instance.rightAnswer100s = sum100s;
                ResultData.Instance.rightAnswer10s = sum10s;
                ResultData.Instance.rightAnswer1s = sum1s;
                ResultData.Instance.rightAnswerUp100s = up100s;
                ResultData.Instance.rightAnswerUp10s = up10s;

                ResultData.Instance.rightSum = (sum1000s * 1000) + (sum100s*100) + (sum10s*10) + sum1s;

                await Navigation.PushModalAsync(new LearnResultPage());

                Init_Question();
                if (PassQuestionNum < LearnSetSington.Instance.setQ_Num)
                {
                    PassQuestionNum++;
                    MakeQuestion();
                }
                else 
                {
                    await Navigation.PopAsync();
                }
            }
        }

        private  void AnswerButton_Clicked(object sender, EventArgs e)
        {
            Button Param = sender as Button;
            string getText;
            int getValue = 0;            

            getText = Param.Text.ToString();
            getValue = Convert.ToInt32(getText);

            if (btn1s_flag == true)
            {
                iuputSum1s = getValue;
                Btn1s.Text = getText;
                Btn1s.TextColor = Color.White;
                btn1s_flag = false;

                btn10s_flag = true;
                Btn10s.TextColor = Color.Red;

            }
            else if (btn10s_flag == true)
            {
                iuputSum10s = getValue;
                Btn10s.Text = getText;
                Btn10s.TextColor = Color.White;
                btn10s_flag = false;

                btn100s_flag = true;
                Btn100s.TextColor = Color.Red;
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
            }
            else if (btnUp10s_flag == true)
            {
                inputUp10s = getValue;
                Btn_Up10s.Text = getText;
                Btn_Up10s.TextColor = Color.White;
                btnUp10s_flag = false;
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
                        firstNum1s = rnd.Next(1, 10);
                        secNum1s = rnd.Next(1, 10);
                    }
                    else
                    {
                        firstNum1s = rnd.Next(1, 9);
                        secNum1s = GetLimitedRandomNum(firstNum1s);
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
                        firstNum10s = rnd.Next(1, 10);
                        secNum10s = rnd.Next(1, 10);
                        firstNum1s = rnd.Next(1, 10);
                        secNum1s = rnd.Next(1, 10);
                    }
                    else 
                    {
                        firstNum10s = rnd.Next(1, 9);
                        secNum10s = GetLimitedRandomNum(firstNum10s);
                        firstNum1s = rnd.Next(1, 9);
                        secNum1s = GetLimitedRandomNum(firstNum1s);
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
                        firstNum100s = rnd.Next(1, 10);
                        secNum100s = rnd.Next(1, 10);
                        firstNum10s = rnd.Next(1, 10);
                        secNum10s = rnd.Next(1, 10);
                        firstNum1s = rnd.Next(1, 10);
                        secNum1s = rnd.Next(1, 10);
                    }
                    else
                    {
                        firstNum100s = rnd.Next(1, 9);
                        secNum100s = GetLimitedRandomNum(firstNum100s);
                        firstNum10s = rnd.Next(1, 9);
                        secNum10s = GetLimitedRandomNum(firstNum10s);
                        firstNum1s = rnd.Next(1, 9);
                        secNum1s = GetLimitedRandomNum(firstNum1s);
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