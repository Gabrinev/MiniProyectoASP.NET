using MiniProyecto.CLASES;
using MiniProyecto.DALs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace MiniProyecto
{
    public partial class _Default : Page
    {
        User temp = null;
        protected void Page_Load(object sender, EventArgs e)
        {

            if (Global.signed != null)            
                Panel1.Visible = false;            
            else
                Panel1.Visible = true;



        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            DALUser daluser = new DALUser();
            temp = daluser.FindUser(txtMail.Text, txtPassword.Text);
            if (temp != null)
            {
                Global.signed = temp;
                Response.Redirect("Diagram.aspx");
                btnLogin.Visible = false;
                
            }
            else
            {
                Console.WriteLine("No encontrado");
                ScriptManager.RegisterStartupScript(this, typeof(Page), "alerta", "Usuario no encontrado", false);

            }
        }        
    }
}