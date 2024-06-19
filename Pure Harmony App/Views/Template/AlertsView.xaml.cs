
using Pure_Harmony_App.ViewModels;
namespace Pure_Harmony_App.Views;

public partial class AlertsView : ContentPage
{
	public AlertsView(RfidReaderViewModel vm)
	{
		InitializeComponent();
		BindingContext = vm;
	}
    protected async override void OnAppearing()
    {
        base.OnAppearing();

        if (BindingContext is RfidReaderViewModel vm)
        {
            await vm.InitializeAsync();
        }
    }
}