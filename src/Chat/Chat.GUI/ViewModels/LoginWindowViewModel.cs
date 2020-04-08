using Chat.Core;
using Chat.GUI.MVVM;
using Chat.GUI.MVVM.Commands;
using System.Windows.Input;

namespace Chat.GUI.ViewModels
{
    public class LoginWindowViewModel : ViewModelBase
    {
        private User _user;
        public User User
        {
            get { return _user; }
            set
            {
                _user = value;
                OnPropertyChanged("User");
            }
        }

        public LoginWindowViewModel()
        {
            User = new User();
        }

        private ICommand _logInCommand;
        public ICommand LogInCommand
        {
            get
            {
                if (_logInCommand == null)
                    _logInCommand = new RelayCommand(_ => { LogIn(); });

                return _logInCommand;
            }
        }
    }
}
