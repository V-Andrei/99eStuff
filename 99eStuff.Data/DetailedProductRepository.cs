using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _99eStuff.BusinessLogic;

namespace _99eStuff.Data
{
    public class DetailedProductRepository : IDetailedProductsRepository
    {
        private readonly SqlConnection connection;

        public DetailedProductRepository(SqlConnection connection)
        {
            this.connection = connection;
        }

        public List<DetailedProducts> GetAll()
        {
            var list = new List<DetailedProducts>();

            var query = "select * from DetailedProducts";
            var command = new SqlCommand
            {
                CommandText = query,
                Connection = this.connection
            };

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    var iDDetailed = (int)reader["IDDetailed"];
                    var material = reader["Material"] as string;
                    var productWeight = (int)reader["ProductWeight"];
                    var size = reader["Size"] as string;
                    var stock = (int)reader["Stock"];
                    var bigPicture = (byte[])reader["BigPicture"];
                    var detail1 = reader["Detail1"] as string;
                    var detail2 = reader["Detail2"] as string;
                    var detail3 = reader["Detail3"] as string;
                    var detail4 = reader["Detail4"] as string;
                    var detail5 = reader["Detail5"] as string;
                    var description = reader["Description"] as string;

                    list.Add(new DetailedProducts
                    {                       
                        IDDetailed = iDDetailed,
                        Material = material,
                        ProductWeight = productWeight,
                        Size = size,
                        Stock = stock,
                        BigPicture = bigPicture,
                        Detail1 = detail1,
                        Detail2 = detail2,
                        Detail3 = detail3,
                        Detail4 = detail4,
                        Detail5 = detail5,
                        Description = description,
                    });

                }
            }
            return list;
        }
    }
}
