using RTLauncher.CustomControls;
using RTLauncher.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using MaterialDesignThemes;
using RTLauncher.Services;

namespace RTLauncher.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<AppControl> ControlList { get; set; } = new ObservableCollection<AppControl>();
        public AppControl SelectedControl { get; set; }
        public bool IsMenuOpen { get; set; }
        public ICommand MenuAction
        {
            get
            {
                return new RelayCommand((o) => 
                {
                    IsMenuOpen = !IsMenuOpen;
                });
            }
        }
        public MainWindowViewModel()
        {
            AppControlManager.AppPages.ForEach(c => ControlList.Add(c));
            if (ControlList != null)
            {
                SelectedControl = ControlList.FirstOrDefault();
            }
        }
    }
}
