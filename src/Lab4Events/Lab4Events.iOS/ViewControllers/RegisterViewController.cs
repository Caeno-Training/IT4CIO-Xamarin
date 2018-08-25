using Foundation;
using System;
using UIKit;
using Lab4Events.iOS.Extensions;
using Lab4Events.Core.Services;
using Lab4Events.Core.Models;

namespace Lab4Events.iOS
{
    public partial class RegisterViewController : UITableViewController
    {
        UITextField[] fields; // Array com os text fields desse controller
        User user;

        public RegisterViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            // Cria o array com os textfields.
            fields = new[] {
                nameTextField,
                emailTextField,
                phoneTextField,
                passwordTextField,
                passwordRepeatTextField,
            };
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

        partial void CancelButton_Activated(UIBarButtonItem sender) {
            DismissViewController(true, null);
        }

        partial void ConfirmButton_Activated(UIBarButtonItem sender) {
            //
            // 1. Validação
            // 1.1. Senhas devem coincidir
            if (string.IsNullOrWhiteSpace(nameTextField.Text)) {
                
                return;
            }

            if (passwordTextField.Text != passwordRepeatTextField.Text) {
                this.DisplayAlert("Erro de Validação", "As senhas devem coincidir.");
                return;
            }

            //
            // 2. Chamar o back-end para fazer o registro do usuário
            var userService = new UserService();
            var result = userService.Register(nameTextField.Text, 
                                              emailTextField.Text, 
                                              phoneTextField.Text, 
                                              passwordTextField.Text);

            if (!result.Success) {
                this.DisplayAlert("Falha na criação do usuário", result.ErrorMessage);
                return;
            }

            //
            // 3. Se bem sucedida a criação, ir para a tela inicial
            user = result.User;
            PerformSegue("home", this);
        }
    }
}