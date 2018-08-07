using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;

namespace Lab4Events
{
    [Activity(Label = "SuccessActivity", Theme = "@style/AppTheme.NoActionBar")]
    public class SuccessActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_success);

            FindViewById<Button>(Resource.Id.startButton).Click += Handle_Click;
        }

        public override void OnBackPressed() {
        }

        void Handle_Click(object sender, System.EventArgs e) {
            SetResult(Result.Ok);
            Finish();
        }

    }
}