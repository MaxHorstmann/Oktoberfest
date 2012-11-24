using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace Oktoberfest
{
    public class ItemViewModel : INotifyPropertyChanged
    {
        private string _englishPhrase;
        /// <summary>
        /// Sample ViewModel property; this property is used in the view to display its value using a Binding.
        /// </summary>
        /// <returns></returns>
        public string EnglishPhrase
        {
            get
            {
                return _englishPhrase;
            }
            set
            {
                if (value != _englishPhrase)
                {
                    _englishPhrase = value;
                    NotifyPropertyChanged("EnglishPhrase");
                }
            }
        }


        private string _germanPhrase;
        public string GermanPhrase
        {
            get
            {
                return _germanPhrase;
            }
            set
            {
                if (value != _germanPhrase)
                {
                    _germanPhrase = value;
                    NotifyPropertyChanged("GermanPhrase");

                }

            }

        }
      
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}