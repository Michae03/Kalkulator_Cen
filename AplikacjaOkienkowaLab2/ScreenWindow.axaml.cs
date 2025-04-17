using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AplikacjaOkienkowaLab2;

public partial class ScreenWindow : Window
{
    public string screen_price { get; private set; } = "0";
    public ScreenWindow()
    {
        InitializeComponent();
    }
    
    private void Ok_Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Close();
    }

    private void Cancel_Button_OnClick(object? sender, RoutedEventArgs e)
    {
        screen_price = "0";
        Close();
    }

    private void SelectingItemsControl_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (sender is ListBox listBox && listBox.SelectedItem is ListBoxItem selectedItem)
        {
            screen_price = selectedItem.Tag.ToString();
            ScreenPrice.Text = screen_price;
        }
    }
}
