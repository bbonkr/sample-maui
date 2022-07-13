namespace SampleLayoutApp.ViewModels;

public partial class LayoutsViewModel : ViewModelBase
{
    public LayoutsViewModel()
    {

    }

    [RelayCommand]
    private async Task GoToFlexLayout()
    {
        await Shell.Current.GoToAsync($"//{RouteNames.FlexLayout}");
    }
}