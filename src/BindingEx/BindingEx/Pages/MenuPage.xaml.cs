using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Windows.Input;

namespace BindingEx.Pages
{
    public partial class MenuPage : ContentPage
    {
        public ICommand SelectedOption { get; set; }

        public MenuPage() {
            InitializeComponent();

            SelectedOption = new Command<string>((p) => {
                switch (p) {
                    case "Profile":
                        Navigation.PushAsync(new ProfilePage());
                        break;
                    default:
                        DisplayAlert("", "Opção inválida.", "OK");
                        break;
                }
            });
            BindingContext = this;
        }
    }
}
