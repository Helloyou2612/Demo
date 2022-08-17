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
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DemoADO_NET
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class EditVIew : Page
    {
        private readonly DataAccess _dataAccess;
        public EditVIew()
        {
            this.InitializeComponent();
            _dataAccess = new DataAccess();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var data = (Product)e.Parameter;
            this.DataContext = data;
        }

        private void BtnEdit_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(DataList), _dataAccess.GetProducts(string.Empty));
        }
    }
}
