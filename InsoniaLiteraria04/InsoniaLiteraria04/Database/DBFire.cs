using Firebase.Storage;
using Firebase.Xamarin.Auth;
using Firebase.Xamarin.Database;
using InsoniaLiteraria04.Helper;
using InsoniaLiteraria04.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace InsoniaLiteraria04.Database
{
    public class DBFire
    {
        public FirebaseClient fbCliente;
        public FirebaseAuth firebaseAuth;
        public FirebaseAuthProvider firebaseProvider;
        const string CONFIG_KEY = "AIzaSyA_1DIKQWRzxIR_irLqGL6lduZPu5Fwobk";

        public FirebaseStorage firebaseStorage;

        public DBFire()
        {
            fbCliente = new FirebaseClient("https://insonialiteraria-d64ae.firebaseio.com/");
            firebaseAuth = new FirebaseAuth();
            firebaseProvider = new FirebaseAuthProvider(new FirebaseConfig(CONFIG_KEY));
            firebaseStorage = new FirebaseStorage("insonialiteraria-d64ae.appspot.com");
        }

        public async Task criarConta(string usuario, Usuario user)
        {
            await fbCliente.Child("/Usuarios/" + usuario)
                .PatchAsync(user);
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
            //todo base 64 user name and password
            var user = await App.firebaseAuthProvider.SignInWithEmailAndPasswordAsync(nome, password);
            UserLocalData.userToken = user.FirebaseToken;
            UserLocalData.userEmail = user.User.Email;
            UserLocalData.userUID = user.User.LocalId;
            //var usuario = user.FirebaseToken;

        }

        public async Task comentar(Comentarios comentario, string historia, string capitulo)
        {
            await fbCliente.Child("/Comentarios/"+ historia + "/"+capitulo)
                .PostAsync(comentario);
        }

        public async Task salvarCapitulo (CapituloLido lido, string usuario, string historia, string id)
        {
            await fbCliente.Child("/Capitulo_Lido/" + usuario + '/' + historia + "/" + id)
                .PatchAsync(lido);
        }

        public async Task SomarComentarios(QuantidadeComentario comentario, string historia)
        {
            await fbCliente.Child("/Quantidade_Comentario/" + historia)
                .PatchAsync(comentario);
        }

        public async Task SomarLeituras(QuantidadeLeituras leitura, string historia)
        {
            await fbCliente.Child("/Quantidade_Leituras/" + historia)
                .PatchAsync(leitura);
        }

        public async Task<QuantidadeComentario> mostrarQuantidadeMensagem(string historia)
        {
            try
            {
                var item = await fbCliente.Child("/Quantidade_Comentario/" + historia)
                                .OnceSingleAsync<QuantidadeComentario>();
                return item;

                //var list = (await fbCliente.Child("/Quantidade_Comentario/" + historia)
                //   .OnceAsync<QuantidadeComentario>())
                //   .Select(item =>
                //           new QuantidadeComentario
                //           {
                //               Historia = item.Object.Historia,
                //               Quantidade = Convert.ToInt32(item.Object.Quantidade)
                //           }
                //   ).ToList();

                //return list;
            } catch (Exception ex)
            {
                throw ex;
            }
               
            
        }

        public async Task<QuantidadeLeituras> mostrarQuantidadeLeituras(string historia)
        {
            try
            {
                var item = await fbCliente.Child("/Quantidade_Leituras/" + historia)
                                .OnceSingleAsync<QuantidadeLeituras>();
                return item;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task salvarIDNotificacao(Usuario_Notificacao notify, string usuario)
        {
            await fbCliente.Child("/Usuario_Notificacao/" + usuario)
                .PatchAsync(notify);
        }

        public async Task<List<CapituloLido>> proximoCapitulo(string usuario, string historia)
        {
            var list = (await fbCliente.Child("/Capitulo_Lido/" + usuario + "/" + historia)
                .OnceAsync<CapituloLido>())
                .Select(item =>
                    new CapituloLido
                    {
                        Lido = item.Object.Lido,
                        Capitulo = item.Object.Capitulo//item.Key.ToString()
                    }
                    ).ToList();

            return list;
        }

        public async Task<List<Comentarios>> mostrarComentarios(string historia, string capitulo)
        {
            var list = (await fbCliente.Child("/Comentarios/" + historia + "/" + capitulo)
                .OnceAsync<Comentarios>())
                .Select(item =>
                        new Comentarios
                        {
                            Usuario = item.Object.Usuario,
                            Mensagem = item.Object.Mensagem,
                            Data = item.Object.Data,
                        }
                ).ToList();

            return list;
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

        public async Task<string> mostrarUsuarioNome()
        {
            try
            {
                var item = await fbCliente.Child("/Usuarios/" + UserLocalData.userUID)
                                .OnceSingleAsync<Usuario>();
                return item.Nome;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> mostrarUsuarioUsername()
        {
            try
            {
                var item = await fbCliente.Child("/Usuarios/" + UserLocalData.userUID)
                                .OnceSingleAsync<Usuario>();
                return item.Username;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<string> mostrarUsuarioEmail()
        {
            try
            {
                var item = await fbCliente.Child("/Usuarios/" + UserLocalData.userUID)
                                .OnceSingleAsync<Usuario>();
                return item.Email;
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

        public async Task<Photos> mostrarFotoPerfil()
        {
            try
            {
                var item = await fbCliente.Child("/Image_profile/" + UserLocalData.userUID)
                                .OnceSingleAsync<Photos>();
                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Dashboard>> mostrarUsuariosLeituras()
        {
            try
            {
                var list = (await fbCliente.Child("/Capitulo_Lido/")
                               .OnceAsync<CapituloLido>())
                               .Select(item =>
                                       new Dashboard
                                       {
                                           Historia = item.Key.ToString(),
                                       }
                               ).ToList();

                return list;

            } catch (Exception ex)
            {
                throw ex;
            }
        }

        //public async Task<List<Dashboard>> mostrarRamoComentarios(string historia)
        //{
        //    var list = (await fbCliente.Child("/Comentarios/" + historia)
        //        .OnceAsync<Comentarios>())
        //        .Select(item =>
        //                new Dashboard
        //                {
        //                    Historia = item.Key.ToString(),
        //                }
        //        ).ToList();

        //    return list;
        //}

        public async Task<List<Dashboard>> mostrarDashboardLeituras( string usuario)
        {
            try
            {
                var list = (await fbCliente.Child("/Capitulo_Lido/" + usuario)
                               .OnceAsync<CapituloLido>())
                               .Select(item =>
                                       new Dashboard
                                       {
                                           Historia = item.Key.ToString(),
                                       }
                               ).ToList();

                return list;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //public async Task MudarSenha(string email)
        //{
        //    await App.firebaseAuthProvider.SendPasswordResetEmailAsync(email);
        //}

    }
}
