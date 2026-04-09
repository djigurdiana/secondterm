using CommunityToolkit.Mvvm.ComponentModel;

namespace Form1.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
}
