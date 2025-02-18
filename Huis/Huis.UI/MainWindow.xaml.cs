using Huis.Shared;
using System.Windows;
using Microsoft.VisualBasic;
using System.Text;

namespace Huis.UI;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    private Home _huis1;
    private Home _huis2;
    private Home _huis3;
    private Home _huis4;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void createHome1Button_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            _huis1 = new Home();
            _huis3 = _huis1;
            _huis1.Location = locationTextBox.Text;
            _huis1.Length = double.Parse(lengthTextBox.Text);
            _huis1.Width = double.Parse(widthTextBox.Text);
            _huis1.NumberOfFloors = int.Parse(floorsTextBox.Text);

            if(openRadioButton.IsChecked == true)
            {
                _huis1.Type = 'O';
            }
            else if (halfOpenRadioButton.IsChecked == true)
            {
                _huis1.Type = 'H';
            }
            else if (geslotenRadioButton.IsChecked == true)
            {
                _huis1.Type = 'G';
            }
        }
        catch (Exception)
        {
            MessageBox.Show("Vul de gegevens correct in!");
        }
    }

    private void increaseFloors1Button_Click(object sender, RoutedEventArgs e)
    {
        //NullForgivenOperator
        _huis1?.IncreaseNumberOfFloors();

        //if (_huis1 is not null)
        //{
        //    _huis1.IncreaseNumberOfFloors();
        //}

      
    }

    private void increaseMultipleFloors1Button_Click(object sender, RoutedEventArgs e)
    {
        string input = Interaction.InputBox("Aantal verdiepingen: ");

        if(int.TryParse(input, out int floors) && floors > 0)
        {
            _huis1?.IncreaseNumberOfFloors(floors);
        }
    }

    private void decreaseFloors1Button_Click(object sender, RoutedEventArgs e)
    {
        _huis1?.DecreaseNumberOfFloors();
    }

    private void showHome1Button_Click(object sender, RoutedEventArgs e)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Gegevens van Huis 1 : ");
        sb.AppendLine();
        sb.AppendLine(_huis1?.GetDescription());

        resultTextBox.Text = sb.ToString();
    }

    private void createHome2Button_Click(object sender, RoutedEventArgs e)
    {
        try
        {
            char type = 'O';
            if (openRadioButton.IsChecked == true)
            {
                type = 'O';
            }
            else if (halfOpenRadioButton.IsChecked == true)
            {
                type = 'H';
            }
            else if (geslotenRadioButton.IsChecked == true)
            {
                type = 'G';
            }

            _huis2 = new Home(
                locationTextBox.Text,
                double.Parse(lengthTextBox.Text),
                double.Parse(widthTextBox.Text),
                uint.Parse(floorsTextBox.Text),
                type);
            _huis4 = _huis2;
        }
        catch (Exception)
        {
            MessageBox.Show("Vul eerst alle gegevens in.");
        }


    }

    private void increaseFloors2Button_Click(object sender, RoutedEventArgs e)
    {
        _huis2.IncreaseNumberOfFloors();
    }

    private void increaseMultipleFloors2Button_Click(object sender, RoutedEventArgs e)
    {
        string input = Interaction.InputBox("Aantal verdiepingen: ");

        if (int.TryParse(input, out int floors) && floors > 0)
        {
            _huis2?.IncreaseNumberOfFloors(floors);
        }
    }

    private void decreaseFloors2Button_Click(object sender, RoutedEventArgs e)
    {
        _huis2.DecreaseNumberOfFloors();
    }

    private void showHome2Button_Click(object sender, RoutedEventArgs e)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Gegevens van Huis 2 : ");
        sb.AppendLine();
        sb.AppendLine(_huis2?.GetDescription());

        resultTextBox.Text = sb.ToString();
    }

    private void showHome3Button_Click(object sender, RoutedEventArgs e)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Gegevens van Huis 3 : ");
        sb.AppendLine();
        sb.AppendLine(_huis3?.GetDescription());

        resultTextBox.Text = sb.ToString();
    }

    private void showHome4Button_Click(object sender, RoutedEventArgs e)
    {
        StringBuilder sb = new StringBuilder();

        sb.AppendLine("Gegevens van Huis 4 : ");
        sb.AppendLine();
        sb.AppendLine(_huis4?.GetDescription());

        resultTextBox.Text = sb.ToString();
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