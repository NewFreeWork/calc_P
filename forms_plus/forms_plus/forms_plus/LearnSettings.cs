using System;
using System.Collections.Generic;
using System.Text;

namespace forms_plus
{
    public class LearnSetSington
    {

        private static LearnSetSington instance = null;
        public static LearnSetSington Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new LearnSetSington();
                }
                return instance;
            }
        }

        private LearnSetSington()
        {
        }

        public int setNdigit; // 선언할 변수들 
        public bool setUpOnOff; // 선언할 변수들 
        public int setQ_Num; // 선언할 변수들 
    }

}
