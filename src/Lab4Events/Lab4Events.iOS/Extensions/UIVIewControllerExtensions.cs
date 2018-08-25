using System;
using UIKit;
namespace Lab4Events.iOS.Extensions
{
    public static class UIViewControllerExtensions
    {

        public static void DisplayAlert(this UIViewController controller, string title, string content) {
            var alertController = UIAlertController.Create(title, content, UIAlertControllerStyle.Alert);
            alertController.AddAction(UIAlertAction.Create("OK", UIAlertActionStyle.Cancel, null));
            controller.PresentViewController(alertController, true, null);
        }

    }
}
