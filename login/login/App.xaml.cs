using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

using login.View;
using login.Model;

namespace login
{
    public partial class App : Application
    {
        public List<DadosUsuario> list_usuarios = new List<DadosUsuario>
        {
            new DadosUsuario()
            {
                Email = "mariane@eu",
                Nome = "mariane",
                Senha = "0802"
            },
            new DadosUsuario()
            {
                Email = "marina@ela",
                Nome = "marina",
                Senha = "0403"
            }
        };


        public App()
        {
            InitializeComponent();

            if (Properties.ContainsKey("usuario_logado"))
                MainPage = new Protegida();
            else
                MainPage = new Login();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
