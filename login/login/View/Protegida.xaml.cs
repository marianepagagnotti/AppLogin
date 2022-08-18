using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using login.Model;

namespace login.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Protegida : ContentPage
    {
        App PropriedadeAppLogin;
        public Protegida()
        {
            InitializeComponent();

            PropriedadeAppLogin = (App)Application.Current;

            frm_dados.BackgroundColor = Color.FromRgba(2, 2, 2, 0.2);

            Boas_Vindas();
        }

        private void Boas_Vindas()
        {
            string email_login = PropriedadeAppLogin.Properties["usuario_logado"].ToString();

            DadosUsuario usuario_logado = PropriedadeAppLogin.list_usuarios.FirstOrDefault(i => i.Email == email_login);

            lbl_boasvindas.Text = "Bem-vindo (a) " + usuario_logado.Nome;
        }



        private async void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                bool confirm = await DisplayAlert("Certeza?", "Desconectar conta?", "Sim", "Não");

                if (confirm)
                {
                    App.Current.Properties.Remove("usuario_logado");
                    App.Current.MainPage = new Login();
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Ops", ex.Message, "OK");
            }
        }
    }
}