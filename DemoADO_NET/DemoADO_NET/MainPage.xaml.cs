using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoADO_NET
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly DataAccess obj;
        public MainPage()
        {
            InitializeComponent();
            obj = new DataAccess();
            
            MyFrame.Navigate(typeof(DataList), obj.GetProducts(string.Empty));
            //this.ProductList.ItemsSource = GetProducts(string.Empty);
        }
        private void BtnSearch_OnClick(object sender, RoutedEventArgs e)
        {
            //this.ProductList.ItemsSource = GetProducts(this.txtSearch.Text);
            MyFrame.Navigate(typeof(DataList), obj.GetProducts(this.txtSearch.Text));
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            MyFrame.Navigate(typeof(AddView));
        }
    }
}