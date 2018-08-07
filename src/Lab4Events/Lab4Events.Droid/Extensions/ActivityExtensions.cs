

using Android.App;

namespace Lab4Events.Extensions
{

    public static class ActivityExtensions
    {

        public static void DisplayAlert(this Activity activity, string title, string message) =>
            new Android.Support.V7.App.AlertDialog.Builder(activity)
                .SetTitle(title)
                .SetMessage(message)
                .SetNeutralButton("OK", (s, e) => { })
                .Show();

    }

}