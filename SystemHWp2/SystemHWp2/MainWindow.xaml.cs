
using System;
using System.Diagnostics;

using System.Windows;


namespace SystemHWp2
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


            
            process.StartInfo.FileName = "notepad.exe";

            process.Start();
            

            MessageBoxButton buttons = MessageBoxButton.YesNo;
            MessageBoxResult result = MessageBox.Show("Ожидать завершения?", "Выбор режима ожидания", buttons);
        

            if (result == MessageBoxResult.Yes)
            {
                
                process.WaitForExit();

                
                MessageBox.Show($"Дочерний процесс завершен с кодом {process.ExitCode}");
            }
            else
            {
                
                process.Kill();
                Environment.Exit(0);
            }
        }
    }
}
