using SampleLayoutApp.ViewModels;

namespace SampleLayoutApp.Views;

public partial class FlexLayoutPage : ContentPage
{
    public FlexLayoutPage(FlexLayoutViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}
