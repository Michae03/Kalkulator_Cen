using Avalonia.Controls;
using Avalonia.Interactivity;

namespace AplikacjaOkienkowaLab2;

public partial class MainWindow : Window
{
    public float TotalHardwareCost = 0;
    public float MonitorCost = 0;
    
    public MainWindow()
    {
        InitializeComponent();
    }

    private async void KomputerOnClick(object? sender, RoutedEventArgs e)
    {
        HardwareWindow secondWindow = new();
        await secondWindow.ShowDialog(this);
        TotalHardwareCost = float.Parse(secondWindow.disk_price) + float.Parse(secondWindow.processor_price) + 1000;
        Price.Text = (float.Parse(TotalHardwareCost.ToString()) + float.Parse(MonitorCost.ToString())).ToString();
    }

    private async void Screen_OnClick(object? sender, RoutedEventArgs e)
    {
        ScreenWindow thirdScreen = new();
        await thirdScreen.ShowDialog(this);
        MonitorCost = float.Parse(thirdScreen.screen_price);
        Price.Text = (float.Parse(TotalHardwareCost.ToString()) + float.Parse(MonitorCost.ToString())).ToString();
    }
}

