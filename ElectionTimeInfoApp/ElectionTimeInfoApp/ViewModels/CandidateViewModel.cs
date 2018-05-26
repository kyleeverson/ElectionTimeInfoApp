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

        public string Name => _candidate.Name;

        public string TwitterHandle => _candidate.TwitterHandle;

        public CandidateViewModel(Candidate c) => _candidate = c;

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
