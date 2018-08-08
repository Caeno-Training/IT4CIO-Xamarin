using Foundation;
using System;
using UIKit;

namespace Lab4Events.iOS
{
    public partial class RegisterViewController : UIViewController
    {
        public RegisterViewController (IntPtr handle) : base (handle)
        {
        }

        partial void BackButton_TouchUpInside(UIButton sender) {
            DismissViewController(true, null);
        }
    }
}