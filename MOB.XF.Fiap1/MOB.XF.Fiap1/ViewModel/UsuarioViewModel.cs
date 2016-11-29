using MOB.XF.Fiap1.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MOB.XF.Fiap1.Model.UsuarioModel;

namespace MOB.XF.Fiap1.ViewModel
{
    class UsuarioViewModel
    {
        public List<UsuarioModel> CopiaUsuario = new List<UsuarioModel>();

        public ObservableCollection<UsuarioModel> Usuarios { get; set; } = new ObservableCollection<UsuarioModel>();

        public UsuarioViewModel()
        {
            LoadUsuarios();
        }

        private async void LoadUsuarios()
        {
            CopiaUsuario = await UsuarioRepository.GetUsuariosSqlAzure();
            ExecutarFiltro();
        }

        private void ExecutarFiltro()
        {
            for (int i = 0; i < CopiaUsuario.Count; i++)
            {
                var item = CopiaUsuario[i];
                if (i + 1 > Usuarios.Count || !Usuarios[i].Equals(item))
                    Usuarios.Insert(i, item);
            }
        }
    }
}
