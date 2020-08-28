using System.Windows;

namespace InjectionCoreProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            // Do the base stuff
            base.OnStartup(e);

            // Program is now running
            ProgramState.IsRunning = true;

            // Construct the IoC container
            Container.SetupIoC();

            // Set the main window
            this.MainWindow = new MainWindow();
            this.MainWindow.Show();
        }
    }
}
