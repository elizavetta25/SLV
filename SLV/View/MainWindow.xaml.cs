using SLV.Core;
using SLV.View.Pages;
using System.Windows;

namespace SLV;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        MyTaskClass.TaskNavigate = MainFrame;

        MainFrame.Navigate(new MainPage());
    }
}
