using PokedexMVVM.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PokedexMVVM
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage (new Registrarpokemon());
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
