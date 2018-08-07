using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Widget;
using Lab4Events.Extensions;
using Lab4Events.Models;

namespace Lab4Events
{
    [Activity(Label = "RegisterActivity", Theme = "@style/AppTheme.NoActionBar")]
    public class RegisterActivity : AppCompatActivity
    {

        User createdUser;

        EditText nameEditText;
        EditText emailEditText;
        EditText passwordEditText;
        EditText repeatPasswordEditText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_register);

            nameEditText = FindViewById<EditText>(Resource.Id.nameEditText);
            emailEditText = FindViewById<EditText>(Resource.Id.emailEditText);
            passwordEditText = FindViewById<EditText>(Resource.Id.passwordEditText);
            repeatPasswordEditText = FindViewById<EditText>(Resource.Id.repeatPasswordEditText);

            FindViewById<Button>(Resource.Id.createButton).Click += OnCreateClicked;
        }

        protected override void OnActivityResult(int requestCode, [GeneratedEnum] Result resultCode, Intent data) {
            base.OnActivityResult(requestCode, resultCode, data);

            if (requestCode == 1001) {
                var intent = new Intent(this, typeof(MainActivity));
                intent.SetFlags(ActivityFlags.ClearTop);
                intent.PutExtra("name", createdUser.Name);
                intent.PutExtra("email", createdUser.Email);
                StartActivity(intent);
            }
        }

        void OnCreateClicked(object sender, System.EventArgs e) {
            //
            // 1. Validação
            if (string.IsNullOrEmpty(nameEditText.Text)) {
                this.DisplayAlert("Erro", "Você deve digitar seu nome.");
                return;
            }

            //
            // 2. Criar o registro do usuário no serviço
            createdUser = new User();
            createdUser.Name = nameEditText.Text;
            createdUser.Email = emailEditText.Text;

            //
            // 3. Passar para a tela de sucesso
            var intent = new Intent(this, typeof(SuccessActivity));
            StartActivityForResult(intent, 1001);
            //StartActivity(intent);
        }

    }
}