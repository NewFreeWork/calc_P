using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using forms_plus.Models;
using System.Threading.Tasks;

namespace forms_plus.Data
{
    public class RankingDatabase
    {
        readonly SQLiteAsyncConnection _database;

        public RankingDatabase(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<RankingInfo>().Wait();
        }

        public Task<List<RankingInfo>> GetRankingsAsync(String stage)
        {

#if true
            String QueryStr = "SELECT Usr, Score, Time, Date, RANK() OVER (ORDER BY Score DESC, Time ASC) as Rk From RankingInfo Where Stage="+stage;
            Task<List<RankingInfo>> list = _database.QueryAsync<RankingInfo>(QueryStr);

            Task<List<RankingInfo>> DeleteQryRtn;
            for (int i = list.Result.Count - 1; i >= 30; i--)
            {               
                QueryStr = "DELETE FROM RankingInfo Where Time='"+ list.Result[i].Time+"'";
                DeleteQryRtn = _database.QueryAsync<RankingInfo>(QueryStr);
            }

            QueryStr = "SELECT Usr, Score, Time, Date, RANK() OVER (ORDER BY Score DESC, Time ASC) as Rk From RankingInfo Where Stage=" + stage;
            list = _database.QueryAsync<RankingInfo>(QueryStr);

            return list;
#else
            String QueryStr = "SELECT Usr, Stage, Score, Time, RANK() OVER (ORDER BY Score DESC, Time ASC) as Rk From RankingInfo Where Stage=" + stage;
            
            return _database.QueryAsync<RankingInfo>(QueryStr);            
#endif

        }


        public Task<RankingInfo> GetRankingAsync(string user)
        {
            return _database.Table<RankingInfo>()
                .Where(i => i.Usr == user)
                .FirstOrDefaultAsync();
        }

        public Task<List<RankingInfo>> SortScore(bool sortAscending)
        {
            if (sortAscending)
            {
                return _database.Table<RankingInfo>().OrderBy(w => w.Score).OrderBy(w => w.Time).ToListAsync();
            }
            else 
            {
                return _database.Table<RankingInfo>().OrderByDescending(w => w.Score).OrderBy(w => w.Time).ToListAsync();
            }
        }

        public Task<int> SaveRankingResultAsync(RankingInfo info)
        {
            return _database.InsertAsync(info);
        }

        public Task<int> DeleteRankingResultAsync(RankingInfo info)
        {
            return _database.DeleteAsync(info);
        }

        public Task<int> DeleteItemAsync()
        {
            return _database.DeleteAllAsync<RankingInfo>();
        }

        public Task<int> DeleteStageAsync(String stage)
        {
            return _database.Table<RankingInfo>().Where(i => i.Stage == stage).DeleteAsync();
        }



        public async void SaveRankingInfo(String userName, int stage, int score, String time, int Qnum, String date)
        {
            RankingInfo info = new RankingInfo();

            if (Qnum >= 10)
            {

                info.Usr = userName;
                info.Stage = stage.ToString();
                info.Score = score;
                info.Time = time;
                info.Date = date;

                switch (stage)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        await App.RkInfoDatabase.SaveRankingResultAsync(info);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
