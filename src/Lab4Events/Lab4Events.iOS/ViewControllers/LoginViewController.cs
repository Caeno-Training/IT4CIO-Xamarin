using Foundation;
using System;
using UIKit;
using Lab4Events.Core.Services;
using Lab4Events.Core.Models;
using Lab4Events.iOS.Extensions;

namespace Lab4Events.iOS
{
    public partial class LoginViewController : UIViewController
    {
        User user;

        public LoginViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            // Configura o "padding" dos botões de imagem
            var buttonContentInsets = new UIEdgeInsets(16, 16, 16, 16);
            facebookButton.ContentEdgeInsets = buttonContentInsets;
            googleButton.ContentEdgeInsets = buttonContentInsets;
            linkedInButton.ContentEdgeInsets = buttonContentInsets;
        }

        public override void PrepareForSegue(UIStoryboardSegue segue, NSObject sender) {
            // Verifica se o segue desparado é o que direciona para a Home
            if (segue.Identifier == "home") {
                // Extrai o View Controller que será exibido
                // É necessário fazer o 'cast' já que ele é retornado com o tipo UIViewController
                var homeViewController = (HomeViewController)segue.DestinationViewController;

                // Atribui o user a propriedade no View Controller de destino
                homeViewController.User = user;
            }
        }

        partial void LoginButton_TouchUpInside(UIButton sender) {
            var userService = new UserService();
            var result = userService.Login(emailTextField.Text, passwordTextField.Text);
            if (result.Success) {
                user = result.User;
                PerformSegue("home", this);
                return;
            }

            // Notifica o usuário que é um login inválido
            this.DisplayAlert("Login inválido", "Digite um e-mail e senha válidos.");
        }
    }
}