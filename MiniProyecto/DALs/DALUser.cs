using MiniProyecto.CLASES;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace MiniProyecto.DALs
{
    public class DALUser
    {
        User temp;
        DBConnect cnx;

        public DALUser()
        {
            cnx = new DBConnect();
        }

        public User FindUser(string mail, string password)
        {
            try
            {
                cnx.OpenConection();

                string sql = @"
                SELECT * FROM usuarios WHERE email = @mail AND Password = @pass";

                SqlCommand cmd = new SqlCommand(sql, cnx.conexion);
                SqlParameter email = new SqlParameter("@mail", System.Data.SqlDbType.NVarChar, 50);
                email.Value = mail;
                cmd.Parameters.Add(email);
                SqlParameter pass = new SqlParameter("@pass", System.Data.SqlDbType.NVarChar, 50);
                pass.Value = password;
                cmd.Parameters.Add(pass);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    temp = new User(Convert.ToInt32(dr[0]), dr[1].ToString(), Convert.ToString(dr[2]));

                }



                dr.Close();
                cnx.CloseConnection();
                return temp;
            }
            catch (Exception ee)
            {

                Console.WriteLine("No se ha podido encontrar el user " + ee);
                return null;
            }
        }
    }
}