using Mde.OnlineServices.Flags.ViewModels;

namespace Mde.OnlineServices.Flags
{
    public partial class MainPage : ContentPage
    {
        private MainViewModel viewmodel;
        public MainPage(MainViewModel viewmodel)
        {
            InitializeComponent();
            BindingContext = this.viewmodel = viewmodel;
        }

        protected override void OnAppearing()
        {
            viewmodel.LoadFlags.Execute(null);
        }
    }

}
