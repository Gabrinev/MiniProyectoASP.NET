using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MiniProyecto.CLASES
{
    public class DBConnect
    {
        public SqlConnection conexion;

        public void OpenConection()
        {
            conexion = new SqlConnection(Properties.Settings.Default.connstr);
            conexion.Open();

        }


        public void CloseConnection()
        {
            conexion.Close();
        }
    }
}