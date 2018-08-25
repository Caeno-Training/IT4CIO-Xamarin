using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppForms
{
    public partial class MainPage : ContentPage
    {
        public MainPage() {
            InitializeComponent();
        }

        public void Handle_Clicked(object sender, EventArgs e) {
            var name = nameEntry.Text;
            DisplayAlert("Opa!", $"Olá {name}, obrigado por ajudar com minha carência.", "OK");
        }
    }
}
