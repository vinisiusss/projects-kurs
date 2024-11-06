using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Геофизика_фалй
{
    internal class DataBase
    {

        SqlConnection sqlconnection = new SqlConnection(@"Data Source =LAPTOP-Q8IH09G9\MSSQLSERVER01; Initial Catalog=register;Integrated Security=True ");
        
        public void openConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Closed)
            {
                sqlconnection.Open();
            }
        }

        public void closeConnection()
        {
            if (sqlconnection.State == System.Data.ConnectionState.Open)
            {
                sqlconnection.Close();
            }
        }


        public SqlConnection getConnection()
        {
            return sqlconnection;
        }


    }
}
