﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.XF.Fiap1.View.Usuario
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        protected void Autenticar_Clicked(object sender, EventArgs args)
        {
            Navigation.PushAsync(new View.Home.MainPage());
        }
    }
}
