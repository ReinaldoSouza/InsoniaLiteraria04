using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Firebase.Storage;
using Firebase.Xamarin.Auth;
using Firebase.Xamarin.Database;
using FireSharp.Interfaces;
using FireSharp.Response;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using Newtonsoft.Json;

namespace InsoniaLiteraria04.Database
{
    public class DBFireUsuario
    {
        public FirebaseClient fbCliente;
        public FirebaseAuth firebaseAuth;
        public FirebaseAuthProvider firebaseProvider;
        const string CONFIG_KEY = "AIzaSyA_1DIKQWRzxIR_irLqGL6lduZPu5Fwobk";
        public IFirebaseConfig config;
        public IFirebaseClient client;

        public FirebaseStorage firebaseStorage;

        public DBFireUsuario()
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

        public async Task<Usuario> coletarDadosUsuario(string usuarioId)
        {
            try
            {

                var item = await fbCliente.Child("/Usuarios/" + usuarioId)
                                .OnceSingleAsync<Usuario>();
                return item;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Photos> mostrarFotoPerfil(string user)
        {
            try
            {
                var item = await fbCliente.Child("/Image_profile/" + user)
                                .OnceSingleAsync<Photos>();
                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task SalvarImagem(Stream imgStream, string fileName)
        {

            var imgUrl = await firebaseStorage
                .Child("IMAGEM_PERFIL")
                .Child(UserLocalData.userUID)
                .Child(fileName)
                .PutAsync(imgStream);

            var usuario = new Photos();

            usuario.ImageUrl = imgUrl;

            await fbCliente.Child("/Image_profile/" + UserLocalData.userUID)
                .PatchAsync(usuario);

        }

        public async Task AlterarPerfil(string usuario, Usuario user)
        {
            await fbCliente.Child("/Usuarios/" + usuario)
                .PatchAsync(user);
        }

        public async Task<List<Usuario>> mostrarUsuariosCadastrados()
        {
            try
            {
                var list = (await fbCliente.Child("/Usuarios/")
                            .OnceAsync<Usuario>())
                            .Select(item =>
                                    new Usuario
                                    {
                                        Username = item.Object.Username,
                                        Email = item.Object.Email,
                                        Nome = item.Object.Nome
                                    }
                            ).ToList();

                return list;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
