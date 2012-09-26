using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TechEdDemo.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace TechEdDemo.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainView : Page
    {
        public MainViewModel ViewModel { get; set; }

        public MainView()
        {
            this.InitializeComponent();

            // Get a handle to the ViewModel that was initialised in the <View.DataContext>
            ViewModel = this.DataContext as MainViewModel;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.  The Parameter
        /// property is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        // Increment
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ViewModel.Increment();
        }

        // Double
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            ViewModel.Double();
        }
    }
}
