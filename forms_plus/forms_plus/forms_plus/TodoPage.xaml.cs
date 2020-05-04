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

            /*kindbiny_20200502 달력 추가(샘플) */
            calendar = new XamForms.Controls.Calendar();

            calendar.SpecialDates.Add(new SpecialDate(DateTime.Now.AddDays(5))
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

            calendar.SelectedDate = DateTime.Now;
        }

        /*kindbiny_20200502 달력 선택 이벤트 추가 */
        public void CalrendarDate_Clicked(object sender, EventArgs e)
        {
            try
            {
                /*kindbiny_20200502 달력 선택 이벤트 컨셉 추가 */
                if (calendar.SelectedDates[0].Date.ToString() == DateTime.Now.AddDays(5).Date.ToString())
                {
                    boxview_todo_1st.IsVisible = true;
                    boxview_todo_2nd.IsVisible = true;
                    boxview_todo_3th.IsVisible = true;

                    label_todo_learn.IsVisible = true;
                    label_todo_test.IsVisible = true;
                }
                else
                {
                    boxview_todo_1st.IsVisible = false;
                    boxview_todo_2nd.IsVisible = false;
                    boxview_todo_3th.IsVisible = false;

                    label_todo_learn.IsVisible = false;
                    label_todo_test.IsVisible = false;
                }
            }
            catch
            {

            }
            
        }
    }
}