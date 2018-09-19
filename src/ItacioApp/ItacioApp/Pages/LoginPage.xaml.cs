using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ItacioApp.Pages
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage() {
            InitializeComponent();
        }

        void BackClicked(object sender, EventArgs args) => Navigation.PopModalAsync();

        void LoginClicked(object sender, EventArgs args) {
            //
            // Validação do login

            //
            // Direcionar para a página de contatos
            var page = new ContactsPage();
            Navigation.PushAsync(page);
        }
    }
}
