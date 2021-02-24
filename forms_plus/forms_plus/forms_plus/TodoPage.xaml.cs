using System;
using System.Collections.Generic;
using System.Linq;
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

            boxview_todo_1st.IsVisible = false;
            boxview_todo_2nd.IsVisible = false;
            boxview_todo_3th.IsVisible = false;

            label_todo_learn.IsVisible = false;
            label_todo_test.IsVisible = false;

            Grid_todo_Learn.IsVisible = false;
            listLearn.IsVisible = false;
            Grid_todo_Test.IsVisible = false;
            listTest.IsVisible = false;


            /*kindbiny_20200502 달력 추가(샘플) */
            calendar = new XamForms.Controls.Calendar();

            DateTime today = DateTime.Now.Date;
            DateTime firstDay = today.AddDays(1 - today.Day);
            String sYear = DateTime.Now.Year.ToString();
            String sMonth = (DateTime.Now.Month < 10) ? ("0" + DateTime.Now.Month.ToString()) : DateTime.Now.Month.ToString();

            for (int Day = 1; Day <= DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month); Day++)
            {
                String sDay = (Day < 10) ? ("0" + Day.ToString()) : Day.ToString();
                String Date = sYear+ "-" + sMonth + "-" + sDay;

                bool LearnDone = (App.CalLearnInfoDatabase.getTodayLearnListCount(Date) > 0) ? true : false;
                bool TestDone = (App.CalTestInfoDatabase.getTodayTestListCount(Date) > 0) ? true : false;

                if ((LearnDone == true) && (TestDone == true))
                {
                    calendar.SpecialDates.Add(new SpecialDate(firstDay.AddDays((double)Day - 1))
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
                                new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Gold},
                                new Pattern{WidthPercent = 1f, HightPercent = 0.05f, Color = Color.Transparent},
                                new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.White},
                            }
                        }
                    });
                }
                else if ((LearnDone == true) && (TestDone == false))
                {
                    calendar.SpecialDates.Add(new SpecialDate(firstDay.AddDays((double)Day - 1))
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
                                new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Gold},
                                new Pattern{WidthPercent = 1f, HightPercent = 0.05f, Color = Color.Transparent},
                                new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.Transparent},
                            }
                        }
                    });
                }
                else if ((LearnDone == false) && (TestDone == true))
                {
                    calendar.SpecialDates.Add(new SpecialDate(firstDay.AddDays((double)Day - 1))
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
                                new Pattern{WidthPercent = 1f, HightPercent = 0.1f, Color = Color.White},
                            }
                        }
                    });
                }
                else 
                {
                    // Do nothing.
                }
            }           

            calendar.SelectedDate = DateTime.Now;

            print_DetailLearnTestInfo();
        }

        public async void PrintListLearn(String Date)
        {
            listLearn.ItemsSource = await App.CalLearnInfoDatabase.GetTodayLearningInfoAsync(Date);
        }
        public async void PrintListTest(String Date)
        {
            listTest.ItemsSource = await App.CalTestInfoDatabase.GetTodayTestInfoAsync(Date);
        }

        private void print_DetailLearnTestInfo()
        {
            String sYear = calendar.SelectedDates[0].Year.ToString();
            String sMonth = (calendar.SelectedDates[0].Month < 10) ? ("0" + calendar.SelectedDates[0].Month.ToString()) : (calendar.SelectedDates[0].Month.ToString());
            String sDay = (calendar.SelectedDates[0].Day < 10) ? ("0" + calendar.SelectedDates[0].Day.ToString()) : (calendar.SelectedDates[0].Day.ToString());
            String sDate = sYear + "-" + sMonth + "-" + sDay; 
            bool IsVisibleLearnOrTest = false;
            label_todo_learn.IsVisible = false;
            label_todo_test.IsVisible = false;
            Grid_todo_Learn.IsVisible = false;
            listLearn.IsVisible = false;
            Grid_todo_Test.IsVisible = false;
            listTest.IsVisible = false;



            if (App.CalLearnInfoDatabase.getTodayLearnListCount(sDate) > 0)
            {
                boxview_todo_1st.IsVisible = true;
                boxview_todo_2nd.IsVisible = true;
                //boxview_todo_3th.IsVisible = true;

                label_todo_learn.IsVisible = true;
                IsVisibleLearnOrTest = true;

                Grid_todo_Learn.IsVisible = true;
                listLearn.IsVisible = true;

                PrintListLearn(sDate);
            }

            if (App.CalTestInfoDatabase.getTodayTestListCount(sDate) > 0)
            {
                //boxview_todo_1st.IsVisible = true;
                boxview_todo_2nd.IsVisible = true;
                boxview_todo_3th.IsVisible = true;

                label_todo_test.IsVisible = true;
                IsVisibleLearnOrTest = true;

                Grid_todo_Test.IsVisible = true;
                listTest.IsVisible = true;

                PrintListTest(sDate);
            }

            if (IsVisibleLearnOrTest == false)
            {
                boxview_todo_1st.IsVisible = false;
                boxview_todo_2nd.IsVisible = false;
                boxview_todo_3th.IsVisible = false;

                label_todo_learn.IsVisible = false;
                label_todo_test.IsVisible = false;
            }
        }

        /*kindbiny_20200502 달력 선택 이벤트 추가 */
        public void CalrendarDate_Clicked(object sender, EventArgs e)
        {
            try
            {
                print_DetailLearnTestInfo();               
            }
            catch
            {

            }
            
        }
    }
}