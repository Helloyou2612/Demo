using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoADO_NET
{
    public class DataAccess
    {
        private readonly SqlConnection _conn;

        //Chuỗi kết nối 
        private readonly string _connStr =
            @"Data Source=DESKTOP-CSPRV0T;Initial Catalog=UWP_ADO; User Id=sa; Password=123456";

        public DataAccess()
        {
            _conn = new SqlConnection(_connStr);
        }

        public List<Product> GetProducts(string searchContent)
        {
            var products = new List<Product>();
            try
            {
                if (_conn.State == ConnectionState.Closed)
                    _conn.Open();
                //Build sql query
                var query = "SELECT Id, Name, Type, Price FROM Product " +
                            "WHERE (ISNULL(@SearchContent,'')='' OR Name like '%' + @SearchContent + '%')";
                //Create SqlCommand object
                var cmd = new SqlCommand(query, _conn);
                //Add param for search conditions
                cmd.Parameters.AddWithValue("@SearchContent", searchContent);
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

                    products.Add(product);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                _conn.Close();
            }

            return products;
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
            }

            return rowEff > 0;
        }

    }
}
