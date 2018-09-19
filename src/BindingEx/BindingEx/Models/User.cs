using System;
namespace BindingEx.Models
{
    public class User : ObservableBase
    {
        string _name;
        public string Name {
            get => _name;
            set => SetProperty(ref _name, value);
        }

        string _email;
        public string Email {
            get => _email;
            set => SetProperty(ref _email, value);
        }

        DateTime _birthday;
        public DateTime Birthday {
            get => _birthday;
            set => SetProperty(ref _birthday, value);
        }

        string _bio;
        public string Bio {
            get => _bio;
            set => SetProperty(ref _bio, value);
        }
    }
}
