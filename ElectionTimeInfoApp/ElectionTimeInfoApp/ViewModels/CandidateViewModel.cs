using ElectionTimeInfoApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Forms;

namespace ElectionTimeInfoApp.ViewModels
{
    public class CandidateViewModel : INotifyPropertyChanged
    {
        Candidate _candidate;

        public string Name => _candidate.Name;

        public string TwitterHandle => _candidate.TwitterHandle;

        UrlWebViewSource _urlSource;
        public UrlWebViewSource URLSource {
            get {
                if (_urlSource == null) {
                    _urlSource = new UrlWebViewSource { Url = string.Format("https://twitter.com/{0}", _candidate.TwitterHandle) };
                }
                return _urlSource;
            }
        }

        public CandidateViewModel(Candidate c) => _candidate = c;

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
