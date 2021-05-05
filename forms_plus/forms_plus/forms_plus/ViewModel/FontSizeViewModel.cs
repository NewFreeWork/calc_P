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

            double density = DeviceDisplay.MainDisplayInfo.Density;
            double width = DeviceDisplay.MainDisplayInfo.Width;
            double height = DeviceDisplay.MainDisplayInfo.Height;

            int standardSize_X = (int)(width / density);
            int standardSize_Y = (int)(height / density);


            _questionUpBtnfontSize = (standardSize_X / 18);
            _questionBtnfontSize = (standardSize_X / 12);
            _questionNumFontSize = (standardSize_X / 22);
            _questionFontSize = (standardSize_X / 12);
            _naviButtonFontSize = (standardSize_X / 22);
            _ansAnsButtonFontSize = (standardSize_X / 20);
            _detailSheetTextSize = (standardSize_X / 16);

            _mainTitleFontSize_S = (standardSize_X / 12);
            _mainTitleFontSize_M = (standardSize_X / 10);
            _mainTitleFontSize_L = (standardSize_X / 8);
            _entryTextSize = (standardSize_X / 22);
            _copyrightTextSize = (standardSize_X / 26);
            _settingTextSize = (standardSize_X / 24);

            _answerSheetTitleSize = (standardSize_X / 15);
            _answerSheetQ_Size = (standardSize_X / 16);
            _answerSheetScoreSize = (standardSize_X / 16);
            _answerSheetTimeSize = (standardSize_X / 16);
            _answerSheetBackBtnSize = (standardSize_X / 18);

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

        private int? _copyrightTextSize;
        public int? CopyRightTextSize
        {
            get
            {
                return _copyrightTextSize;
            }
            set
            {
                _copyrightTextSize = value;
                FontNotifyPropertyChanged(nameof(CopyRightTextSize));
            }
        }

        private int? _settingTextSize;
        public int? SettingTextSize
        {
            get
            {
                return _settingTextSize;
            }
            set
            {
                _settingTextSize = value;
                FontNotifyPropertyChanged(nameof(SettingTextSize));
            }
        }
    }

   
}
