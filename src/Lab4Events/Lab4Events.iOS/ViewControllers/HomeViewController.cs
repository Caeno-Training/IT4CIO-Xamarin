using Foundation;
using System;
using UIKit;
using Lab4Events.Core.Models;

namespace Lab4Events.iOS
{
    public partial class HomeViewController : UIViewController
    {
        public User User { get; set; }

        public HomeViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad() {
            base.ViewDidLoad();

            // Carrega as informações do usuário
            nameLabel.Text = User.Name;
            emailLabel.Text = User.Email;
        }

        partial void BackButton_TouchUpInside(UIButton sender) {
            DismissViewController(true, null);
        }
    }
}