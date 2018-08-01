using Android.App;
using Android.Content;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using Lab4Events.Extensions;
using Lab4Events.Models;

namespace Lab4Events
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme.NoActionBar", MainLauncher = true)]
    public class LoginActivity : AppCompatActivity
    {

        EditText usernameEditText;
        EditText passwordEditText;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.activity_login);

            usernameEditText = FindViewById<EditText>(Resource.Id.usernameEditText);
            passwordEditText = FindViewById<EditText>(Resource.Id.passwordEditText);

            var createLoginButton = FindViewById<Button>(Resource.Id.createLoginButton);
            createLoginButton.Click += (s, e) =>
            {
                var intent = new Intent(this, typeof(RegisterActivity));
                StartActivity(intent);
            };

            var loginButton = FindViewById<Button>(Resource.Id.loginButton);
            loginButton.Click += (s, e) =>
            {
                var username = usernameEditText.Text;
                var password = passwordEditText.Text;

                if (string.IsNullOrWhiteSpace(username))
                {
                    this.DisplayAlert("Erro", "É necessário digitar seu nome de usuário.");
                    usernameEditText.RequestFocus();
                    return;
                }

                if (string.IsNullOrWhiteSpace(password))
                {
                    this.DisplayAlert("Erro", "É necessário digitar sua senha.");
                    passwordEditText.RequestFocus();
                    return;
                }

                if (!ValidateLogin(username, password))
                {
                    this.DisplayAlert("Erro", "Usuário ou senha inválidos.");
                    return;
                }

                var user = new User();
                user.Name = "Usuário da Silva";
                user.Email = "opa@mano.com";

                var intent = new Intent(this, typeof(MainActivity));
                intent.PutExtra("name", user.Name);
                intent.PutExtra("email", user.Email);
                StartActivity(intent);
            };
        }

        static bool ValidateLogin(string username, string password) =>
            username == "usuario" && password == "123";

    }
}