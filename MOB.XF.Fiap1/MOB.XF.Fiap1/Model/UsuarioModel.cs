using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;

namespace MOB.XF.Fiap1.Model
{
    //[DataContract]
    class UsuarioModel
    {
        //[JsonProperty(PropertyName = "Id")]
        public int Id { get; set; }
        //[JsonProperty(PropertyName = "Nome")]
        public string Nome { get; set; }
        //[JsonProperty(PropertyName ="NickNome")]
        public string NickName { get; set; }
        //[JsonProperty(PropertyName = "Senha")]
        public string Senha { get; set; }
        //[JsonProperty(PropertyName = "Ativo")]
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
