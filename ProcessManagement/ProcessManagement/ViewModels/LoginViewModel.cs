using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ProcessManagement.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        public LoginViewModel()
        {

        }

        private string _userName;
        public string UserName
        {
            get { return _userName; }
            set { SetProperty(ref _userName, value); }
        }

        private string _password;
        public string Password
        {
            get { return _password; }
            set { SetProperty(ref _password, value); }
        }

        private Command _loginCommand;
        public Command LoginCommand
        {
            get
            {
                _loginCommand = _loginCommand ?? new Command(async (result) => await OnLogin());

                return _loginCommand;
            }
        }


        #region Methods
        async Task OnLogin()
        {
        }
        #endregion Methods
    }
}
