using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using BindingEx.Pages;
using BindingEx.Models;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace BindingEx
{
    public partial class App : Application
    {
        public static User User;

        public App() {
            InitializeComponent();

            User = new User {
                Name = "Joãozinho da Silva",
                Email = "email@provedor.com",
                Birthday = new DateTime(1990, 2, 15),
                Bio = "Eu sou muito legal!",
            };
            MainPage = new NavigationPage(new MenuPage());
        }

        protected override void OnStart() {
            // Handle when your app starts
        }

        protected override void OnSleep() {
            // Handle when your app sleeps
        }

        protected override void OnResume() {
            // Handle when your app resumes
        }
    }
}
