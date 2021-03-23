using System;
using Microsoft.UI.Xaml.Controls;
using Syncfusion.UI.Xaml.Scheduler;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DataBinding
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.InitializeComboBoxItemSource();
        }

        /// <summary>
        /// Method to get all scheduler view types.
        /// </summary>
        private void InitializeComboBoxItemSource()
        {
            this.viewType.ItemsSource = Enum.GetValues(typeof(SchedulerViewType));
        }
    }
}
