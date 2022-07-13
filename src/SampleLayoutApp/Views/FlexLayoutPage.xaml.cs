using Microsoft.Maui.Controls.Platform;
using SampleLayoutApp.ViewModels;

namespace SampleLayoutApp.Views;

public partial class FlexLayoutPage : ContentPage
{
    public FlexLayoutPage(FlexLayoutViewModel viewModel)
    {
        InitializeComponent();

        BindingContext = viewModel;

        mainFlexLayout.PropertyChanged += MainFlexLayout_PropertyChanged;

    }

    private void MainFlexLayout_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
    {
        if (e.PropertyName == nameof(FlexLayout.Direction))
        {
            ((IView)sender).InvalidateArrange();
        }
    }
}
