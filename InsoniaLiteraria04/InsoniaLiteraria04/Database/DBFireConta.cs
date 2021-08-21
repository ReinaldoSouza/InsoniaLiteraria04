using Firebase.Storage;
using Firebase.Xamarin.Auth;
using Firebase.Xamarin.Database;
using FireSharp.Interfaces;
using FireSharp.Response;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reactive.Linq;
using System.Threading.Tasks;

namespace InsoniaLiteraria04.Database
{
    public class DBFireConta
    {
        public FirebaseClient fbCliente;
        public FirebaseAuth firebaseAuth;
        public FirebaseAuthProvider firebaseProvider;
        const string CONFIG_KEY = "AIzaSyA_1DIKQWRzxIR_irLqGL6lduZPu5Fwobk";
        public IFirebaseConfig config;
        public IFirebaseClient client;

        public FirebaseStorage firebaseStorage;

        public DBFireConta()
        {
            fbCliente = new FirebaseClient("https://insonialiteraria-d64ae.firebaseio.com/");
            firebaseAuth = new FirebaseAuth();
            firebaseProvider = new FirebaseAuthProvider(new Firebase.Xamarin.Auth.FirebaseConfig(CONFIG_KEY));
            firebaseStorage = new FirebaseStorage("insonialiteraria-d64ae.appspot.com");
            config = new FireSharp.Config.FirebaseConfig {
                AuthSecret = "nPuuirPDqZdK8cu50uVjPF0yWGENgYsE8t7JKWmY",
                BasePath = "https://insonialiteraria-d64ae.firebaseio.com/"
            };
            client = new FireSharp.FirebaseClient(config);

        }

        //area do criar conta, login, resetar senha, alterar dados

        public async Task criarConta(string usuario, Usuario user)
        {
            await fbCliente.Child("/Usuarios/" + usuario)
                .PatchAsync(user);
        }

        public async Task resetarSenha(Informacoes_Senha senha)
        {
            await fbCliente.Child("/INFORMACAO_SENHA/")
                .PostAsync(senha);
        }

        public async Task excluirConta(ExcluirConta excluir)
        {
            await fbCliente.Child("/USUARIOS_EXCLUIDOS/")
                .PostAsync(excluir);
        }

        public async Task createUser(string nome, string password)
        {
            var user = await App.firebaseAuthProvider.CreateUserWithEmailAndPasswordAsync(nome, password);
            UserLocalData.userToken = user.FirebaseToken;
            UserLocalData.userEmail = user.User.Email;
            UserLocalData.userUID = user.User.LocalId;
           
        }

        public async Task authUser(string nome, string password)
        {
            var user = await App.firebaseAuthProvider.SignInWithEmailAndPasswordAsync(nome, password);
            UserLocalData.userToken = user.FirebaseToken;
            UserLocalData.userEmail = user.User.Email;
            UserLocalData.userUID = user.User.LocalId;

        }

        public async Task<Versao> mostrarVersao()
        {
            try
            {
                var item = await fbCliente.Child("/Versao/")
                                .OnceSingleAsync<Versao>();
                return item;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task salvarVersaoApp(Versao_App versao, string usuario, string versao_app)
        {
            try
            {
                await fbCliente.Child("/APLICATIVO_VERSAO/" + "/" + versao_app + "/" + usuario)
                .PatchAsync(versao);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
            

    }
}
