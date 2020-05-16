using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using XamForms.Controls;

namespace forms_plus
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TodoPage : ContentPage
    {

        XamForms.Controls.Calendar calendar;

        public TodoPage()
        {
            InitializeComponent();

            //kindbiny_20200516 달력 생성
            Calrendar_Create_Display();

            //kindbiny_20200516 달력 외 부분 UI 그리기
            Under_UI_Initial();            
        }

        //kindbiny_20200516 달력 생성
        private void Calrendar_Create_Display()
        {
            Boolean learn_ok = false, test_ok = false;

            calendar = new XamForms.Controls.Calendar();

            var app = Application.Current as App;

            try
            {
                for(uint i=0;i<app.todo_date_cnt;i++)
                {
                    learn_ok = false;
                    test_ok = false;

                    if (app.todo_display[i].todo_learn_cnt != 0)
                    {
                        learn_ok = true;
                    }

                    if(app.todo_display[i].todo_test_cnt != 0)
                    {
                        test_ok = true;
                    }

                    if(learn_ok == true && test_ok == true)
                    {
                        SpecialDates_L_T_Add(app.todo_display[i].todo_date);
                    }
                    else if (learn_ok == true && test_ok == false)
                    {
                        SpecialDates_L_Add(app.todo_display[i].todo_date);
                    }
                    else if (learn_ok == false && test_ok == true)
                    {
                        SpecialDates_T_Add(app.todo_display[i].todo_date);
                    }
                    else
                    {

                    }
                }
            }
            catch
            {

            }
        }

        //kindbiny_20200516 달력 내부 패턴 그리기 L/T
        private void SpecialDates_L_T_Add(DateTime todo_date)
        {           
            calendar = new XamForms.Controls.Calendar();

            calendar.SpecialDates.Add(new SpecialDate(todo_date)
            {
                TextColor = Color.White,
                Selectable = true,

                BackgroundPattern = new BackgroundPattern(1)
                {
                    Pattern = new List<Pattern>
                    {
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.05f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.DeepPink},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.05f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.DarkViolet},
                    }
                }
            });
        }

        //kindbiny_20200516 달력 내부 패턴 그리기 L
        private void SpecialDates_L_Add(DateTime todo_date)
        {
            calendar = new XamForms.Controls.Calendar();

            calendar.SpecialDates.Add(new SpecialDate(todo_date)
            {
                TextColor = Color.White,
                Selectable = true,

                BackgroundPattern = new BackgroundPattern(1)
                {
                    Pattern = new List<Pattern>
                    {
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.05f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.05f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.DeepPink},
                    }
                }
            });
        }

        //kindbiny_20200516 달력 내부 패턴 그리기 T
        private void SpecialDates_T_Add(DateTime todo_date)
        {
            calendar = new XamForms.Controls.Calendar();

            calendar.SpecialDates.Add(new SpecialDate(todo_date)
            {
                TextColor = Color.White,
                Selectable = true,

                BackgroundPattern = new BackgroundPattern(1)
                {
                    Pattern = new List<Pattern>
                    {
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.05f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.05f, Color = Color.Transparent},
                        new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.DarkViolet},
                    }
                }
            });
        }

        //kindbiny_20200516 달력 외 부분 UI 그리기
        private void Under_UI_Initial()
        {            
            label_todo_today.Text = "★ Today : " + DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/" + DateTime.Now.Day.ToString();

            boxview_todo_1st.Color = Color.DeepPink;
            boxview_todo_3th.Color = Color.DarkViolet;

            label_todo_1st.Text = "";
            label_todo_3th.Text = "";

            boxview_todo_1st.IsVisible = false;
            boxview_todo_2nd.IsVisible = false;
            boxview_todo_3th.IsVisible = false;

            label_todo_1st.IsVisible = false;
            label_todo_3th.IsVisible = false;
        }

        /*kindbiny_20200502 달력 선택 이벤트 추가 */
        public void CalrendarDate_Clicked(object sender, EventArgs e)
        {
            uint searched_index = 0;
            string learn_display_str = "", test_display_str = "";
            Boolean search_ok = false, learn_ok = false, test_ok = false;

            var app = Application.Current as App;

            try
            {
                for(uint i=0;i<app.todo_date_cnt;i++)
                {
                    if(calendar.SelectedDates[0].Date.ToString() == app.todo_display[i].todo_date.ToString())
                    {
                        search_ok = true;
                        searched_index = i;
                        break;
                    }
                }
            }
            catch
            {

            }

            if(app.todo_display[searched_index].todo_learn_cnt != 0)
            {
                learn_ok = true;
                learn_display_str = "- Learn :" + app.todo_display[searched_index].todo_learn_cnt.ToString() + "회";
            }

            if (app.todo_display[searched_index].todo_test_cnt != 0)
            {
                test_ok = true;
                test_display_str = "- Test :" + app.todo_display[searched_index].todo_test_cnt.ToString() + "회 ";
                test_display_str += app.todo_display[searched_index].todo_test_score.ToString() + "점(Avg)";

            }

            if(search_ok == true)
            {
                if (learn_ok == true && test_ok == true)
                {
                    boxview_todo_1st.Color = Color.DeepPink;
                    boxview_todo_3th.Color = Color.DarkViolet;
                    label_todo_1st.Text = learn_display_str;
                    label_todo_3th.Text = test_display_str;

                    boxview_todo_1st.IsVisible = true;
                    boxview_todo_2nd.IsVisible = true;
                    boxview_todo_3th.IsVisible = true;

                    label_todo_1st.IsVisible = true;
                    label_todo_3th.IsVisible = true;
                }
                else if (learn_ok == true && test_ok == false)
                {
                    boxview_todo_1st.Color = Color.DeepPink;
                    boxview_todo_3th.Color = Color.DarkViolet;
                    label_todo_1st.Text = learn_display_str;
                    label_todo_3th.Text = test_display_str;

                    boxview_todo_1st.IsVisible = true;
                    boxview_todo_2nd.IsVisible = false;
                    boxview_todo_3th.IsVisible = false;

                    label_todo_1st.IsVisible = true;
                    label_todo_3th.IsVisible = false;
                }
                else if (learn_ok == false && test_ok == true)
                {
                    boxview_todo_1st.Color = Color.DarkViolet;
                    boxview_todo_3th.Color = Color.DarkViolet;
                    label_todo_1st.Text = test_display_str;
                    label_todo_3th.Text = test_display_str;

                    boxview_todo_1st.IsVisible = true;
                    boxview_todo_2nd.IsVisible = false;
                    boxview_todo_3th.IsVisible = false;

                    label_todo_1st.IsVisible = false;
                    label_todo_3th.IsVisible = false;
                }
                else
                {
                    Under_UI_Initial();
                }
            }
            else
            {
                Under_UI_Initial();
            }
        }

        private void Del_Clicked(object sender, EventArgs e)
        {
            var app = Application.Current as App;

            app.Buffer_Initial();
        }
    }
}