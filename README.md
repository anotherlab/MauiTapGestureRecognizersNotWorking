# Maui TapGestureRecognizers Not Working
Sample repo for https://github.com/dotnet/maui/issues/17948

This is a simple list/detail app.  It displays a list of employees in a CollectionView, in MainPage.xaml. The CollectionView has a TapGestureRecognizer that should allow the user to double-tap on an item in the CollectionView and load up the detail page. 

This works in Xamarin.Forms 5 and .NET MAUI 7. It does not work in .NET 8.  The command bound to the TapGestureRecognizer is never triggered.

The TapGestureRecognizer has multiple sets of bindings, with all but one commented out. None of them work.

The syntax that works with .NET 7 is the following

```XML
<TapGestureRecognizer
    Command="{Binding Source={RelativeSource AncestorType={x:Type vm:EmployeesViewModel}}, Path=EmployeeTapped}"
    CommandParameter="{Binding .}"
    NumberOfTapsRequired="2" />
```

Fails with 8.0.100-rc.2.23502.2
Works with 7.0.402

Tested on Android 13, compiled from VS 2022 on Windows 11
