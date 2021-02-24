using SQLite;
using System;
using System.Collections.Generic;
using System.Text;

namespace forms_plus.Models
{
    public class LoginInfo
    {
        [PrimaryKey, AutoIncrement]
        public int Idx { get; set; }
        public String Usr { get; set; }
    }
}
