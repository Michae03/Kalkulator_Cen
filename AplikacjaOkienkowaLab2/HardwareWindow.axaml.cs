using Avalonia;
using Avalonia.Controls;
using Avalonia.Input;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace AplikacjaOkienkowaLab2;

public partial class HardwareWindow : Window
{
    public string disk_price { get; private set; } = "0";
    public string processor_price { get; private set; } = "0";
    
    public HardwareWindow()
    {
        InitializeComponent();
    }
    
    private void Ok_Button_OnClick(object? sender, RoutedEventArgs e)
    {
        Close();
    }

    private void Cancel_Button_OnClick(object? sender, RoutedEventArgs e)
    {
        disk_price = "0";
        processor_price = "0";
        Close();
    }

    private void RadioButton_OnClick(object? sender, RoutedEventArgs e)
    {
        if (sender is RadioButton radioButton)
        {
            disk_price = radioButton.Tag.ToString();
            DiskPrice.Text = disk_price;
        }
    }

    private void SelectingItemsControl_OnSelectionChanged(object? sender, SelectionChangedEventArgs e)
    {
        if (sender is ComboBox comboBox && comboBox.SelectedItem is ComboBoxItem selectedItem)
        {
           processor_price = selectedItem.Tag.ToString();
           ProcessorPrice.Text = processor_price;
        }
    }
}