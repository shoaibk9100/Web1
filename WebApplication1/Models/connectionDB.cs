using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class connectionDB
    {
        public static SqlConnection my_SqlCons;

        public static SqlConnection GetCons()
        {
            if (my_SqlCons == null) {
                my_SqlCons = new SqlConnection();
                my_SqlCons.ConnectionString = ConfigurationManager.ConnectionStrings["crudDb_ins"].ConnectionString;
                my_SqlCons.Open();
            }
            return my_SqlCons;
        }
    }
}