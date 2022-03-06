using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace input
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            //MainPage = new ActivityIndicator();
            //MainPage = new imageButton();
            //MainPage = new Editor();
            MainPage = new RockPaperScissor();
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
