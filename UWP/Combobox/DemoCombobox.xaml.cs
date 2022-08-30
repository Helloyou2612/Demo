using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWPLearning.Controls.Session4.Combobox
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DemoCombobox : Page
    {
        public List<LocationData> source { get; set; }
        public DemoCombobox()
        {
            this.InitializeComponent();

            source = new List<LocationData>
            {
                new LocationData { location = "london" },
                new LocationData { location = "paris" },
                new LocationData { location = "seattle" },
                new LocationData { location = "vancouver" }
            };
        }

        private void LocationComboBox_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var data = LocationComboBox.SelectedItem as LocationData;
            switch (data.location)
            {
                case "london":
                    LocationImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Book/beginning_asp_dot_net_for_visual_studio_2015.jpg"));
                    break;
                case "paris":
                    LocationImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Book/c_sharp_24_hour_trainer_2nd_edition.jpg"));
                    break;
                case "seattle":
                    LocationImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Book/professional_c_sharp_6_and_dot_ner_core_1.jpg"));
                    break;
                case "Rvancouvered":
                    LocationImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/Book/professional_visual_studio_2015.jpg"));
                    break;
            }
        }
    }
    public class LocationData
    {
        public string location { get; set; }
    }
}
