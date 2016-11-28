using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace MOB.XF.Fiap1.Model
{
    class UsuarioModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string NickNome { get; set; }
        //[JsonProperty("Senha")]
        public string Senha { get; set; }
        public bool Ativo { get; set; }

        public static class UsuarioRepository
        {
            private static List<UsuarioModel> usuarioSqlAzure;

            public static async Task<List<UsuarioModel>> GetUsuariosSqlAzure ()
            {
                if (usuarioSqlAzure != null) return usuarioSqlAzure;


                var httpRequest = new HttpClient();
                var stream = await httpRequest.GetStreamAsync(
                    "http://apiauthmobflaviosm.azurewebsites.net/api/usuarios");

                var usuarioSerializer = new DataContractJsonSerializer(typeof(List<UsuarioModel>));
                usuarioSqlAzure = (List<UsuarioModel>)usuarioSerializer.ReadObject(stream);

                return usuarioSqlAzure;
            }
        }
    }
}
