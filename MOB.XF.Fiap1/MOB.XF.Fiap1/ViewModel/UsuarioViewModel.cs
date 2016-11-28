using MOB.XF.Fiap1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MOB.XF.Fiap1.ViewModel
{
    class UsuarioViewModel
    {
        public List<UsuarioModel> CopiaUsuario = new List<UsuarioModel>();

        public ObservableCollection<UsuarioModel> Usuario { get; set; } = new ObservableCollection<UsuarioModel>();

        public UsuarioViewModel()
        {
            LoadUsuarios();
        }

        private void LoadUsuarios()
        {
            throw new NotImplementedException();
        }
    }
}
