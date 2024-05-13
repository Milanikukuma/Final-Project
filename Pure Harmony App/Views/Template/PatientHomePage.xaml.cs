
using Pure_Harmony_App.ViewModels;

namespace Pure_Harmony_App.Views
{
    public partial class PatientPage : ContentPage
    {
        private readonly PatientViewModel _viewModel;

        public PatientPage(PatientViewModel vm)
        {
            InitializeComponent();
            _viewModel = vm;
            BindingContext = _viewModel;
        }
    }
}
