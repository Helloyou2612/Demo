using System;
using System.Collections.Generic;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DemoADO_NET
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class DataList : Page
    {
        private readonly DataAccess _dataAccess;
        private long _id;

        public DataList()
        {
            InitializeComponent();
            _dataAccess = new DataAccess();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            var data = (List<Product>)e.Parameter;
            ProductList.ItemsSource = data;
        }

        private void ProductList_OnSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var obj = (Product)ProductList.SelectedItem;
            Frame.Navigate(typeof(DetailView), obj);
        }


        private void MenuEdit_OnClick(object sender, RoutedEventArgs e)
        {
            var obj = (MenuFlyoutItem)sender;
            //Get data of row selected
            _id = long.Parse(obj.Tag.ToString());
            Frame.Navigate(typeof(EditVIew), _id);
        }

        private async void MenuDel_OnClick(object sender, RoutedEventArgs e)
        {
            var contentDialog = new ContentDialog
            {
                Title = "Delete",
                Content = "You are sure to delete the item selected!",
                CloseButtonText = "Cancel",
                PrimaryButtonText = "Delete",
                DefaultButton = ContentDialogButton.Close
            };

            var obj = (MenuFlyoutItem)sender;
            //Get data of row selected
            _id = long.Parse(obj.Tag.ToString());
            
            #region solution 1
            var result = await contentDialog.ShowAsync();
            if (result == ContentDialogResult.Primary)
            {
                _dataAccess.DeleteProduct(_id);
                ProductList.ItemsSource = _dataAccess.GetProducts(string.Empty);
            }
            #endregion solution 1

            #region solution 2

            //contentDialog.PrimaryButtonClick += Dialog_PrimaryButtonClick;
            //await contentDialog.ShowAsync();
            #endregion solution 2

            #region solution 3
            //contentDialog.PrimaryButtonClick += async (dialog, args) =>
            //{
            //    _dataAccess.DeleteProduct(_id);
            //    ProductList.ItemsSource = _dataAccess.GetProducts(string.Empty);
            //    await contentDialog.ShowAsync();
            //};

            #endregion solution 3
        }

        private void Dialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            _dataAccess.DeleteProduct(_id);
            ProductList.ItemsSource = _dataAccess.GetProducts(string.Empty);
        }
    }
}