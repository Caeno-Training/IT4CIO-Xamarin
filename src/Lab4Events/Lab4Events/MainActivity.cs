using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace Lab4Events
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar")]
	public class MainActivity : AppCompatActivity
	{

        TextView nameTextView;
        TextView emailTextView;

		protected override void OnCreate(Bundle savedInstanceState)
		{
			base.OnCreate(savedInstanceState);
			SetContentView(Resource.Layout.activity_main);

            nameTextView = FindViewById<TextView>(Resource.Id.nameTextView);
            emailTextView = FindViewById<TextView>(Resource.Id.emailTextView);

            var name = Intent.GetStringExtra("name");
            var email = Intent.GetStringExtra("email");
            nameTextView.Text = name;
            emailTextView.Text = email;
		}

	}
}

