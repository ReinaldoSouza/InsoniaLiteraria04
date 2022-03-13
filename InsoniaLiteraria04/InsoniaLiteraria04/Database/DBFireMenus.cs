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
using InsoniaLiteraria04.Global;
using InsoniaLiteraria04.Model;
using Newtonsoft.Json;

namespace InsoniaLiteraria04.Database
{
    public class DBFireMenus
    {
        public FirebaseClient fbCliente;
        public FirebaseAuth firebaseAuth;
        public FirebaseAuthProvider firebaseProvider;
        const string CONFIG_KEY = "AIzaSyA_1DIKQWRzxIR_irLqGL6lduZPu5Fwobk";
        public IFirebaseConfig config;
        public IFirebaseClient client;

        public FirebaseStorage firebaseStorage;

        public DBFireMenus()
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

        public async Task<List<Menu>> mostrarMenu(string historia)
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("/MENUS/" + historia);
                var myJson = response.Body;

                var list = JsonConvert.DeserializeObject<List<Menu>>(myJson).ToList();

                return list;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
