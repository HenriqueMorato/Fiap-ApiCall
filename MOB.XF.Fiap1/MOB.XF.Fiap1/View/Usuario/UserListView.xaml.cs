using MOB.XF.Fiap1.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace MOB.XF.Fiap1.View.Usuario
{
    public partial class UserListView : ContentPage
    {
        UsuarioViewModel usuarioVM;

        public UserListView()
        {
            usuarioVM = new UsuarioViewModel();
            BindingContext = usuarioVM;

            InitializeComponent();
        }
    }
}
