using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Mdoau8Eats
{
    public partial class SettingEatPage : ContentPage
    {
        public SettingEatPage()
        {
            InitializeComponent();
        }

        private async void SaveFriend(object sender, EventArgs e)
        {
            var friend = (DataEat)BindingContext;
            if (!String.IsNullOrEmpty(friend.Name))
            {
                App.Database.SaveItem(friend);
            }
            await Navigation.PushAsync(new MainPage());
        }
        private void DeleteFriend(object sender, EventArgs e)
        {
            var friend = (DataEat)BindingContext;
            App.Database.DeleteItem(friend.Id);
            this.Navigation.PopAsync();
        }
        private void Cancel(object sender, EventArgs e)
        {
            this.Navigation.PopAsync();
        }
    }
}