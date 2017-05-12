using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using TreeGenerator.Models;

namespace TreeGenerator.DataAccessLayer
{
    public class DAL
    {
        IDbConnection db = new SqlConnection(ConfigurationManager.ConnectionStrings["treeModel"].ConnectionString);

        public List<Factory> getFactories()
        {
           
            List<Factory> Factories = new List<Factory>(db.Query<Factory>("select ID, parent_ID, name, children_count, low_bound, up_bound FROM Factory"));

            return Factories; 
        }

    }
}