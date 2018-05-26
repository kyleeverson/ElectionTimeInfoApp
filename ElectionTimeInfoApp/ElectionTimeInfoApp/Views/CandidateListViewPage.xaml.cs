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
            InitializeComponent();

            Items = new ObservableCollection<string>
            {
                "Kate Brown",
                "Knute Buehler"
            };
			
			MyListView.ItemsSource = Items;
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            await DisplayAlert("Item Tapped", "An item was tapped.", "OK");

            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }
    }
}
