using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AppListaCompras.Maui.ViewModels;

public partial class FistPageViewModel : ObservableObject
{
    [RelayCommand]
    private void NavigateToAppShell()
        => App.Current.MainPage = new AppShell();
}
