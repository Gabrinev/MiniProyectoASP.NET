﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiniProyecto
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void btnLogOut_Click(object sender, EventArgs e)
        {
            Global.signed = null;
            Response.Redirect("Default.aspx");
        }
        
    }
}