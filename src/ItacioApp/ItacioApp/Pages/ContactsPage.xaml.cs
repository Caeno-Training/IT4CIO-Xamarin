using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using ItacioApp.Models;

namespace ItacioApp
{
    public partial class ContactsPage : ContentPage
    {
        public ContactsPage() {
            InitializeComponent();

            var list = new List<Contact> {
                new Contact { Name = "Teste 1", Avatar = "contact_picture", Email = "teste1@teste.com", Profile = "PAT" },
                new Contact { Name = "Teste 2", Avatar = "contact_picture", Email = "teste2@teste.com", Profile = "CIO" },
                new Contact { Name = "Teste 3", Avatar = "contact_picture", Email = "teste3@teste.com", Profile = "CON" },
            };
            contactsListView.ItemsSource = list;
        }

        public void Handle_Clicked(object sender, EventArgs e) {
            Navigation.PopModalAsync();
        }
    }
}
