using System.Collections.ObjectModel;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoSplitView
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly ObservableCollection<CarModel> Cars;

        public MainPage()
        {
            InitializeComponent();
            Cars = new ObservableCollection<CarModel>();
        }

        private void BtnHamburger_OnClick(object sender, RoutedEventArgs e)
        {
            MySplitView.IsPaneOpen = !MySplitView.IsPaneOpen;
        }

        private void BtnMVP_OnClick(object sender, RoutedEventArgs e)
        {
            var mpvCars = CarManager.GetCars("MPV");
            
            Cars.Clear();
            foreach (var item in mpvCars)
            {
                Cars.Add(item);
            }
        }

        private void BtnHatchBack_OnClick(object sender, RoutedEventArgs e)
        {
            var hatchBackCars = CarManager.GetCars("HatchBack");

            Cars.Clear();
            foreach (var item in hatchBackCars)
            {
                Cars.Add(item);
            }
        }

        private void BtnSedan_OnClick(object sender, RoutedEventArgs e)
        {
            var sedanCars = CarManager.GetCars("Sedan");

            Cars.Clear();
            foreach (var item in sedanCars)
            {
                Cars.Add(item);
            }
        }

        private void GridView_OnItemClick(object sender, ItemClickEventArgs e)
        {
        }
    }
}