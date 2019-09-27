using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace Blanchisserie
{
    class Connection
     {
        private static SqlConnection instance = null;
        private static object _lock = new object();
        private SqlCommand command;
        private SqlDataReader reader;

        
        public static SqlConnection Instance
    {
        get
        {
            lock (_lock)
            {
                if (instance == null)
                    instance = new SqlConnection(@"Data Source=(localdb)\Blanchisserie;Integrated Security=True");
                return instance;
            }
        }
    }


    //private SqlConnection connection;
    

        private Connection()
        {
           
        }










    }
}
