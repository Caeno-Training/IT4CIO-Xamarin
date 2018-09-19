using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Threading.Tasks;

namespace ItacioApp.Pages
{
    public partial class MainPage : ContentPage
    {
        bool isAnimating;

        public MainPage() {
            InitializeComponent();
        }

        //protected override void OnAppearing() {
        //    base.OnAppearing();
        //    StartAnimation();
        //}

        //async void StartAnimation() {
        //    isAnimating = true;
        //    while (isAnimating) {
        //        logoImage.Rotation = 0;
        //        await logoImage.RotateTo(360, 10000);
        //    }
        //}

        //void StopAnimation() {
        //    isAnimating = false;
        //    logoImage.Rotation = 0;
        //}

        public async void RegisterClicked(object sender, EventArgs e) {
            var registerPage = new RegisterPage();
            var navigationPage = new NavigationPage(registerPage);
            await Navigation.PushModalAsync(navigationPage);

            //StopAnimation();
        }

        public void LoginClicked(object sender, EventArgs e) {
            var loginPage = new LoginPage();
            var navigationPage = new NavigationPage(loginPage);
            Navigation.PushModalAsync(navigationPage);
        }
    }
}
