using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mdoau8Eats
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddEatPage : ContentPage
    {
        public AddEatPage()
        {
            InitializeComponent();
        }
        protected override void OnAppearing()
        {
            friendsList.ItemsSource = App.Database.GetItems();
            base.OnAppearing();
        }
        // обработка нажатия элемента в списке
        private async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            DataEat selectedFriend = (DataEat)e.SelectedItem;
            SettingEatPage settingEatPage = new SettingEatPage();
            settingEatPage.BindingContext = selectedFriend;
            await Navigation.PushAsync(settingEatPage);
        }
        // обработка нажатия кнопки добавления
        private async void CreateFriend(object sender, EventArgs e)
        {
            DataEat friend = new DataEat();
            SettingEatPage settingEatPage = new SettingEatPage();
            settingEatPage.BindingContext = friend;
            await Navigation.PushAsync(settingEatPage);
        }
    }
}