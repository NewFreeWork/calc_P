using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace forms_plus.Models
{
    public class RankingInfo
    {
        public int Rk { get; set; }

        [PrimaryKey, AutoIncrement]
        public int Idx { get; set; }
        public String Usr { get; set; }
        public String Stage { get; set; }
        public int Score { get; set; }
        public String Time { get; set; }
        public String Date { get; set; }
    }
}
