using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Storage;
using Firebase.Xamarin.Auth;
using Firebase.Xamarin.Database;
using FireSharp.Interfaces;
using FireSharp.Response;
using InsoniaLiteraria04.Constantes;
using InsoniaLiteraria04.Model;
using Newtonsoft.Json;

namespace InsoniaLiteraria04.Database
{
    public class DBFireCapitulos
    {
        public FirebaseClient fbCliente;
        public FirebaseAuth firebaseAuth;
        public FirebaseAuthProvider firebaseProvider;
        const string CONFIG_KEY = "AIzaSyA_1DIKQWRzxIR_irLqGL6lduZPu5Fwobk";
        public IFirebaseConfig config;
        public IFirebaseClient client;

        public FirebaseStorage firebaseStorage;

        public DBFireCapitulos()
        {
            fbCliente = new FirebaseClient("https://insonialiteraria-d64ae.firebaseio.com/");
            firebaseAuth = new FirebaseAuth();
            firebaseProvider = new FirebaseAuthProvider(new Firebase.Xamarin.Auth.FirebaseConfig(CONFIG_KEY));
            firebaseStorage = new FirebaseStorage("insonialiteraria-d64ae.appspot.com");
            config = new FireSharp.Config.FirebaseConfig
            {
                AuthSecret = "nPuuirPDqZdK8cu50uVjPF0yWGENgYsE8t7JKWmY",
                BasePath = "https://insonialiteraria-d64ae.firebaseio.com/"
            };
            client = new FireSharp.FirebaseClient(config);
        }

        public async Task salvarCapitulo(CapituloLido lido, string usuario, string historia, string id)
        {
            try
            {
                await fbCliente.Child("/Capitulo_Lido/" + usuario + '/' + historia + "/" + id)
               .PatchAsync(lido);
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<CapituloLido>> proximoCapitulo(string usuario, string historia)
        {
            try
            {
                var list = (await fbCliente.Child("/Capitulo_Lido/" + usuario + "/" + historia)
                    .OnceAsync<CapituloLido>())
                    .Select(item =>
                        new CapituloLido
                        {
                            Lido = item.Object.Lido,
                            Capitulo = item.Object.Capitulo
                        }
                        ).ToList();

                return list;
            } catch(Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CapituloLido> mostrarStatusCapitulo(string historia, string id, string usuario)
        {
            try
            {
                var item = await fbCliente.Child("/Capitulo_Lido/" + usuario + '/' + historia + "/" + id)
                                .OnceSingleAsync<CapituloLido>();
                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Historias> carregarCapitulo (string Autor, string historia, string capitulo)
        {
            try
            {
                var leitura = await fbCliente.Child("/HISTORIAS/" + Autor + '/' + historia + '/' + capitulo)
                            .OnceSingleAsync<Historias>();

                return leitura;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task resetarSerie(string usuario, string historia)
        {
            try
            {
                await fbCliente.Child("/Capitulo_Lido/" + usuario + '/' + historia).DeleteAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<CapsConstantes> carregarCapituloConstante()
        {
            try
            {
                var leitura = await fbCliente.Child("/Constantes_Capitulos/")
                            .OnceSingleAsync<CapsConstantes>();

                return leitura;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
