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
        private long _id;
        public EditVIew()
        {
            this.InitializeComponent();
            _dataAccess = new DataAccess();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            _id = (long)e.Parameter;
            this.DataContext = _dataAccess.GetProductDetail(_id);
        }

        private void BtnEdit_OnClick(object sender, RoutedEventArgs e)
        {
            _dataAccess.EditProduct(new Product()
            {
                Id = _id,
                Name = this.txtName.Text,
                Type = this.txtType.Text,
                Price = decimal.Parse(this.txtPrice.Text)
            });

            Frame.Navigate(typeof(DataList), _dataAccess.GetProducts(string.Empty));
        }
    }
}
