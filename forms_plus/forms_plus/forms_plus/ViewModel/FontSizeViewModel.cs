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
            _questionUpfontSize = (DeviceDisplay.MainDisplayInfo.Height > 1280) ? 25 : 20;
            _questionNumFontSize = (DeviceDisplay.MainDisplayInfo.Height > 1280) ? 20 : 15;
            _questionFontSize = (DeviceDisplay.MainDisplayInfo.Height > 1280) ? 40 : 35;
            _answerFontSize = (DeviceDisplay.MainDisplayInfo.Height > 1280) ? 32 : 27;
        }

        private int? _questionUpfontSize;
        public int? QuestionUpfontSize
        {
            get
            {
                return _questionUpfontSize;                
            }
            set
            {
                _questionUpfontSize = value;
                FontNotifyPropertyChanged(nameof(QuestionUpfontSize));
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

        private int? _answerFontSize;
        public int? AnswerFontSize
        {
            get
            {
                return _answerFontSize;
            }
            set
            {
                _answerFontSize = value;
                FontNotifyPropertyChanged(nameof(AnswerFontSize));
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
    }

   
}
