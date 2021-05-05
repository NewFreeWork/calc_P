using System;
using System.Collections.Generic;
using System.Text;

namespace forms_plus
{
    public class ResultData
    {
        private static ResultData instance = null;
        public static ResultData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new ResultData();
                }
                return instance;
            }
        }

        private ResultData()
        {

        }
        public int input1000s;
        public int input100s;
        public int input10s;
        public int input1s;
        public int inputUp100s;
        public int inputUp10s;
        public int inputSum;

        public int rightAnswer1000s;
        public int rightAnswer100s;
        public int rightAnswer10s;
        public int rightAnswer1s;
        public int rightAnswerUp100s;
        public int rightAnswerUp10s;
        public int rightSum;

        public int question_first100s;
        public int question_first10s;
        public int question_first1s;
        public int question_sec100s;
        public int question_sec10s;
        public int question_sec1s;

        public void ClearResultData()
        {
            input1000s = 0;
            input100s = 0;
            input10s = 0;
            input1s = 0;
            inputUp100s = 0;
            inputUp10s = 0;
            inputSum = 0;

            rightAnswer1000s = 0;
            rightAnswer100s = 0;
            rightAnswer10s = 0;
            rightAnswer1s = 0;
            rightAnswerUp100s = 0;
            rightAnswerUp10s = 0;
            rightSum = 0;

            question_first100s = 0;
            question_first10s = 0;
            question_first1s = 0;
            question_sec100s = 0;
            question_sec10s = 0;
            question_sec1s = 0;
        }

    }

    public class StringDate
    {
        private static StringDate instance = null;

        public static StringDate Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new StringDate();
                }
                return instance;
            }
        }

        public String DateYMD_to_String(int Year, int Month, int Day)
        {
            String sYear = Year.ToString();
            String sMonth = (Month < 10) ? ("0" + Month.ToString()) : Month.ToString();
            String sDay = (Day < 10) ? ("0" + Day.ToString()) : Day.ToString();
            String Date = sYear + "-" + sMonth + "-" + sDay;

            return Date;
        }
    }

    public class UserInfo
    {
        private static UserInfo instance = null;
        public static UserInfo Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new UserInfo();
                }
                return instance;
            }
        }


        public string userName;
    }

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

        public int setNdigit; 
        public bool setUpONOFF; 
        public bool setUpDispOnOff; 
        public int setQ_Num;
        public bool IsTest;
        public int setStage;
    }

    public class AnswerSheetsData
    {

        private static AnswerSheetsData instance = null;
        public static AnswerSheetsData Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new AnswerSheetsData();
                }
                return instance;
            }
        }

        private AnswerSheetsData()
        {
        }
#if false //int를 string형태로 변경
        public string Q_first1;
        public string Q_first2;
        public string Q_first3;
        public string Q_first4;
        public string Q_first5;
        public string Q_first6;
        public string Q_first7;
        public string Q_first8;
        public string Q_first9;
        public string Q_first10;

        public string Q_sec1;
        public string Q_sec2;
        public string Q_sec3;
        public string Q_sec4;
        public string Q_sec5;
        public string Q_sec6;
        public string Q_sec7;
        public string Q_sec8;
        public string Q_sec9;
        public string Q_sec10;

        public string Q_RightAnswer1;
        public string Q_RightAnswer2;
        public string Q_RightAnswer3;
        public string Q_RightAnswer4;
        public string Q_RightAnswer5;
        public string Q_RightAnswer6;
        public string Q_RightAnswer7;
        public string Q_RightAnswer8;
        public string Q_RightAnswer9;
        public string Q_RightAnswer10;

        public string Q_RightUp1;
        public string Q_RightUp2;
        public string Q_RightUp3;
        public string Q_RightUp4;
        public string Q_RightUp5;
        public string Q_RightUp6;
        public string Q_RightUp7;
        public string Q_RightUp8;
        public string Q_RightUp9;
        public string Q_RightUp10;

        public string MyAnswer1;
        public string MyAnswer2;
        public string MyAnswer3;
        public string MyAnswer4;
        public string MyAnswer5;
        public string MyAnswer6;
        public string MyAnswer7;
        public string MyAnswer8;
        public string MyAnswer9;
        public string MyAnswer10;

        public string MyUpAnswer1;
        public string MyUpAnswer2;
        public string MyUpAnswer3;
        public string MyUpAnswer4;
        public string MyUpAnswer5;
        public string MyUpAnswer6;
        public string MyUpAnswer7;
        public string MyUpAnswer8;
        public string MyUpAnswer9;
        public string MyUpAnswer10;

        public int DetailPageIndex;
        public string TotalTime;

        public void ClearAnswerSheetsData()
        {
            Q_first1 = "";
            Q_first2 = "";
            Q_first3 = "";
            Q_first4 = "";
            Q_first5 = "";
            Q_first6 = "";
            Q_first7 = "";
            Q_first8 = "";
            Q_first9 = "";
            Q_first10 = "";

            Q_sec1 = "";
            Q_sec2 = "";
            Q_sec3 = "";
            Q_sec4 = "";
            Q_sec5 = "";
            Q_sec6 = "";
            Q_sec7 = "";
            Q_sec8 = "";
            Q_sec9 = "";
            Q_sec10 = "";

            Q_RightAnswer1 = "";
            Q_RightAnswer2 = "";
            Q_RightAnswer3 = "";
            Q_RightAnswer4 = "";
            Q_RightAnswer5 = "";
            Q_RightAnswer6 = "";
            Q_RightAnswer7 = "";
            Q_RightAnswer8 = "";
            Q_RightAnswer9 = "";
            Q_RightAnswer1 = "";

            Q_RightUp1 = "";
            Q_RightUp2 = "";
            Q_RightUp3 = "";
            Q_RightUp4 = "";
            Q_RightUp5 = "";
            Q_RightUp6 = "";
            Q_RightUp7 = "";
            Q_RightUp8 = "";
            Q_RightUp9 = "";
            Q_RightUp10 = "";

            MyAnswer1 = "";
            MyAnswer2 = "";
            MyAnswer3 = "";
            MyAnswer4 = "";
            MyAnswer5 = "";
            MyAnswer6 = "";
            MyAnswer7 = "";
            MyAnswer8 = "";
            MyAnswer9 = "";
            MyAnswer10 = "";

            MyUpAnswer1 = "";
            MyUpAnswer2 = "";
            MyUpAnswer3 = "";
            MyUpAnswer4 = "";
            MyUpAnswer5 = "";
            MyUpAnswer6 = "";
            MyUpAnswer7 = "";
            MyUpAnswer8 = "";
            MyUpAnswer9 = "";
            MyUpAnswer10 = "";

            DetailPageIndex = 0;
            TotalTime = "00:00:000";
        }

        public void SetAnswerSheetsData(string qFirst, string qSec, string qUp, string rightAnswer, string myUp, string myAnswer, int qNum)
        {
            switch (qNum)
            {
                case 1:
                    Q_first1 = qFirst;
                    Q_sec1 = qSec;
                    Q_RightUp1 = qUp;
                    MyUpAnswer1 = myUp;
                    Q_RightAnswer1 = rightAnswer;
                    MyAnswer1 = myAnswer;
                    break;
                case 2:
                    Q_first2 = qFirst;
                    Q_sec2 = qSec;
                    Q_RightUp2 = qUp;
                    MyUpAnswer2 = myUp;
                    Q_RightAnswer2 = rightAnswer;
                    MyAnswer2 = myAnswer;
                    break;
                case 3:
                    Q_first3 = qFirst;
                    Q_sec3 = qSec;
                    Q_RightUp3 = qUp;
                    MyUpAnswer3 = myUp;
                    Q_RightAnswer3 = rightAnswer;
                    MyAnswer3 = myAnswer;
                    break;
                case 4:
                    Q_first4 = qFirst;
                    Q_sec4 = qSec;
                    Q_RightUp4 = qUp;
                    MyUpAnswer4 = myUp;
                    Q_RightAnswer4 = rightAnswer;
                    MyAnswer4 = myAnswer;
                    break;
                case 5:
                    Q_first5 = qFirst;
                    Q_sec5 = qSec;
                    Q_RightUp5 = qUp;
                    MyUpAnswer5 = myUp;
                    Q_RightAnswer5 = rightAnswer;
                    MyAnswer5 = myAnswer;
                    break;
                case 6:
                    Q_first6 = qFirst;
                    Q_sec6 = qSec;
                    Q_RightUp6 = qUp;
                    MyUpAnswer6 = myUp;
                    Q_RightAnswer6 = rightAnswer;
                    MyAnswer6 = myAnswer;
                    break;
                case 7:
                    Q_first7 = qFirst;
                    Q_sec7 = qSec;
                    Q_RightUp7 = qUp;
                    MyUpAnswer7 = myUp;
                    Q_RightAnswer7 = rightAnswer;
                    MyAnswer7 = myAnswer;
                    break;
                case 8:
                    Q_first8 = qFirst;
                    Q_sec8 = qSec;
                    Q_RightUp8 = qUp;
                    MyUpAnswer8 = myUp;
                    Q_RightAnswer8 = rightAnswer;
                    MyAnswer8 = myAnswer;
                    break;
                case 9:
                    Q_first9 = qFirst;
                    Q_sec9 = qSec;
                    Q_RightUp9 = qUp;
                    MyUpAnswer9 = myUp;
                    Q_RightAnswer9 = rightAnswer;
                    MyAnswer9 = myAnswer;
                    break;
                case 10:
                    Q_first10 = qFirst;
                    Q_sec10 = qSec;
                    Q_RightUp10 = qUp;
                    MyUpAnswer10 = myUp;
                    Q_RightAnswer10 = rightAnswer;
                    MyAnswer10 = myAnswer;
                    break;
            }
        }
#else
        public int Q_first1;
        public int Q_first2;
        public int Q_first3;
        public int Q_first4;
        public int Q_first5;
        public int Q_first6;
        public int Q_first7;
        public int Q_first8;
        public int Q_first9;
        public int Q_first10;

        public int Q_sec1;
        public int Q_sec2;
        public int Q_sec3;
        public int Q_sec4;
        public int Q_sec5;
        public int Q_sec6;
        public int Q_sec7;
        public int Q_sec8;
        public int Q_sec9;
        public int Q_sec10;

        public int Q_RightAnswer1;
        public int Q_RightAnswer2;
        public int Q_RightAnswer3;
        public int Q_RightAnswer4;
        public int Q_RightAnswer5;
        public int Q_RightAnswer6;
        public int Q_RightAnswer7;
        public int Q_RightAnswer8;
        public int Q_RightAnswer9;
        public int Q_RightAnswer10;

       public int Q_RightUp1;
       public int Q_RightUp2;
       public int Q_RightUp3;
       public int Q_RightUp4;
       public int Q_RightUp5;
       public int Q_RightUp6;
       public int Q_RightUp7;
       public int Q_RightUp8;
       public int Q_RightUp9;
       public int Q_RightUp10;

        public int MyAnswer1;
        public int MyAnswer2;
        public int MyAnswer3;
        public int MyAnswer4;
        public int MyAnswer5;
        public int MyAnswer6;
        public int MyAnswer7;
        public int MyAnswer8;
        public int MyAnswer9;
        public int MyAnswer10;

        public int MyUpAnswer1;
        public int MyUpAnswer2;
        public int MyUpAnswer3;
        public int MyUpAnswer4;
        public int MyUpAnswer5;
        public int MyUpAnswer6;
        public int MyUpAnswer7;
        public int MyUpAnswer8;
        public int MyUpAnswer9;
        public int MyUpAnswer10;

        public int DetailPageIndex;
        public string TotalTime;
        public string OldTotalTime;
        public int MyScore;
        public long ElapsedTicks;       

        public void ClearAnswerSheetsData()
        {
            Q_first1 = 0;
            Q_first2 = 0;
            Q_first3 = 0;
            Q_first4 = 0;
            Q_first5 = 0;
            Q_first6 = 0;
            Q_first7 = 0;
            Q_first8 = 0;
            Q_first9 = 0;
            Q_first10 = 0;

            Q_sec1 = 0;
            Q_sec2 = 0;
            Q_sec3 = 0;
            Q_sec4 = 0;
            Q_sec5 = 0;
            Q_sec6 = 0;
            Q_sec7 = 0;
            Q_sec8 = 0;
            Q_sec9 = 0;
            Q_sec10 = 0;

            Q_RightAnswer1 = 0;
            Q_RightAnswer2 = 0;
            Q_RightAnswer3 = 0;
            Q_RightAnswer4 = 0;
            Q_RightAnswer5 = 0;
            Q_RightAnswer6 = 0;
            Q_RightAnswer7 = 0;
            Q_RightAnswer8 = 0;
            Q_RightAnswer9 = 0;
            Q_RightAnswer1 = 0;

            Q_RightUp1 = 0;
            Q_RightUp2 = 0;
            Q_RightUp3 = 0;
            Q_RightUp4 = 0;
            Q_RightUp5 = 0;
            Q_RightUp6 = 0;
            Q_RightUp7 = 0;
            Q_RightUp8 = 0;
            Q_RightUp9 = 0;
            Q_RightUp10 = 0;

            MyAnswer1 = 0;
            MyAnswer2 = 0;
            MyAnswer3 = 0;
            MyAnswer4 = 0;
            MyAnswer5 = 0;
            MyAnswer6 = 0;
            MyAnswer7 = 0;
            MyAnswer8 = 0;
            MyAnswer9 = 0;
            MyAnswer10 = 0;

            MyUpAnswer1 = 0;
            MyUpAnswer2 = 0;
            MyUpAnswer3 = 0;
            MyUpAnswer4 = 0;
            MyUpAnswer5 = 0;
            MyUpAnswer6 = 0;
            MyUpAnswer7 = 0;
            MyUpAnswer8 = 0;
            MyUpAnswer9 = 0;
            MyUpAnswer10 = 0;

            DetailPageIndex = 0;
            TotalTime = "00:00:000";
            OldTotalTime = "00:00:000";
        }
        public void SetAnswerSheetsData(int qFirst, int qSec, int qUp, int rightAnswer, int myUp, int myAnswer, int qNum)
        {
            switch (qNum)
            {
                case 1:
                    this.Q_first1 = qFirst;
                    this.Q_sec1 = qSec;
                    this.Q_RightUp1 = qUp;
                    this.MyUpAnswer1 = myUp;
                    this.Q_RightAnswer1 = rightAnswer;
                    this.MyAnswer1 = myAnswer;
                    break;
                case 2:
                    this.Q_first2 = qFirst;
                    this.Q_sec2 = qSec;
                    this.Q_RightUp2 = qUp;
                    this.MyUpAnswer2 = myUp;
                    this.Q_RightAnswer2 = rightAnswer;
                    this.MyAnswer2 = myAnswer;
                    break;
                case 3:
                    this.Q_first3 = qFirst;
                    this.Q_sec3 = qSec;
                    this.Q_RightUp3 = qUp;
                    this.MyUpAnswer3 = myUp;
                    this.Q_RightAnswer3 = rightAnswer;
                    this.MyAnswer3 = myAnswer;
                    break;
                case 4:
                    this.Q_first4 = qFirst;
                    this.Q_sec4 = qSec;
                    this.Q_RightUp4 = qUp;
                    this.MyUpAnswer4 = myUp;
                    this.Q_RightAnswer4 = rightAnswer;
                    this.MyAnswer4 = myAnswer;
                    break;
                case 5:
                    this.Q_first5 = qFirst;
                    this.Q_sec5 = qSec;
                    this.Q_RightUp5 = qUp;
                    this.MyUpAnswer5 = myUp;
                    this.Q_RightAnswer5 = rightAnswer;
                    this.MyAnswer5 = myAnswer;
                    break;
                case 6:
                    this.Q_first6 = qFirst;
                    this.Q_sec6 = qSec;
                    this.Q_RightUp6 = qUp;
                    this.MyUpAnswer6 = myUp;
                    this.Q_RightAnswer6 = rightAnswer;
                    this.MyAnswer6 = myAnswer;
                    break;
                case 7:
                    this.Q_first7 = qFirst;
                    this.Q_sec7 = qSec;
                    this.Q_RightUp7 = qUp;
                    this.MyUpAnswer7 = myUp;
                    this.Q_RightAnswer7 = rightAnswer;
                    this.MyAnswer7 = myAnswer;
                    break;
                case 8:
                    this.Q_first8 = qFirst;
                    this.Q_sec8 = qSec;
                    this.Q_RightUp8 = qUp;
                    this.MyUpAnswer8 = myUp;
                    this.Q_RightAnswer8 = rightAnswer;
                    this.MyAnswer8 = myAnswer;
                    break;
                case 9:
                    this.Q_first9 = qFirst;
                    this.Q_sec9 = qSec;
                    this.Q_RightUp9 = qUp;
                    this.MyUpAnswer9 = myUp;
                    this.Q_RightAnswer9 = rightAnswer;
                    this.MyAnswer9 = myAnswer;
                    break;
                case 10:
                    this.Q_first10 = qFirst;
                    this.Q_sec10 = qSec;
                    this.Q_RightUp10 = qUp;
                    this.MyUpAnswer10 = myUp;
                    this.Q_RightAnswer10 = rightAnswer;
                    this.MyAnswer10 = myAnswer;
                    break;
            }
        }
#endif
    }
}
