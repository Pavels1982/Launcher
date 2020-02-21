using MaterialDesignThemes.Wpf;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace RTLauncher.Models
{
    public class Control
    {
        public object Content { get; set; }
        public PackIconKind Icon { get; set; }
        public string Title { get; set; }
        

        public Control(object view, object viewModel, PackIconKind icon, string title)
        {
            this.Content = view;
            (this.Content as UserControl).DataContext = viewModel;
            this.Icon = icon;
            this.Title = title;
        }
    }
}
