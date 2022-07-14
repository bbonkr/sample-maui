## Environment

* macOS 12.4
* Apple M1 Max
* .NET SDK 6.0.300
* maui SDK 6.0.300
* Visual Studio 2022 for Mac 17.3 Preview 2 (17.3 build 1038)


## FlexLayout

FlexLayout.Direction changing on runtime Does not work on Android.

### .net6.0-maccatalyst

It's working.

https://youtu.be/QnU-lkLtNDk

### .net6.0-ios

It's working.

https://youtube.com/shorts/kg7_zbZGU4k?feature=share

### .net6.0-android

It's not working.

https://youtube.com/shorts/9K68qRb1Y_0?feature=share

You can force a re-rendering request, but it doesn't seem to be a solution if the internals are complicated.

```csharp
private void MainFlexLayout_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
{
    if (e.PropertyName == nameof(FlexLayout.Direction))
    {
        ((IView)sender).InvalidateArrange();
    }
}
```