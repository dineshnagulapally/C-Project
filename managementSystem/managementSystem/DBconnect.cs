using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
namespace managementSystem
{
    internal class DBconnect
    {

        public MySqlConnection getconnection
        {
            get { return conn; }
        }
        //create connection

        MySqlConnection conn = new MySqlConnection("datasource=localhost;port=3307;username=root;password=;database=student");
        //get connection
       
        public void OpenConnect()
        {
            if(conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
            //close connection
            
        }
        public void CloseConnect()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
