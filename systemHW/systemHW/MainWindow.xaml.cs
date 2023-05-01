
using System.Diagnostics;

using System.Windows;


namespace systemHW
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void ClickForOpenApp(object sender, RoutedEventArgs e)
        {
            
            Process process = new Process();

            
            process.StartInfo.FileName = "steam.exe";

            
            process.Start();

            
            process.WaitForExit();

            
            MessageBox.Show($"Дочерний процесс завершен с кодом {process.ExitCode}");
        }
    }
}
