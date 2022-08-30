using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public sealed partial class DemoCombobox2 : Page
    {
        private ObservableCollection<LanguageItem> _languages;
        public DemoCombobox2()
        {
            this.InitializeComponent();
            _languages = new ObservableCollection<LanguageItem>
            {
                new LanguageItem(new BitmapImage(new Uri("ms-appx:///Assets/Flags/vietnam.png")), "Vietnam", "vietnam"),
                new LanguageItem(new BitmapImage(new Uri("ms-appx:///Assets/Flags/canada.png")), "Canada", "canada"),
                new LanguageItem(new BitmapImage(new Uri("ms-appx:///Assets/Flags/china.png")), "China", "china"),
                new LanguageItem(new BitmapImage(new Uri("ms-appx:///Assets/Flags/germany.png")), "Germany", "germany"),
                new LanguageItem(new BitmapImage(new Uri("ms-appx:///Assets/Flags/japan.png")), "Japan", "japan"),
                new LanguageItem(new BitmapImage(new Uri("ms-appx:///Assets/Flags/russia.png")), "Russia", "russia"),
                new LanguageItem(new BitmapImage(new Uri("ms-appx:///Assets/Flags/united-kingdom.png")), "United Kingdom", "united-kingdom")
            };
        }

        private void Selector_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }
    }
    public class LanguageItem
    {
        public BitmapImage Image { get; set; }
        public string Label { get; set; }
        public string Culture { get; set; }

        public LanguageItem(BitmapImage image, string label, string culture)
        {
            Image = image;
            Label = label;
            Culture = culture;
        }
    }
}
