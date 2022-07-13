using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;

namespace SampleLayoutApp.ViewModels;

public partial class FlexLayoutViewModel : ViewModelBase
{
    public FlexLayoutViewModel()
    {
        Title = "FlexLayout";
    }

    [ObservableProperty]
    private FlexDirection mainDirection;

    [ObservableProperty]
    private StackOrientation orientation;

    [RelayCommand]
    private void ToggleFlexDirection()
    {
        MainDirection = MainDirection == FlexDirection.Column ? FlexDirection.Row : FlexDirection.Column;

        Orientation = Orientation == StackOrientation.Horizontal
            ? StackOrientation.Vertical
            : StackOrientation.Horizontal;
    }
}
