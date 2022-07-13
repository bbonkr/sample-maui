using SampleLayoutApp.ViewModels;

namespace SampleLayoutApp.Views;

public partial class LayoutsPage : ContentPage
{
    public LayoutsPage(LayoutsViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;
    }
}
