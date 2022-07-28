using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DemoUWP
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class GridCell : Page
    {
        public GridCell()
        {
            InitializeComponent();
        }

        private async void btnSave_DoubleTapped(object sender, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
        {
            var dialog = new ContentDialog
            {
                Title = "Info",
                Content = $"{txtFirstName.Text} {txtLastName.Text} - {txtEmail.Text}",
                CloseButtonText = "OK"
            };

            await dialog.ShowAsync();
        }
    }
}