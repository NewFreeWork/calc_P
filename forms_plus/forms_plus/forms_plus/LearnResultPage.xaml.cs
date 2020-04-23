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
    public partial class LearnResultPage : ContentPage
    {
        public LearnResultPage()
        {
            InitializeComponent();

            DrawLayout();
            DrawResult();
        }

        private async void Next_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopModalAsync();
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
                    Label_1000s.IsVisible = false;
                    Label_100s.IsVisible = false;
                    break;
                case 2:
                    Label_FirstNum100s.IsVisible = false;                   
                    Label_SecNum100s.IsVisible = false;

                    if (LearnSetSington.Instance.setUpONOFF == false)
                    {
                        Label_Up100s.IsVisible = false;
                        Label_Up10s.IsVisible = false;
                    }
                    else 
                    {
                        Label_Up100s.IsVisible = false;                        
                    }                  
                 
                    Label_1000s.IsVisible = false;                    
                    break;

                case 3:
                    if (LearnSetSington.Instance.setUpONOFF == false)
                    {
                        Label_Up100s.IsVisible = false;
                        Label_Up10s.IsVisible = false;
                    }
                    break;
                default:
                    break;
            }
        }

        private void DrawResult()
        {
            int input_value_1000s = ResultData.Instance.input1000s;
            int input_value_100s = ResultData.Instance.input100s;
            int input_value_10s = ResultData.Instance.input10s;
            int input_value_1s = ResultData.Instance.input1s;
            int input_value_Up100s = ResultData.Instance.inputUp100s;
            int input_value_Up10s = ResultData.Instance.inputUp10s;

            int right_value_1000s   = ResultData.Instance.rightAnswer1000s;
            int right_value_100s    = ResultData.Instance.rightAnswer100s;
            int right_value_10s     = ResultData.Instance.rightAnswer10s;
            int right_value_1s      = ResultData.Instance.rightAnswer1s;
            int right_value_Up100s  = ResultData.Instance.rightAnswerUp100s;
            int right_value_Up10s   = ResultData.Instance.rightAnswerUp10s;

            int question_first100s = ResultData.Instance.question_first100s;
            int question_first10s = ResultData.Instance.question_first10s;
            int question_first1s = ResultData.Instance.question_first1s;
            int question_sec100s = ResultData.Instance.question_sec100s;
            int question_sec10s = ResultData.Instance.question_sec10s;
            int question_sec1s = ResultData.Instance.question_sec1s;

            int input_sum = ResultData.Instance.inputSum;
            int right_sum = ResultData.Instance.rightSum;

            Label_1000s.IsVisible = true;
            Label_100s.IsVisible = true;
            Label_10s.IsVisible = true;
            Label_1s.IsVisible = true;
            Label_Up100s.IsVisible = true;
            Label_Up10s.IsVisible = true;

            if (right_sum < 10)
            {
                Label_1000s.IsVisible = false;
                Label_100s.IsVisible = false;
                Label_10s.IsVisible = false;
            }
            else if (right_sum < 100)
            {
                Label_1000s.IsVisible = false;
                Label_100s.IsVisible = false;
            }
            else if (right_sum < 1000)
            {
                Label_1000s.IsVisible = false;                
            }

            if (right_value_Up100s == 0)
            {
                Label_Up100s.IsVisible = false;
            }

            if (right_value_Up10s == 0)
            {
                Label_Up10s.IsVisible = false;
            }

            Label_1000s.Text = Convert.ToString(right_value_1000s);
            Label_100s.Text = Convert.ToString(right_value_100s);
            Label_10s.Text = Convert.ToString(right_value_10s);
            Label_1s.Text = Convert.ToString(right_value_1s);
            Label_Up100s.Text = Convert.ToString(right_value_Up100s);
            Label_Up10s.Text = Convert.ToString(right_value_Up10s);

            Label_FirstNum100s.Text = Convert.ToString(question_first100s);
            Label_SecNum100s.Text = Convert.ToString(question_sec100s);
            Label_FirstNum10s.Text = Convert.ToString(question_first10s);
            Label_SecNum10s.Text = Convert.ToString(question_sec10s);
            Label_FirstNum1s.Text = Convert.ToString(question_first1s);
            Label_SecNum1s.Text = Convert.ToString(question_sec1s);

            /* 풀이 페이지의 해설부분 출력 - 시작 */
            BoxView_Q100s.IsVisible = true;
            BoxView_Q10s.IsVisible = true;
            BoxView_S100s.IsVisible = true;
            BoxView_S10s.IsVisible = true;
            switch (LearnSetSington.Instance.setNdigit)
            {
                case 1:
                    Label_Solve_10s.IsVisible = false;
                    Label_Solve_100s.IsVisible = false;
                    BoxView_Q100s.IsVisible = false;
                    BoxView_Q10s.IsVisible = false;
                    BoxView_S100s.IsVisible = false;
                    BoxView_S10s.IsVisible = false;
                    break;
                case 2:
                    Label_Solve_100s.IsVisible = false;
                    BoxView_Q100s.IsVisible = false;                    
                    BoxView_S100s.IsVisible = false;                    
                    break;
                case 3:
                    break;
            }

            /* 1의 자리 */
            if ((right_value_10s != 0) && (question_first10s == 0))
            {
                if (right_value_Up10s != 0)
                {
                    Label_Solve_1s.Text = "( " + Label_Up10s.Text + " )" + " + " + Label_FirstNum1s.Text +  " + " + Label_SecNum1s.Text + " = " + Label_10s.Text + Label_1s.Text;
                }
                else
                {
                    Label_Solve_1s.Text = Label_FirstNum1s.Text + " + " + Label_SecNum1s.Text + " = " + Label_10s.Text + Label_1s.Text;
                }
            }
            else 
            {
                Label_Solve_1s.Text = Label_FirstNum1s.Text + " + " + Label_SecNum1s.Text + " = " + Label_1s.Text;
            }

            /* 10의 자리 */
            if ((right_value_100s != 0) && (question_first100s == 0))
            {
                if (right_value_Up10s != 0)
                {
                    Label_Solve_10s.Text = "( " + Label_Up10s.Text + " )" + " + " + Label_FirstNum10s.Text + " + " + Label_SecNum10s.Text + " = " + Label_100s.Text + Label_10s.Text;
                }
                else
                {
                    Label_Solve_10s.Text =  Label_FirstNum10s.Text + " + " + Label_SecNum10s.Text + " = " + Label_100s.Text + Label_10s.Text;
                }
            }
            else
            {
                if (right_value_Up10s != 0)
                {
                    Label_Solve_10s.Text = "( " + Label_Up10s.Text + " )" + " + " + Label_FirstNum10s.Text + " + " + Label_SecNum10s.Text + " = " + Label_10s.Text;
                }
                else
                {
                    Label_Solve_10s.Text = Label_FirstNum10s.Text + " + " + Label_SecNum10s.Text + " = " + Label_10s.Text;
                }
            }

            /* 100의 자리 */
            if ( right_value_1000s != 0)
            {
                if (right_value_Up100s != 0)
                {
                    Label_Solve_100s.Text = "( " + Label_Up100s.Text + " )" + " + " + Label_FirstNum100s.Text + " + " + Label_SecNum100s.Text + " = " + Label_1000s.Text + Label_100s.Text;
                }
                else
                {
                    Label_Solve_100s.Text = Label_FirstNum100s.Text + " + " + Label_SecNum100s.Text + " = " + Label_1000s.Text + Label_100s.Text;
                }
            }
            else
            {
                if (right_value_Up100s != 0)
                {
                    Label_Solve_100s.Text = "( " + Label_Up100s.Text + " )" + " + " + Label_FirstNum100s.Text + " + " + Label_SecNum100s.Text + " = " + Label_100s.Text;
                }
                else
                {
                    Label_Solve_100s.Text = Label_FirstNum100s.Text + " + " + Label_SecNum100s.Text + " = " + Label_100s.Text;
                }
            }
            /* 풀이 페이지의 해설부분 출력 - 끝 */

            if (input_sum != right_sum)
            {
                Button_ResultON.Text = "땡! (오답: " + Convert.ToString(input_sum) + ") 계속하시려면 여기를 눌러주세요.";
                Button_ResultON.TextColor = Color.Red;
            }
            else 
            {
                Button_ResultON.Text = "정답! 계속하시려면 여기를 눌러주세요.";
                Button_ResultON.TextColor = Color.Blue;
            }


        }

    }

    public class ResultData
    {
        private static ResultData instance = null;
        public static ResultData Instance
        {
            get 
            {
                if (instance == null)
                {
                    instance = new ResultData();
                }
                return instance;
            }
        }

        private ResultData()
        { 
        
        }
        public int input1000s;
        public int input100s;
        public int input10s;
        public int input1s;
        public int inputUp100s;
        public int inputUp10s;
        public int inputSum;

        public int rightAnswer1000s;
        public int rightAnswer100s;
        public int rightAnswer10s;
        public int rightAnswer1s;
        public int rightAnswerUp100s;
        public int rightAnswerUp10s;
        public int rightSum;

        public int question_first100s;
        public int question_first10s;
        public int question_first1s;
        public int question_sec100s;
        public int question_sec10s;
        public int question_sec1s;

    }
}