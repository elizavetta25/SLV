using SLV.Core;
using SLV.View.Pages.TaskPages;
using System.Windows;
using System.Windows.Controls;

namespace SLV.View.Pages;
public partial class MainPage : Page
{
    public MainPage()
    {
        InitializeComponent();
    }

    private void BtnTask1_Click(object sender, RoutedEventArgs e)
    {
        MyTaskClass.TaskNavigate?.Navigate(new Task1Page());
    }
}
