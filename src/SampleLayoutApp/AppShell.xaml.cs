using SampleLayoutApp.Views;

namespace SampleLayoutApp;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(RouteNames.Layouts, typeof(LayoutsPage));
        Routing.RegisterRoute(RouteNames.FlexLayout, typeof(FlexLayoutPage));
    }
}
