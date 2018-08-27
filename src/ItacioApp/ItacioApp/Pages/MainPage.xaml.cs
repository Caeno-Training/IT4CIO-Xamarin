using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ItacioApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage() {
            InitializeComponent();
        }

        protected override void OnAppearing() {
            base.OnAppearing();
            Animate();
        }

        async void Animate() {
            logoImage.Rotation = 0;
            await logoImage.RotateTo(720, 20000);
        }

        public void Handle_Clicked(object sender, EventArgs e) {
            var contactsPage = new ContactsPage();
            var navigationPage = new NavigationPage(contactsPage);
            Navigation.PushModalAsync(navigationPage);
        }
    }
}
