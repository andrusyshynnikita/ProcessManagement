using Microcharts;
using ProcessManagement.ViewModels;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ProcessManagement.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DashboardPage : ContentPage
    {

        List<Microcharts.Entry> entries = new List<Microcharts.Entry>
        {
            new Microcharts.Entry(200)
            {
                Color =  SkiaSharp.SKColor.Parse("#FA8072"),
                Label = "Error",
                ValueLabel = "200",

            },
            new Microcharts.Entry(200)
            {
                Color =  SkiaSharp.SKColor.Parse("#FFFF99"),
                Label = "Warning",
                ValueLabel = "200",

            },
            new Microcharts.Entry(200)
            {
                Color =  SkiaSharp.SKColor.Parse("#808080"),
                Label = "Info",
                ValueLabel = "200",

            },
        };
        private readonly DashboardViewModel _viewModel;
        public DashboardPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new DashboardViewModel();
            DonutChar.Chart = new DonutChart() { Entries = entries };
        }
    }
}