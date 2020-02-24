using RTLauncher.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace RTLauncher.Views
{
    

    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindowView : Window, INotifyPropertyChanged
    {
        public bool IsWindowMaximize { get; set; }

        public MainWindowView()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void HideToTray(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void StateWindow(object sender, RoutedEventArgs e)
        {
            
            IsWindowMaximize = !IsWindowMaximize;
            if (IsWindowMaximize)
            {
                this.WindowState = WindowState.Maximized;
            }
            else 
            {
                this.WindowState = WindowState.Normal;
            }

        }


    }
}
