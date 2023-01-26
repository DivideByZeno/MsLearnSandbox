namespace AzureSandbox.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public string Header => "Sandbox for MS Learn material.";

    public MenuViewModel MenuViewModel { get; set; }

    public MainWindowViewModel()
    {
        MenuViewModel = App.GetService<MenuViewModel>();
    }
}
