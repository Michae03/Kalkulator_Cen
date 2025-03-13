using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AplikacjaOkienkowaLab2;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void KomputerOnClick(object? sender, RoutedEventArgs e)
    {
        SecondWindow secondWindow = new();
        secondWindow.Show();
    }
}

