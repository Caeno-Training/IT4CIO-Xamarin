using System;
using System.Collections.Generic;

using Xamarin.Forms;
using BindingEx.Models;

namespace BindingEx.Pages
{
    public partial class ProfilePage : ContentPage
    {
        User user;

        public ProfilePage() {
            InitializeComponent();

            user = new User {
                Name = App.User.Name,
                Email = App.User.Email,
                Birthday = App.User.Birthday,
                Bio = App.User.Bio,
            };
            BindingContext = user;
        }

        public void Handle_Clicked(object sender, EventArgs e) {
            App.User = user;
            Navigation.PopAsync();
        }
    }
}
