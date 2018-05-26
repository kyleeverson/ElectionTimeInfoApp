﻿using ElectionTimeInfoApp.ViewModels;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ElectionTimeInfoApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CandidateListViewPage : ContentPage
    {
        public ObservableCollection<string> Items { get; set; }

        public CandidateListViewPage()
        {
            CandidateListViewModel vm = new CandidateListViewModel();
            InitializeComponent();
            BindingContext = vm;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null) {
                return;
            }

            var vm = e.Item as CandidateViewModel;
            var newPage = new CandidateTwitterViewPage();
            newPage.BindingContext = vm;
            await Navigation.PushAsync(newPage);

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
