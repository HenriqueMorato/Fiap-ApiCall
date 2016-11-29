using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MOB.XF.Fiap1.View.Home
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected void Voltar_Click(object sender, EventArgs args)
        {
            Navigation.PopAsync();
        }
    }
}
