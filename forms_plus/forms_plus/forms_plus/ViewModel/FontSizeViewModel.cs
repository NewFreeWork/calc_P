using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

using Xamarin.Forms;
using Xamarin.Essentials;
namespace forms_plus.ViewModel
{
    public class FontBaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void FontNotifyPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
    public class FontSizeViewModel : FontBaseViewModel
    {
        public FontSizeViewModel()
       {
            if (DeviceDisplay.MainDisplayInfo.Height >= 2000)
            {
                _questionUpBtnfontSize = 25;
                _questionBtnfontSize = 37;
                _questionNumFontSize = 30;
                _questionFontSize = 45;
                _naviButtonFontSize = 27;
                _ansAnsButtonFontSize = 37;
                _detailSheetTextSize = 30;

                _mainTitleFontSize_S = 80;
                _mainTitleFontSize_M = 90;
                _mainTitleFontSize_L = 100;
                _entryTextSize = 23;

                _answerSheetTitleSize = 50;
                _answerSheetQ_Size = 30;
                _answerSheetScoreSize = 30;
                _answerSheetTimeSize = 25;
                _answerSheetBackBtnSize = 21;
            }
            else if (DeviceDisplay.MainDisplayInfo.Height > 1280)
            {
                _questionUpBtnfontSize = 22;
                _questionBtnfontSize = 32;
                _questionNumFontSize = 25;
                _questionFontSize = 40;
                _naviButtonFontSize = 22;
                _ansAnsButtonFontSize = 32;
                _detailSheetTextSize = 23;

                _mainTitleFontSize_S = 60;
                _mainTitleFontSize_M = 70;
                _mainTitleFontSize_L = 80;
                _entryTextSize = 18;

                _answerSheetTitleSize = 40;
                _answerSheetQ_Size = 25;
                _answerSheetScoreSize = 25;
                _answerSheetTimeSize = 20;
                _answerSheetBackBtnSize = 16;
            }
            else if (DeviceDisplay.MainDisplayInfo.Height > 800)
            {
                _questionUpBtnfontSize = 20;
                _questionBtnfontSize = 32;
                _questionNumFontSize = 20;
                _questionFontSize = 35;
                _naviButtonFontSize = 18;
                _ansAnsButtonFontSize = 27;
                _detailSheetTextSize = 20;

                _mainTitleFontSize_S = 50;
                _mainTitleFontSize_M = 60;
                _mainTitleFontSize_L = 70;
                _entryTextSize = 16;

                _answerSheetTitleSize = 35;
                _answerSheetQ_Size = 25;
                _answerSheetScoreSize = 25;
                _answerSheetTimeSize = 20;
                _answerSheetBackBtnSize = 13;
            }
            else
            {
                _questionUpBtnfontSize = 20;
                _questionBtnfontSize = 25;
                _questionNumFontSize = 18;
                _questionFontSize = 30;
                _naviButtonFontSize = 16;
                _ansAnsButtonFontSize = 20;
                _detailSheetTextSize = 18;

                _mainTitleFontSize_S = 40;
                _mainTitleFontSize_M = 50;
                _mainTitleFontSize_L = 60;
                _entryTextSize = 15;

                _answerSheetTitleSize = 30;
                _answerSheetQ_Size = 20;
                _answerSheetScoreSize = 22;
                _answerSheetTimeSize = 18;
                _answerSheetBackBtnSize = 11;
            }
        }

        private int? _answerSheetTitleSize;
        public int? AnswerSheetTitleSize
        {
            get
            {
                return _answerSheetTitleSize;
            }
            set
            {
                _answerSheetTitleSize = value;
                FontNotifyPropertyChanged(nameof(AnswerSheetTitleSize));
            }
        }
        private int? _answerSheetQ_Size;
        public int? AnswerSheetQ_Size
        {
            get
            {
                return _answerSheetQ_Size;
            }
            set
            {
                _answerSheetQ_Size = value;
                FontNotifyPropertyChanged(nameof(AnswerSheetQ_Size));
            }
        }
        private int? _answerSheetScoreSize;
        public int? AnswerSheetScoreSize
        {
            get
            {
                return _answerSheetScoreSize;
            }
            set
            {
                _answerSheetScoreSize = value;
                FontNotifyPropertyChanged(nameof(AnswerSheetScoreSize));
            }
        }
        private int? _answerSheetTimeSize;
        public int? AnswerSheetTimeSize
        {
            get
            {
                return _answerSheetTimeSize;
            }
            set
            {
                _answerSheetTimeSize = value;
                FontNotifyPropertyChanged(nameof(AnswerSheetTimeSize));
            }
        }

        private int? _answerSheetBackBtnSize;
        public int? AnswerSheetBackBtnSize
        {
            get
            {
                return _answerSheetBackBtnSize;
            }
            set
            {
                _answerSheetBackBtnSize = value;
                FontNotifyPropertyChanged(nameof(AnswerSheetBackBtnSize));
            }
        }

        private int? _questionUpBtnfontSize;
        public int? QuestionUpBtnfontSize
        {
            get
            {
                return _questionUpBtnfontSize;
            }
            set
            {
                _questionUpBtnfontSize = value;
                FontNotifyPropertyChanged(nameof(QuestionUpBtnfontSize));
            }
        }

        private int? _questionBtnfontSize;
        public int? QuestionBtnfontSize
        {
            get
            {
                return _questionBtnfontSize;                
            }
            set
            {
                _questionBtnfontSize = value;
                FontNotifyPropertyChanged(nameof(QuestionBtnfontSize));
            }
        }

        private int? _questionFontSize;
        public int? QuestionFontSize
        {
            get
            {
                return _questionFontSize;
            }
            set
            {
                _questionFontSize = value;
                FontNotifyPropertyChanged(nameof(QuestionFontSize));
            }
        }

        private int? _ansAnsButtonFontSize;
        public int? AnsButtonFontSize
        {
            get
            {
                return _ansAnsButtonFontSize;
            }
            set
            {
                _ansAnsButtonFontSize = value;
                FontNotifyPropertyChanged(nameof(AnsButtonFontSize));
            }
        }

        private int? _detailSheetTextSize;
        public int? DetailSheetTextSize
        {
            get
            {
                return _detailSheetTextSize;
            }
            set
            {
                _detailSheetTextSize = value;
                FontNotifyPropertyChanged(nameof(DetailSheetTextSize));
            }
        }

        private int? _naviButtonFontSize;
        public int? NaviButtonFontSize
        {
            get
            {
                return _naviButtonFontSize;
            }
            set
            {
                _naviButtonFontSize = value;
                FontNotifyPropertyChanged(nameof(NaviButtonFontSize));
            }
        }

        private int? _questionNumFontSize;
        public int? QuestionNumFontSize
        {
            get
            {
                return _questionNumFontSize;
            }
            set
            {
                _questionNumFontSize = value;
                FontNotifyPropertyChanged(nameof(QuestionNumFontSize));
            }
        }

        private int? _mainTitleFontSize_S;
        public int? MainTitleFontSize_S
        {
            get
            {
                return _mainTitleFontSize_S;
            }
            set
            {
                _mainTitleFontSize_S = value;
                FontNotifyPropertyChanged(nameof(MainTitleFontSize_S));
            }
        }
        private int? _mainTitleFontSize_M;
        public int? MainTitleFontSize_M
        {
            get
            {
                return _mainTitleFontSize_M;
            }
            set
            {
                _mainTitleFontSize_M = value;
                FontNotifyPropertyChanged(nameof(MainTitleFontSize_M));
            }
        }
        private int? _mainTitleFontSize_L;
        public int? MainTitleFontSize_L
        {
            get
            {
                return _mainTitleFontSize_L;
            }
            set
            {
                _mainTitleFontSize_L = value;
                FontNotifyPropertyChanged(nameof(MainTitleFontSize_L));
            }
        }

        private int? _entryTextSize;
        public int? EntryTextSize
        {
            get
            {
                return _entryTextSize;
            }
            set
            {
                _entryTextSize = value;
                FontNotifyPropertyChanged(nameof(EntryTextSize));
            }
        }
    }

   
}
