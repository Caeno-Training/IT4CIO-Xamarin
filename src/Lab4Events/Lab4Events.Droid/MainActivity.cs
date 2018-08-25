using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Lab4Events.Core.Models;

namespace Lab4Events
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar")]
	public class MainActivity : AppCompatActivity
	{

        TextView nameTextView;
        TextView emailTextView;

        User user;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_main);

            nameTextView = FindViewById<TextView>(Resource.Id.nameTextView);
            emailTextView = FindViewById<TextView>(Resource.Id.emailTextView);

            user = User.FromJson(Intent.GetStringExtra("user"));
            nameTextView.Text = user.Name;
            emailTextView.Text = user.Email;
		}

	}
}

