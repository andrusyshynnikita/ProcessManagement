using ProcessManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProcessManagement.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        LoginViewModel _viewModel;
        public LoginPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new LoginViewModel();

        }

        private async void loginClick(object sender, EventArgs e)
        {
            _viewModel.LoginCommand.Execute(null);
            Application.Current.MainPage = new AppShell();
            await Shell.Current.GoToAsync("//main");
        }
    }
}