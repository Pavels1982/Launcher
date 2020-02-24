namespace RTLauncher.Models
{
    using MaterialDesignThemes.Wpf;
    using System.Windows.Controls;

    public class AppControl
    {

        #region Properties
        /// <summary>
        /// Get or set модель представления контрола.
        /// </summary>
        public object View { get; set; }

        /// <summary>
        /// Get or set модель бизнес-логики контрола.
        /// </summary>
        public object DataContext { get; set; }

        /// <summary>
        /// Get or set иконка контрола (для отображения в меню).
        /// </summary>
        public PackIconKind Icon { get; set; }

        /// <summary>
        /// Get or set заголовок контрола.
        /// </summary>
        public string Title { get; set; }
        #endregion

        #region Constructor
        /// <summary>
        /// Конструктор по-умолчанию.
        /// </summary>
        /// <param name="view"></param>
        /// <param name="viewModel"></param>
        /// <param name="icon"></param>
        /// <param name="title"></param>
        public AppControl(object view, object viewModel, PackIconKind icon, string title)
        {
            this.View = view;
            this.DataContext = viewModel;
            (this.View as UserControl).DataContext = this.DataContext;
            this.Icon = icon;
            this.Title = title;
        }
        #endregion
    }
}
