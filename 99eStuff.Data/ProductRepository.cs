using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _99eStuff.BusinessLogic;

namespace _99eStuff.Data
{
    public class ProductRepository : IProductsRepository
    {
        private readonly SqlConnection connection;

        public ProductRepository(SqlConnection connection)
        {
            this.connection = connection;
        }

        public List<Products> GetAll()
        {
            var list = new List<Products>();

            var query = "select * from Products";
            var command = new SqlCommand
            {
                CommandText = query,
                Connection = this.connection
            };

            using (var reader = command.ExecuteReader())
            {
                while(reader.Read())
                {
                    var iD = (int)reader["ID"];
                    var iDDetailed = (int)reader["IDDetailed"];
                    var nameProduct = reader["NameProduct"] as string;
                    var category = reader["Category"] as string;
                    var currentPrice = (decimal)reader["CurentPrice"];
                    var oldPrice = (decimal)reader["OldPrice"];
                    var smallPicture = (byte[])reader["SmallPicture"];

                    list.Add(new Products
                    {
                        ID = iD,
                        IDDetailed = iDDetailed,
                        NameProduct = nameProduct,
                        Category = category,
                        CurrentPrice = currentPrice,
                        OldPrice = oldPrice,
                        SmallPicture = smallPicture

                    });

                }
            }
            return list;
        }
    }
}
