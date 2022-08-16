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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoUWPSQlite
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            DataAccess.InitDb();
            //DataAccess.AddCustomers(new Customer()
            //{
            //    Name = "Trần Thị B",
            //    Email = "btran@gmail.com",
            //    Mobile = "0987123456",
            //    Address = "Hà Nội",
            //    Gender = "F",
            //    Age = 19
            //});
            this.InventoryList.ItemsSource = DataAccess.GetCustomers("B");
        }
    }
}
