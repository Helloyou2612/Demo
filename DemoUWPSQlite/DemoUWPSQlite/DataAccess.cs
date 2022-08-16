using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.IO;
using Windows.ApplicationModel.Chat;
using Windows.Storage;

namespace DemoUWPSQlite
{

    public static class DataAccess
    {
        private static readonly string _dbPath = Path.Combine(ApplicationData.Current.LocalFolder.Path, "T2104E.db");

        public static async void InitDb()
        {
            //Create file db SQLite
            await ApplicationData.Current.LocalFolder.CreateFileAsync("T2104E.db", CreationCollisionOption.OpenIfExists);
            //Open conn to SQLite db
            using (var conn = new SQLiteConnection($"Data Source={_dbPath}"))
            {
                if(conn.State == ConnectionState.Closed)
                    conn.Open();
                //Create sqlite query
                var query = "CREATE TABLE IF NOT EXISTS " +
                            "CUSTOMER (" +
                            "Id      INTEGER PRIMARY KEY AUTOINCREMENT," +
                            "Name    NVARCHAR(250) NOT NULL," +
                            "Email   VARCHAR(250) NOT NULL," +
                            "Mobile  VARCHAR(20) NULL," +
                            "Address NVARCHAR(250) NULL," +
                            "Age     INTEGER DEFAULT 0," +
                            "Gender  VARCHAR(5) DEFAULT O" +
                            ")";
                //Create sqlite command
                var cmd = new SQLiteCommand(query, conn);
                //Execute sqlite command
                cmd.ExecuteReader();
            }
        }

        //Get all customer from SQLite db
        public static List<Customer> GetCustomers(string searchContent)
        {
            var customers = new List<Customer>();
            using (var conn = new SQLiteConnection($"Data Source={_dbPath}"))
            {
                if(conn.State == ConnectionState.Closed)
                    conn.Open();

                var query = "SELECT Id, Name, Email, Mobile, Address, Age, Gender FROM CUSTOMER " +
                            "WHERE Name LIKE '%' || @Search || '%'";

                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Search", searchContent);

                var rows = cmd.ExecuteReader();

                if (!rows.HasRows)
                    return null;

                while (rows.Read())
                {
                    customers.Add(new Customer()
                    {
                        Id = Convert.ToInt32(rows["Id"]),
                        Name = rows["Name"].ToString(),
                        Email = rows["Email"].ToString(),
                        Mobile = rows["Mobile"].ToString(),
                        Address = rows["Address"].ToString(),
                        Age = Convert.ToInt32(rows["Age"]),
                        Gender = rows["Gender"].ToString()
                    });
                }
            }

            return customers;
        }

        public static bool AddCustomers(Customer model)
        {
            var rows = 0;
            using (var conn = new SQLiteConnection($"Data Source={_dbPath}"))
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                var query = "INSERT INTO CUSTOMER (Name, Email, Mobile, Address, Age, Gender) " +
                            "VALUES (@Name, @Email, @Mobile, @Address, @Age, @Gender)";

                var cmd = new SQLiteCommand(query, conn);
                cmd.Parameters.AddWithValue("@Name", model.Name);
                cmd.Parameters.AddWithValue("@Email", model.Email);
                cmd.Parameters.AddWithValue("@Mobile", model.Mobile);
                cmd.Parameters.AddWithValue("@Address", model.Address);
                cmd.Parameters.AddWithValue("@Age", model.Age);
                cmd.Parameters.AddWithValue("@Gender", model.Gender);
                rows = cmd.ExecuteNonQuery();
            }

            return rows > 0;
        }
    }
}