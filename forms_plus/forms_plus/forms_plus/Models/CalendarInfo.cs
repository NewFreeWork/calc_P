using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace forms_plus.Models
{
    public class CalendarLearnInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Idx { get; set; }
        public String Usr { get; set; }
        public String LearnDate { get; set; }
        public bool LearnDone { get; set; }
        public String LearnStage { get; set; }
   
    }

    public class CalendarTestInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Idx { get; set; }
        public String Usr { get; set; }
        public String TestDate { get; set; }
        public bool TestDone { get; set; }
        public String TestStage { get; set; }
        public int TestScore { get; set; }
        public String TestTime { get; set; }
    }
}
