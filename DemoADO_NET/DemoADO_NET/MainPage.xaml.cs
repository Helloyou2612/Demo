using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DemoADO_NET
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private readonly SqlConnection _conn;

        //Chuỗi kết nối 
        private readonly string _connStr =
            @"Data Source=DESKTOP-CSPRV0T;Initial Catalog=UWP_ADO; User Id=sa; Password=123456";

        private readonly List<Product> _products;

        public MainPage()
        {
            InitializeComponent();
            _products = new List<Product>();
            _conn = new SqlConnection(_connStr);

            CreateProduct(new Product()
            {
                Name = "Surface ABC",
                Type = "Tablet",
                Price = 1100
            });


            GetProducts();
        }

        public List<Product> GetProducts()
        {
            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();
                //Build sql query
                var query = "SELECT Id, Name, Type, Price FROM Product";
                //Create SqlCommand object
                var cmd = new SqlCommand(query, _conn);
                //Executed sql query
                var dataReader = cmd.ExecuteReader();
                //Check dataReader hasRows before reader data
                if (!dataReader.HasRows)
                    return null;
                //Read data from DataReader
                while (dataReader.Read())
                {
                    #region Solution 1

                    //var product = new Product()
                    //{
                    //    Id = dataReader.GetInt64(0),
                    //    Name = dataReader.GetString(1),
                    //    Type = dataReader.GetString(2),
                    //    Price = dataReader.GetDecimal(3)
                    //};

                    #endregion Solution 1

                    #region Solution 2

                    var product = new Product
                    {
                        Id = Convert.ToInt64(dataReader["Id"]),
                        Name = dataReader["Name"].ToString(),
                        Type = dataReader["Type"].ToString(),
                        Price = Convert.ToDecimal(dataReader["Price"])
                    };

                    #endregion Solution 2

                    _products.Add(product);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
                _conn.Dispose();
            }

            return _products;
        }

        public bool CreateProduct(Product model)
        {
            var rowEff = 0;
            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();

                var query = "INSERT INTO Product(Name, Type, Price) VALUES (@Name, @Type, @Price)";

                var commad = new SqlCommand(query, _conn);
                commad.Parameters.AddWithValue("@Name", model.Name);
                commad.Parameters.AddWithValue("@Type", model.Type);
                commad.Parameters.AddWithValue("@Price", model.Price);

                rowEff = commad.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
                _conn.Dispose();
            }

            return rowEff > 0;
        }
    }
}