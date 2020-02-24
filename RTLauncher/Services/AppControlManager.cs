using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using RTLauncher.CustomControls;
using RTLauncher.ViewModels;
using RTLauncher.Models;

namespace RTLauncher.Services
{
    public static class AppControlManager
    {

        public static List<AppControl> AppPages = new List<AppControl>() 
        {
          new AppControl(
                    new HomeControl(),
                    new HomeControlViewModel(),
                    MaterialDesignThemes.Wpf.PackIconKind.Home,
                    "Home"),

               new AppControl(
                    new SettingControl(),
                    new SettingControlViewModel(),
                    MaterialDesignThemes.Wpf.PackIconKind.Settings,
                    "Settings"),


        };


    }
}
