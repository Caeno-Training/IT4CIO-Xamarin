using Foundation;
using System;
using UIKit;

namespace Lab4Events.iOS
{
    public partial class LoginViewController : UIViewController
    {
        public LoginViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            var buttonContentInsets = new UIEdgeInsets(16, 16, 16, 16);
            facebookButton.ContentEdgeInsets = buttonContentInsets;
            googleButton.ContentEdgeInsets = buttonContentInsets;
            linkedInButton.ContentEdgeInsets = buttonContentInsets;
        }

        partial void LoginButton_TouchUpInside(UIButton sender) {
            if (emailTextField.Text == "a@a.com" && passwordTextField.Text == "a") {
                // Toma um ação
            }

            // Notifica o usuário que é um login inválido
        }
    }
}