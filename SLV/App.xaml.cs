using System.Windows;

namespace SLV;
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        new MainWindow().Show();
    }
}
