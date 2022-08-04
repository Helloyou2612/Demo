using System.Collections.Generic;
using System.Linq;

namespace DemoSplitView
{
    public class CarModel
    {
        public string Category { get; set; }
        public string Type { get; set; }
        public string Model { get; set; }
        public string Image { get; set; }
    }

    public class CarManager
    {
        public static List<CarModel> GetData()
        {
            var cars = new List<CarModel>
            {
                new CarModel
                {
                    Category = "BMW",
                    Type = "MPV",
                    Model = "2019",
                    Image = "/Assets/Cars/bmw.jpeg"
                },
                new CarModel
                {
                    Category = "Honda Civic",
                    Model = "2019",
                    Type = "Sedan",
                    Image = "/Assets/Cars/civic.jpeg"
                },
                new CarModel
                {
                    Category = "MayBach",
                    Model = "2019",
                    Type = "Sedan",
                    Image = "/Assets/Cars/maybach.jpg"
                },
                new CarModel
                {
                    Category = "VinFast",
                    Model = "2018",
                    Type = "HatchBack",
                    Image = "/Assets/Cars/Vinfast.jpeg"
                },
                new CarModel
                {
                    Category = "Volvo-XC40",
                    Model = "2021",
                    Type = "MPV",
                    Image = "/Assets/Cars/Volvo-XC40-white-scaled.jpg"
                }
            };
            return cars;
        }

        public static List<CarModel> GetCars(string type)
        {
            return GetData().Where(m => m.Type == type).ToList();
        }
    }
}