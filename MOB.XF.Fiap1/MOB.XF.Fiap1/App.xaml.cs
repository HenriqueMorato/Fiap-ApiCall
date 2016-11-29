using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace MOB.XF.Fiap1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            //MainPage = new MOB.XF.Fiap1.View.Usuario.LoginView();
            MainPage = new NavigationPage(new View.Usuario.HomeView());
            //MainPage = new NavigationPage(new View.Usuario.UserListView());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
