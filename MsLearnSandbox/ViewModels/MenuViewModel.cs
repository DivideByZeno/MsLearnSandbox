using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using ReactiveUI;

namespace AzureSandbox.ViewModels;

public class MenuViewModel : ViewModelBase
{
    public MenuViewModel()
    {
        ExitCommand = ReactiveCommand.Create(Exit);
    }

    public ReactiveCommand<Unit, Unit> ExitCommand
    {
        get;
    }

    public void Exit()
    {
        System.Diagnostics.Debug.WriteLine("Exiting ...");
        System.Environment.Exit(0);
    }
}
