using SQLite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Mdoau8Eats
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            friendsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        private async void AddEatClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEatPage());
        }

        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DataEat selectedFriend = (DataEat)e.SelectedItem;
            EatPage eatPage = new EatPage();
            eatPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(eatPage);
        }
    }
}
