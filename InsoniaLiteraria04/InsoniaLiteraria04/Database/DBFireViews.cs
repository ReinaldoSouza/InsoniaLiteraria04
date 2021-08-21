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
using InsoniaLiteraria04.Model;
using Newtonsoft.Json;

namespace InsoniaLiteraria04.Database
{
    public class DBFireViews
    {
        public FirebaseClient fbCliente;
        public FirebaseAuth firebaseAuth;
        public FirebaseAuthProvider firebaseProvider;
        const string CONFIG_KEY = "AIzaSyA_1DIKQWRzxIR_irLqGL6lduZPu5Fwobk";
        public IFirebaseConfig config;
        public IFirebaseClient client;

        public FirebaseStorage firebaseStorage;

        public DBFireViews()
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

        public async Task<QuantidadeViews> mostrarQuantidadeView(string historia, string id)
        {
            try
            {
                var item = await fbCliente.Child("/Quantidade_Views/" + historia + "/" + id)
                                .OnceSingleAsync<QuantidadeViews>();
                return item;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<QuantidadeViewsTotal> mostrarQuantidadeViewTotal(string historia)
        {
            try
            {
                var item = await fbCliente.Child("/Quantidade_Views_Total/" + historia)
                    .OnceSingleAsync<QuantidadeViewsTotal>();
                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<QuantidadeViews>> mostrarQuantidadeCapitulo(string historia)
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("/Quantidade_Views/" + historia);
                var myJson = response.Body;

                var list = JsonConvert.DeserializeObject<List<QuantidadeViews>>(myJson).ToList();

                return list;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task SomarViews(QuantidadeViews views, string historia, string id)
        {
            try
            {
                await fbCliente.Child("/Quantidade_Views/" + historia + "/" + id)
                    .PatchAsync(views);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task SomarViewsTotal(QuantidadeViewsTotal view, string historia)
        {
            try
            {
                await fbCliente.Child("/Quantidade_Views_Total/" + historia)
                    .PatchAsync(view);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

    }
}
