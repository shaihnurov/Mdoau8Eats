using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace Mdoau8Eats
{
    public partial class App : Application
    {
        public const string DATABASE_NAME = "eats.db";
        public static EatRepository database;
        public static EatRepository Database
        {
            get
            {
                if (database == null)
                {
                    database = new EatRepository(
                        Path.Combine(
                            Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
