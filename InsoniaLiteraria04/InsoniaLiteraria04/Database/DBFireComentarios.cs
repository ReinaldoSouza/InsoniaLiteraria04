using Firebase.Storage;
using Firebase.Xamarin.Auth;
using Firebase.Xamarin.Database;
using FireSharp.Interfaces;
using FireSharp.Response;
using InsoniaLiteraria04.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InsoniaLiteraria04.Database
{
    public class DBFireComentarios
    {
        public FirebaseClient fbCliente;
        public FirebaseAuth firebaseAuth;
        public FirebaseAuthProvider firebaseProvider;
        const string CONFIG_KEY = "AIzaSyA_1DIKQWRzxIR_irLqGL6lduZPu5Fwobk";
        public IFirebaseConfig config;
        public IFirebaseClient client;

        public FirebaseStorage firebaseStorage;

        public DBFireComentarios()
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

        //Métodos referente a Comentários

        public async Task comentar(Comentarios comentario, string historia, string capitulo)
        {
            try
            {
                await fbCliente.Child("/Comentarios/" + historia + "/" + capitulo)
                .PostAsync(comentario);
            } catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task ExcluirComentar(string historia, string capitulo, string IdComentario)
        {
            try
            {
                var toDeleteComentario = (await fbCliente.Child("/Comentarios/" + historia + "/" + capitulo)
            .OnceAsync<Comentarios>()).Where(a => a.Object.Id == IdComentario).FirstOrDefault();

                await fbCliente.Child("/Comentarios/" + historia + "/" + capitulo + "/" + toDeleteComentario.Key.ToString()).DeleteAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Comentarios>> mostrarComentarios(string historia, string capitulo)
        {
            try
            {
                var list = (await fbCliente.Child("/Comentarios/" + historia + "/" + capitulo)
                            .OnceAsync<Comentarios>())
                            .Select(item =>
                                    new Comentarios
                                    {
                                        Id = item.Object.Id,
                                        Usuario_id = item.Object.Usuario_id,
                                        Usuario = item.Object.Usuario,
                                        Mensagem = item.Object.Mensagem,
                                        Data = item.Object.Data,
                                        Respostas = item.Object.Respostas
                                    }
                            ).ToList();

                return list;
            } catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<Comentarios> MostrarComentarioPrincipal(string historia, string capitulo, string IdComentario)
        {
            try
            {
                var toIdComentario = (await fbCliente.Child("/Comentarios/" + historia + "/" + capitulo)
                .OnceAsync<Comentarios>()).Where(a => a.Object.Id == IdComentario).FirstOrDefault();

                var item = await fbCliente.Child("/Comentarios/" + historia + "/" + capitulo + "/" + toIdComentario.Key.ToString())
                                .OnceSingleAsync<Comentarios>();
                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<QuantidadeComentarioTotal> mostrarQuantidadeComentariosTotal(string historia)
        {
            try
            {
                var item = await fbCliente.Child("/Quantidade_Comentarios_Total/" + historia)
                                .OnceSingleAsync<QuantidadeComentarioTotal>();
                return item;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<QuantidadeComentario> mostrarQuantidadeComentarios(string historia, string capitulo)
        {
            try
            {
                var item = await fbCliente.Child("/Quantidade_Comentarios/" + historia + "/" + capitulo)
                                .OnceSingleAsync<QuantidadeComentario>();
                return item;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<QuantidadeComentario>> mostrarComentarioCapitulo(string historia)
        {
            try
            {
                FirebaseResponse response = await client.GetAsync("/Quantidade_Comentarios/" + historia);
                var myJson = response.Body;

                var list = JsonConvert.DeserializeObject<List<QuantidadeComentario>>(myJson).ToList();

                return list;

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task SomarComentarios(QuantidadeComentario comentario, string historia, string id)
        {
            try
            {
                await fbCliente.Child("/Quantidade_Comentarios/" + historia + "/" + id)
                    .PatchAsync(comentario);

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task SomarComentariosTotal(QuantidadeComentarioTotal comentario, string historia)
        {
            try
            {
                await fbCliente.Child("/Quantidade_Comentarios_Total/" + historia)
                .PatchAsync(comentario);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        //area referente a Respostas

        public async Task responder(Resposta resposta, string historia, string capitulo, string id)
        {
            try
            {
                await fbCliente.Child("/Respostas/" + historia + "/" + capitulo + "/" + id)
                                .PostAsync(resposta);
            } catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public async Task ExcluirResposta(string historia, string capitulo, string IdComentario, string idResposta)
        {
            try
            {
                var toDeleteComentario = (await fbCliente.Child("/Respostas/" + historia + "/" + capitulo + "/" + IdComentario)
            .OnceAsync<Comentarios>()).Where(a => a.Object.Id == idResposta).FirstOrDefault();

                await fbCliente.Child("/Respostas/" + historia + "/" + capitulo + "/" + IdComentario + "/" + toDeleteComentario.Key.ToString()).DeleteAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<Resposta>> mostrarRespostas(string historia, string capitulo, string idComentario)
        {
            var list = (await fbCliente.Child("/Respostas/" + historia + "/" + capitulo + "/" + idComentario)
            .OnceAsync<Resposta>())
            .Select(item =>
                    new Resposta
                    {
                        Id = item.Object.Id,
                        Usuario_id = item.Object.Usuario_id,
                        Usuario = item.Object.Usuario,
                        Mensagem = item.Object.Mensagem,
                        Data = item.Object.Data
                    }
            ).ToList();

            return list;
        }

        public async Task AlterarQuantidadeRespostas(Comentarios comentario, string historia, string capitulo)
        {
            try
            {
                var toChaveComentario = (await fbCliente.Child("/Comentarios/" + historia + "/" + capitulo)
               .OnceAsync<Comentarios>()).Where(a => a.Object.Id == comentario.Id).FirstOrDefault();

                await fbCliente.Child("/Comentarios/" + historia + "/" + capitulo + "/" + toChaveComentario.Key.ToString())
                .PatchAsync(comentario);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        public async Task<Comentarios> MostrarRespostaPrincipal(string historia, string capitulo, string IdComentario, string idResposta)
        {
            try
            {
                var toIdComentario = (await fbCliente.Child("/Respostas/" + historia + "/" + capitulo + "/" + IdComentario)
                .OnceAsync<Comentarios>()).Where(a => a.Object.Id == idResposta).FirstOrDefault();

                var item = await fbCliente.Child("/Respostas/" + historia + "/" + capitulo + "/" + IdComentario + "/" + toIdComentario.Key.ToString())
                                .OnceSingleAsync<Comentarios>();
                return item;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }


    }
}
