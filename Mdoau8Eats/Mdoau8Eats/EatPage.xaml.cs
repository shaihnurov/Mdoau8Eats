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
    public partial class EatPage : ContentPage
    {
        public EatPage()
        {
            InitializeComponent();
        }

        private void SaveFriend(object sender, EventArgs e)
        {
            var friend = (DataEat)BindingContext;
            if (!String.IsNullOrEmpty(friend.Name))
            {
                App.Database.SaveItem(friend);
            }
            this.Navigation.PopAsync();
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

        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                float Proteins = Convert.ToSingle(proteins.Text.Trim());
                float Fats = Convert.ToSingle(fats.Text.Trim());
                float Carbohy = Convert.ToSingle(carbohy.Text.Trim());
                double Kilocalories = Convert.ToDouble(kilocalories.Text.Trim());

                float Gramm = Convert.ToSingle(gramm.Text.Trim());

                var resultProteins = (float)Gramm * Proteins;
                var resultFats = (float)Gramm * Fats;
                var resultCarbohy = (float)Gramm * Carbohy;
                var resultKilocalories = (double)Gramm * Kilocalories;

                ProteinsResult.Text = "Рассчитанно белков ⇒ " + resultProteins.ToString();
                FatsResult.Text = "Рассчитанно жиров ⇒ " + resultFats.ToString();
                CarbohyResult.Text = "Рассчитанно углеводов ⇒ " + resultCarbohy.ToString();
                KilocaloriesResult.Text = "Рассчитанно килокалорий ⇒ " + resultKilocalories.ToString();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Ошибка", "Введите данные", "Повторить запрос");
            }
        }
    }
}