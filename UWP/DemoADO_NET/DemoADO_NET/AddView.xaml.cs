using System;
using System.Threading.Tasks.Dataflow;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace DemoADO_NET
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AddView : Page
    {
        private readonly DataAccess obj;

        public AddView()
        {
            InitializeComponent();
            obj = new DataAccess();
        }

        private void Save_OnClick(object sender, RoutedEventArgs e)
        {
            var model = new Product()
            {
                Name = this.txtName.Text,
                Type = this.txtType.Text,
                Price = Convert.ToDecimal(this.txtPrice.Text)
            };
            obj.CreateProduct(model);

            Frame.Navigate(typeof(DataList), obj.GetProducts(string.Empty));
        }
    }
}