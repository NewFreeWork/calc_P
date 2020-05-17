using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace forms_plus.Models
{
    public class RankingInfo
    {
        [PrimaryKey, AutoIncrement]
        public int rank { get; set; }
        public string usr { get; set; }
        public int stage { get; set; }
        public int score { get; set; }
        public string time { get; set; }
    }
}
