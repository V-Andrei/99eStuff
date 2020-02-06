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
            List<Products> list = GetProducts();
            return list;
        }

        private List<Products> GetProducts()
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
                while (reader.Read())
                {
                    var iD = (int)reader["ID"];
                    var nameProduct = reader["NameProduct"] as string;
                    var category = reader["Category"] as string;
                    var stock = (int)reader["Stock"];
                    var currentPrice = (decimal)reader["CurentPrice"];
                    var oldPrice = (decimal)reader["OldPrice"];
                    var smallPicture = (byte[])reader["SmallPicture"];
                    var bigPicture = (byte[])reader["BigPicture"];
                    var description = reader["Description"] as string;
                    var detail1 = reader["Detail1"] as string;
                    var detail2 = reader["Detail2"] as string;
                    var detail3 = reader["Detail3"] as string;
                    var detail4 = reader["Detail4"] as string;

                    list.Add(new Products
                    {
                        ID = iD,
                        NameProduct = nameProduct,
                        Category = category,
                        Stock = stock,
                        CurrentPrice = currentPrice,
                        OldPrice = oldPrice,
                        SmallPicture = smallPicture,
                        BigPicture = bigPicture,
                        Description = description,
                        Detail1 = detail1,
                        Detail2 = detail2,
                        Detail3 = detail3,
                        Detail4 = detail4                       
                    });

                }
            }

            return list;
        }
    }
}
