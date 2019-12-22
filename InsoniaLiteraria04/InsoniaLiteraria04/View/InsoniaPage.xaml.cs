using InsoniaLiteraria04.Database;
using InsoniaLiteraria04.Helper;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace InsoniaLiteraria04.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InsoniaPage : ContentPage
	{
        

        public InsoniaPage ()
		{
			InitializeComponent ();
            //verificarFotoPerfil();
        }

        public async Task<bool> verificarFotoPerfil()
        {
            DBFire db = new DBFire();

            try
            {
                var listAsync = await db.mostrarFotoPerfil();

                if (listAsync == null)
                {
                    await DisplayAlert("Você ainda não tem uma foto de perfil", "Visite seu perfil e atribua a você uma foto", "OK");
                }

                return true;
            }
            catch(Exception ex)
            {
                return true;
            }
            
        }  
    }
}