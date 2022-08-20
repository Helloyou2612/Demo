using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPLearning.Controls.Session5.Navigation.Demo3
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class NavigateHome2 : Page
    {
        public NavigateHome2()
        {
            this.InitializeComponent();
            lstData.ItemsSource = GetSampleData();
        }

        private void LstData_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // Get the instance of ListView
            if (!(sender is Windows.UI.Xaml.Controls.ListView listView))
                return;

            // Get the ListView selected item as a Book
            var selectedBook = listView.SelectedItem as BookInfo;

            MyFrame.Navigate(typeof(Details), selectedBook);

        }

        public List<BookInfo> GetSampleData()
        {
            return new List<BookInfo>
            {
                // Add some items to collection
                new BookInfo(
                    "Professional C# 6 and .NET Core 1.0",
                    "Christian Nagel",
                    "$60.00",
                    "/Assets/Book/professional_c_sharp_6_and_dot_ner_core_1.jpg"
                ),
                new BookInfo(
                    "Beginning ASP.NET for Visual Studio 2015",
                    "William Penberthy",
                    "$45.00",
                    "/Assets/Book/beginning_asp_dot_net_for_visual_studio_2015.jpg"
                ),
                new BookInfo(
                    "C# 24-Hour Trainer, 2nd Edition",
                    "Rod Stephens",
                    "$45.00",
                    "/Assets/Book/c_sharp_24_hour_trainer_2nd_edition.jpg"
                ),
                new BookInfo(
                    "Professional Visual Studio 2015",
                    "Bruce Johnson",
                    "$60.00",
                    "/Assets/Book/professional_visual_studio_2015.jpg"
                )
            };
        }
    }
}
