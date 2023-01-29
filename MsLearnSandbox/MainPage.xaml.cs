using System.Diagnostics;
using CommunityToolkit.Mvvm.Messaging;
using MsLearnSandbox.ViewModels;

namespace MsLearnSandbox;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();

        WeakReferenceMessenger.Default.Register<CountChangedMessage>(this, (r, m) =>
        {
            CounterBtn.Text = m.Text;
            SemanticScreenReader.Announce(m.Text);
            Debug.WriteLine($"{m.Text}");
        });
    }
}

