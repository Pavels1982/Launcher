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

namespace RTLauncher.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Control[] Controls;
        private Control selectedControl;

        public ObservableCollection<Control> ControlList { get; set; } = new ObservableCollection<Control>();

        public Control SelectedControl 
        {

            get
            {
                return selectedControl;
            }

            set
            {
                selectedControl = value;
            }
        }
      
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
            CreateControls();
            Controls.ToList().ForEach(c => ControlList.Add(c));
            SelectedControl = Controls.Where(c => c.Title == "Home").FirstOrDefault() as Control;
        }


        public void CreateControls()
        {
            Controls = new Control[] {

                new Control(
                    new HomeControl(),
                    new HomeControlViewModel(),
                    MaterialDesignThemes.Wpf.PackIconKind.Home,
                    "Home"),

               new Control(
                    new SettingControl(),
                    new SettingControlViewModel(),
                    MaterialDesignThemes.Wpf.PackIconKind.Settings,
                    "Settings"),

            };
        }

    }
}
