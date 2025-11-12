using KursovayaaClient.Services;
using KursovayaaClient.Utills;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KursovayaaClient.ViewModels
{
    public class RegisterViewModel : ViewModelBase
    {
        private AuthService authService;

        public RegisterViewModel()
        {
            authService = new AuthService();
        }

        private string? email;
        public string Email
        {
            get { return email!; }
            set
            {
                email = value;
                OnPropertyChanged(nameof(email));
            }
        }
        private string? password;
        public string Password
        {
            get { return password!; }
            set
            {
                password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
        private string? passwordRepeat;
        public string PasswordRepeat
        {
            get { return passwordRepeat!; }
            set
            {
                passwordRepeat = value;
                OnPropertyChanged(nameof(PasswordRepeat));
            }
        }
        private RelayCommand? registerCommand;
        public RelayCommand RegisterCommand
        {
            get
            {
                return registerCommand ??
                  (registerCommand = new RelayCommand(async obj =>
                  {
                      //              string[] passwords= obj as string[];
                      //              //if (passwords[0] == passwords[1])
                      //              //{
                      //              //    Person person=new Person { Email = Email, Password = passwords[0] };
                      //              //    string result=await authService.Register(person);
                      //              //    MessageBox.Show(result);
                      //              //}
                  }));
            }
        }
    }
}
