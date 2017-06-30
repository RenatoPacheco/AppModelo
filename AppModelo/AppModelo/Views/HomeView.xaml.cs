using AppModelo.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppModelo.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomeView : ContentPage
    {

        public HomeView()
        {
            InitializeComponent();
            this.viewModel = new MainPageViewModel();
            this.BindingContext = this.viewModel;
        }

        private readonly MainPageViewModel viewModel;

    }
}