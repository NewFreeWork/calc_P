using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using forms_plus.Models;
using System.Threading.Tasks;

namespace forms_plus.Data
{
    public class LoginDatabase
    {

        readonly SQLiteAsyncConnection _login_database;

        public LoginDatabase(string dbPath)
        {
            _login_database = new SQLiteAsyncConnection(dbPath);
            _login_database.CreateTableAsync<LoginInfo>().Wait();
        }

        public String GetUserNameAsync()
        {
            String QueryStr = "SELECT Usr FROM LoginInfo ORDER BY(Idx) DESC LIMIT 1";

            List<LoginInfo> info = _login_database.QueryAsync<LoginInfo>(QueryStr).Result;
            String Name;

            if (info.Count > 0)
            {
                Name = info[0].Usr;
            }
            else 
            {
                Name = "";
            }
                    

            return Name;
        }


        public Task<int> SaveUserNameAsync(LoginInfo info)
        {
            return _login_database.InsertAsync(info);
        }

        public Task<int> DeleteLoginInfoAsync(LoginInfo info)
        {
            return _login_database.DeleteAsync(info);
        }

        public Task<int> DeleteAllLoginInfoAsync()
        {
            return _login_database.DeleteAllAsync<LoginInfo>();
        }        

        public Task<int> DeleteTestStageAsync(String userName)
        {
            return _login_database.Table<LoginInfo>().Where(i => i.Usr == userName).DeleteAsync();
        }

        public async void SaveLoginUserName(String userName)
        {
            LoginInfo info = new LoginInfo();

            info.Usr = userName;
          
            await App.LoginInfoDatabase.SaveUserNameAsync(info);
        }

        public async void ClearAllUserName()
        {
            await App.LoginInfoDatabase.DeleteAllLoginInfoAsync();
        }

    }
}
