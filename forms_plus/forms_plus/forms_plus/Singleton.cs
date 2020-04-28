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

        public int DetailPageIndex;
        public string TotalTime;

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

            DetailPageIndex = 0;
            TotalTime = "00:00:000";
        }
        public void SetAnswerSheetsData(int qFirst, int qSec, int rightAnswer, int myAnswer, int qNum)
        {
            switch (qNum)
            {
                case 1:
                    this.Q_first1 = qFirst;
                    this.Q_sec1 = qSec;
                    this.Q_RightAnswer1 = rightAnswer;
                    this.MyAnswer1 = myAnswer;
                    break;
                case 2:
                    this.Q_first2 = qFirst;
                    this.Q_sec2 = qSec;
                    this.Q_RightAnswer2 = rightAnswer;
                    this.MyAnswer2 = myAnswer;
                    break;
                case 3:
                    this.Q_first3 = qFirst;
                    this.Q_sec3 = qSec;
                    this.Q_RightAnswer3 = rightAnswer;
                    this.MyAnswer3 = myAnswer;
                    break;
                case 4:
                    this.Q_first4 = qFirst;
                    this.Q_sec4 = qSec;
                    this.Q_RightAnswer4 = rightAnswer;
                    this.MyAnswer4 = myAnswer;
                    break;
                case 5:
                    this.Q_first5 = qFirst;
                    this.Q_sec5 = qSec;
                    this.Q_RightAnswer5 = rightAnswer;
                    this.MyAnswer5 = myAnswer;
                    break;
                case 6:
                    this.Q_first6 = qFirst;
                    this.Q_sec6 = qSec;
                    this.Q_RightAnswer6 = rightAnswer;
                    this.MyAnswer6 = myAnswer;
                    break;
                case 7:
                    this.Q_first7 = qFirst;
                    this.Q_sec7 = qSec;
                    this.Q_RightAnswer7 = rightAnswer;
                    this.MyAnswer7 = myAnswer;
                    break;
                case 8:
                    this.Q_first8 = qFirst;
                    this.Q_sec8 = qSec;
                    this.Q_RightAnswer8 = rightAnswer;
                    this.MyAnswer8 = myAnswer;
                    break;
                case 9:
                    this.Q_first9 = qFirst;
                    this.Q_sec9 = qSec;
                    this.Q_RightAnswer9 = rightAnswer;
                    this.MyAnswer9 = myAnswer;
                    break;
                case 10:
                    this.Q_first10 = qFirst;
                    this.Q_sec10 = qSec;
                    this.Q_RightAnswer10 = rightAnswer;
                    this.MyAnswer10 = myAnswer;
                    break;
            }
        }
    }
}
