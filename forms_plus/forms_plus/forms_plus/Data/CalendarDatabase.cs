using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using forms_plus.Models;
using System.Threading.Tasks;

namespace forms_plus.Data
{
    public class CalendarTestDatabase
    {
        readonly SQLiteAsyncConnection _cal_Testdatabase;
        public CalendarTestDatabase(string dbPath)
        {
            _cal_Testdatabase = new SQLiteAsyncConnection(dbPath);
            _cal_Testdatabase.CreateTableAsync<CalendarTestInfo>().Wait();
        }

        public Task<List<CalendarTestInfo>> GetTodayTestInfoAsync(String Date)
        {
            Task<List<CalendarTestInfo>> lists = _cal_Testdatabase.Table<CalendarTestInfo>().Where(i => i.TestDate == Date).ToListAsync();
            return lists;
        }

        public int getTodayTestListCount(String TestDate)
        {
            Task<List<CalendarTestInfo>> lists = _cal_Testdatabase.Table<CalendarTestInfo>().Where(i => i.TestDate == TestDate).ToListAsync();

            return lists.Result.Count;
        }

        public Task<int> SaveTestResultAsync(CalendarTestInfo info)
        {
            return _cal_Testdatabase.InsertAsync(info);
        }

        public Task<int> DeleteTestResultAsync(CalendarTestInfo info)
        {
            return _cal_Testdatabase.DeleteAsync(info);
        }

        public Task<int> DeleteAllTestResultAsync()
        {
            return _cal_Testdatabase.DeleteAllAsync<CalendarTestInfo>();
        }

        public Task<int> DeleteTestStageAsync(String stage)
        {
            return _cal_Testdatabase.Table<CalendarTestInfo>().Where(i => i.TestStage == stage).DeleteAsync();
        }

        public async void SaveCalendarTestInfo(String userName, int stage, String date,int score, String time)
        {
            CalendarTestInfo info = new CalendarTestInfo();

            info.Usr = userName;
            info.TestStage = stage.ToString();
            info.TestScore = score;
            info.TestDate = date;
            info.TestDone = true;
            info.TestTime = time;

            switch (stage)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    await App.CalTestInfoDatabase.SaveTestResultAsync(info);
                    break;

                default:
                    break;
            }
        }
    }


    public class CalendarLearnDatabase
    {
        readonly SQLiteAsyncConnection _cal_Learndatabase;
 

        public CalendarLearnDatabase(string dbPath)
        {
            _cal_Learndatabase = new SQLiteAsyncConnection(dbPath);
            _cal_Learndatabase.CreateTableAsync<CalendarLearnInfo>().Wait();
        }
        

        public Task<List<CalendarLearnInfo>> GetTodayLearningInfoAsync(String Date)
        {
            Task<List<CalendarLearnInfo>> lists = _cal_Learndatabase.Table<CalendarLearnInfo>().Where(i => i.LearnDate == Date).ToListAsync();
            return lists;
        }
               

        public int getTodayLearnListCount(String LearnDate)
        {
            Task<List<CalendarLearnInfo>> lists = _cal_Learndatabase.Table<CalendarLearnInfo>().Where(i => i.LearnDate==LearnDate).ToListAsync();

            return lists.Result.Count;
        }

      
        public Task<int> SaveLearnResultAsync(CalendarLearnInfo info)
        {
            return _cal_Learndatabase.InsertAsync(info);
        }

        public Task<int> DeleteLearnResultAsync(CalendarLearnInfo info)
        {
            return _cal_Learndatabase.DeleteAsync(info);
        }

        public Task<int> DeleteAllLearnItemAsync()
        {
            return _cal_Learndatabase.DeleteAllAsync<CalendarLearnInfo>();
        }

        public Task<int> DeleteLearnStageAsync(String stage)
        {
            return _cal_Learndatabase.Table<CalendarLearnInfo>().Where(i => i.LearnStage == stage).DeleteAsync();
        }


        public async void SaveCalendarLearnInfo(String userName, int stage, String date, bool learnDone)
        {
            CalendarLearnInfo info = new CalendarLearnInfo();

            info.Usr = userName;
            info.LearnStage = stage.ToString();
            info.LearnDate = date;
            info.LearnDone = learnDone;

            switch (stage)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                    await App.CalLearnInfoDatabase.SaveLearnResultAsync(info);
                    break;

                default:
                    break;
            }
        }
    }
}
