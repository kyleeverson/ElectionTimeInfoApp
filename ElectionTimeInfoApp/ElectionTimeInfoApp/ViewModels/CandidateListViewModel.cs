using ElectionTimeInfoApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace ElectionTimeInfoApp.ViewModels
{
    class CandidateListViewModel : INotifyPropertyChanged
    {
        ObservableCollection<CandidateViewModel> _items;
        public ObservableCollection<CandidateViewModel> Items {
            get {
                return _items;
            }
            set {
                _items = value;
                RaisePropertyChanged("Items");
            }
        }

        public CandidateListViewModel()
        {
            _items = new ObservableCollection<CandidateViewModel>();

            var candidate1 = new Candidate {
                Name = "Kate Brown",
                TwitterHandle = "@KateBrownForOR"
            };
            var candidateViewModel1 = new CandidateViewModel(candidate1);
            _items.Add(candidateViewModel1);
            var candidate2 = new Candidate {
                Name = "Knute Buehler",
                TwitterHandle = "@KnuteBuehler"

            };
            var candidateViewModel2 = new CandidateViewModel(candidate2);
            _items.Add(candidateViewModel2);
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisePropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
