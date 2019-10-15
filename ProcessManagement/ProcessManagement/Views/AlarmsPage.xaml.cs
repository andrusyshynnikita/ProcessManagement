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
    public partial class AlarmsPage : ContentPage
    {
        private readonly AlarmsViewModel _viewModel;

        public AlarmsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new AlarmsViewModel();
        }
    }
}