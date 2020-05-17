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

        public Task<List<RankingInfo>> GetRankingsAsync()
        {
            return _database.Table<RankingInfo>().ToListAsync();
        }

        public Task<RankingInfo> GetRankingAsync(string user)
        {
            return _database.Table<RankingInfo>()
                .Where(i => i.usr == user)
                .FirstOrDefaultAsync();
        }

        public Task<List<RankingInfo>> SortScore(bool sortAscending)
        {
            if (sortAscending)
            {
                return _database.Table<RankingInfo>().OrderBy(w => w.score).OrderBy(w => w.time).ToListAsync();
            }
            else 
            {
                return _database.Table<RankingInfo>().OrderByDescending(w => w.score).OrderBy(w => w.time).ToListAsync();
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
        public async void SaveRankingInfo(string userid, int stage, int score, string time)
        {
            RankingInfo info = new RankingInfo();

            info.usr = userid;
            info.stage = stage;
            info.score = score;
            info.time = time;
            info.rank = 1;

            switch (stage)
            {
                case 1:
                    await App.Database1.SaveRankingResultAsync(info);
                    break;
                case 2:
                    await App.Database2.SaveRankingResultAsync(info);
                    break;
                case 3:
                    await App.Database3.SaveRankingResultAsync(info);
                    break;
                case 4:
                    await App.Database4.SaveRankingResultAsync(info);
                    break;
                case 5:
                    await App.Database5.SaveRankingResultAsync(info);
                    break;
                default:
                    break;
            }
        }
    }
}
