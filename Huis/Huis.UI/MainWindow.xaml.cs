using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Huis.UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void createHome1Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void increaseFloors1Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void increaseMultipleFloors1Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void decreaseFloors1Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void showHome1Button_Click(object sender, RoutedEventArgs e)
    {

    }



    private void createHome2Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void increaseFloors2Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void increaseMultipleFloors2Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void decreaseFloors2Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void showHome2Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void showHome3Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void showHome4Button_Click(object sender, RoutedEventArgs e)
    {

    }

    private void clearButton_Click(object sender, RoutedEventArgs e)
    {
        locationTextBox.Clear();
        lengthTextBox.Clear();
        widthTextBox.Clear();
        floorsTextBox.Clear();
        openRadioButton.IsChecked = true;
        resultTextBox.Clear();

        locationTextBox.Focus();
    }
}