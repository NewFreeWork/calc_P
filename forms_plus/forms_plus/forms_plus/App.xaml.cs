using System;
using System.Globalization;
using System.IO;                //kindbiny_20200516 추가
using System.Threading.Tasks;
using System.Xml.Serialization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace forms_plus
{
    public partial class App : Application
    {
        public struct TODO_DISPLAY
        {
            public DateTime todo_date;
            public uint todo_learn_cnt;
            public uint todo_test_cnt;
            public uint todo_test_save_cnt;
            public uint todo_test_score;
            public uint todo_test_ranking;
        }

        public string loaded_info_str;
        public uint todo_date_cnt;
        public TODO_DISPLAY[] todo_display;

        public App()
        {
            InitializeComponent();
#if false       //kindbiny_20200415 네비게이션 페이지로 변경
            MainPage = new MainPage();
#else
            MainPage = new NavigationPage(new MainPage());
#endif
            //kindbiny_20200516 변수 초기화
            Apppage_Variable_Initial();

            //kindbiny_20200516 결과 파일 로드
            Result_Info_Load();

            //kindbiny_20200516 로드 된 파일 내부 퍼버 저장
            try
            {
                if (Result_Info_LocalBuffer_Save(loaded_info_str) == false)
                {
                    todo_display = new TODO_DISPLAY[5];
                }
            }
            catch
            {
                todo_display = new TODO_DISPLAY[5];
            }

            test_save();


        }

        //kindbiny_20200516 테스트용
        private async void test_save()
        {
            Boolean a;
            DateTime date = new DateTime(2020, 05, 06);

            a = await Result_Info_Save(date, true, 1, 45, 5);
            a = await Result_Info_Save(date, false, 1, 45, 5);
        }

        //kindbiny_20200516 변수 초기화
        private void Apppage_Variable_Initial()
        {
            todo_date_cnt = 0;
        }

        //kindbiny_20200516 결과 파일 로드
        private void Result_Info_Load()
        {
            var LoadedFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "result_info.txt");

            if(File.Exists(LoadedFile))
            {
                using (var reader = new StreamReader(LoadedFile))
                {
                    loaded_info_str = reader.ReadToEnd();
                }
            }
            else
            {
                loaded_info_str = "";
            }
        }

        //kindbiny_20200516 내부 버퍼에 결과 추가 및 파일 저장
        public async Task<Boolean> Result_Info_Save(DateTime date, Boolean learn_test_sel, Byte cnt, Byte score, Byte ranking)
        {
            string temp_str = "";
            Boolean same_date_ckeck = false;
            uint date_index = 0;

            var SaveFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "result_info.txt");

            for(uint i = 0;i<todo_date_cnt + 1;i++)
            {
                if(todo_display[i].todo_date.Date.ToString() == date.Date.ToString())
                {
                    same_date_ckeck = true;
                    date_index = i;
                    break;
                }

                if(todo_display[i].todo_date.Date.ToString().IndexOf("1/1/0001") != -1)
                {
                    date_index = i;
                    break;
                }
            }

            if(same_date_ckeck)
            {
                if(learn_test_sel == false) //learn_mode
                {
                    todo_display[date_index].todo_learn_cnt += cnt;
                }
                else           //test_mode
                {           
                    if(todo_display[date_index].todo_test_save_cnt == 0)
                    {
                        todo_display[date_index].todo_test_score = score;
                    }
                    else
                    {
                        todo_display[date_index].todo_test_score = (score + todo_display[date_index].todo_test_score) / 2;
                    }

                    if(todo_display[date_index].todo_test_ranking > ranking)
                    {
                        todo_display[date_index].todo_test_ranking = ranking;
                    }

                    todo_display[date_index].todo_test_cnt += cnt;
                }
            }
            else
            {
                todo_display[date_index].todo_date = date;

                if(learn_test_sel == false)
                {
                    todo_display[date_index].todo_learn_cnt = cnt;
                }
                else
                {
                    todo_display[date_index].todo_test_cnt = cnt;
                    todo_display[date_index].todo_test_score = score;
                    todo_display[date_index].todo_test_ranking = ranking;

                    todo_display[date_index].todo_test_save_cnt = 1;
                }

                todo_date_cnt++;
            }

            for (uint i = 0; i < todo_date_cnt; i++)
            {
                string[] part_sum = new string[3];

                part_sum[0] = todo_display[i].todo_date.Year.ToString() + string.Format("{0:00}", todo_display[i].todo_date.Month) +
                    string.Format("{0:00}", todo_display[i].todo_date.Day);
                part_sum[1] = string.Format("{0:0000}", todo_display[i].todo_learn_cnt) + ":000";
                part_sum[2] = string.Format("{0:0000}", todo_display[i].todo_test_cnt) + ":" + string.Format("{0:000}", todo_display[i].todo_test_score); //without ranking


                if (part_sum[0].Length == 8 && part_sum[1].Length == 8 && part_sum[2].Length == 8)
                {
                    temp_str = part_sum[0] + "/" + part_sum[1] + "/" + part_sum[2] + "\n";
                }
                else
                {
                    continue;
                }
            }

            if(File.Exists(SaveFile))
            {
                try
                {
                    File.Delete(SaveFile);
                }
                catch
                {

                }    
            }

            if(SaveFile != "" && SaveFile != null)
            {
                using (var writer = File.CreateText(SaveFile))
                {
                    await writer.WriteAsync(temp_str);
                }
            }

            return true;
        }

        public async void Buffer_Initial()
        {
            var SaveFile = Path.Combine(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal), "result_info.txt");

            todo_display.Initialize();

            using (var writer = File.CreateText(SaveFile))
            {
                await writer.WriteAsync("");
            }

        }

        //kindbiny_20200516 로드 된 파일 내부 퍼버 저장
        public Boolean Result_Info_LocalBuffer_Save(string load_data)
        {
            Boolean retrurn_value = false;

            string[] temp_str_array = null;            
            string[] temp_part = null, temp_t = null;

            if(load_data.IndexOf('\n') != -1 && load_data != null && load_data != "")
            {
                try
                {
                    temp_str_array = load_data.Split('\n');
                }
                catch
                {

                }
            }
            else
            {
                return false;
            }

            todo_display = new TODO_DISPLAY[temp_str_array.Length + 5];

            retrurn_value = true;

            try
            {
                for(uint i =0;i< temp_str_array.Length;i++)
                {
                    temp_part = temp_str_array[i].Split('/');

                    if (temp_part.Length == 3 && temp_part[0].Length == 8 && temp_part[1].Length == 8 && temp_part[2].Length == 8)
                    {
                        todo_display[i].todo_date = new DateTime(Convert.ToInt32(temp_part[0].Substring(0, 4)),
                            Convert.ToInt32(temp_part[0].Substring(4, 2)), Convert.ToInt32(temp_part[0].Substring(6, 2)));

                        try
                        {
                            temp_t = temp_part[1].Split(':');

                            todo_display[i].todo_learn_cnt = Convert.ToUInt32(temp_t[0]);
                        }
                        catch
                        {
                            todo_display[i].todo_learn_cnt = 0;
                        }

                        try
                        {
                            temp_t = temp_part[2].Split(':');

                            todo_display[i].todo_test_cnt = Convert.ToUInt32(temp_t[0]);
                            todo_display[i].todo_test_score = Convert.ToUInt32(temp_t[1]);                           
                        }
                        catch
                        {
                            todo_display[i].todo_test_cnt = 0;
                            todo_display[i].todo_test_score = 0;
                        }

                        todo_date_cnt++;
                    }
                    else
                    {
                        continue;
                    }
                }
            }
            catch
            {

            }

            return retrurn_value;
        }


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }

   
}
