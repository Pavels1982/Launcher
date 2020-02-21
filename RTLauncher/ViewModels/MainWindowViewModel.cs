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

namespace RTLauncher.ViewModels
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private Control[] Controls;
      
        public ObservableCollection<Control> ControlList { get; set; } = new ObservableCollection<Control>();

        public Control SelectedControl { get; set; }
      
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
            SelectedControl = Controls.Where(c => c.Title == "Home").FirstOrDefault() as Control;
        }


        public void CreateControls()
        {
            Controls = new Control[] {

                new Control(
                    new HomeControl(),
                    new HomeControlViewModel(),
                    null,
                    "Home"),

               new Control(
                    new SettingControl(),
                    new SettingControlViewModel(),
                    null,
                    "Settings"),

            };
        }

    }
}
