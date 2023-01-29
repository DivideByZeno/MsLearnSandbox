using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CommunityToolkit.Mvvm.Messaging;

namespace MsLearnSandbox.ViewModels;

public sealed record CountChangedMessage(string Text);

public partial class MainViewModel : ObservableObject
{
    [ObservableProperty]
    private string message = "Click me";

    private int count;

    [RelayCommand]
    private void IncrementCounter()
    {
        count++;

        if (count == 1)
            Message = $"Clicked {count} time";
        else
            Message = $"Clicked {count} times";

        WeakReferenceMessenger.Default.Send(new CountChangedMessage(Message));
    }
}
