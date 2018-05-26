using ElectionTimeInfoApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ElectionTimeInfoApp.ViewModels
{
    public class CandidateViewModel : INotifyPropertyChanged
    {
        Candidate _candidate;

        public string Name {
            get {
                return _candidate.Name;
            }
            set {
                _candidate.Name = value;
                RaisePropertyChanged("Name");
            }
        }

        public CandidateViewModel(Candidate c)
        {
            _candidate = c;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
