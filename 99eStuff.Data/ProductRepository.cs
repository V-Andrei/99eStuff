﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _99eStuff.BusinessLogic;
using System.Configuration;

namespace _99eStuff.Data
{
    public class ProductRepository
    {
        SqlCommand cmd;
        SqlDataAdapter da;
        DataSet ds;
      
        public static SqlConnection connect()
        {
            string connection = ConfigurationManager.ConnectionStrings["ProductsModel"].ConnectionString;
            SqlConnection con = new SqlConnection(connection);
            if(con.State==ConnectionState.Open)
            {
                con.Close();

            }
            else
            {
                con.Open();
            }


            return con;

        }

        public bool DMLOpperation(string query)
        {
            cmd = new SqlCommand(query, ProductRepository.connect());
            int x= cmd.ExecuteNonQuery();
            if(x==1)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public DataTable GetAll(string query)
        {
            da = new SqlDataAdapter(query, ProductRepository.connect());
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
