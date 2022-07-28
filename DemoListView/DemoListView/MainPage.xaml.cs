using System;
using Windows.UI;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoListView
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            // Gán ItemsSource = 1 array
            var colors = new[] { "Red", "Green", "Blue", "Black", "Gray" };
            this.lvData.ItemsSource = colors;
        }

        private async void LvData_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var lvObject = (ListView)sender;
            if (lvObject != null)
            {
                var selected = lvObject.SelectedItem?.ToString();
                var newColor = new SolidColorBrush(Colors.Black);
                var message = "Tiêu đề đã được đổi màu.";
                switch (selected)
                {
                    case "Red":
                        newColor = new SolidColorBrush(Colors.Red);
                        break;
                    case "Green":
                        newColor = new SolidColorBrush(Colors.Green);
                        break;
                    case "Blue":
                        newColor = new SolidColorBrush(Colors.Blue);
                        break;
                    default:
                        message = "Lựa chọn của bạn không thực hiện thành công";
                        break;
                }

                lblTitle.Foreground = newColor;
                var dialog = new MessageDialog(message);
                await dialog.ShowAsync();
            }
        }
    }
}