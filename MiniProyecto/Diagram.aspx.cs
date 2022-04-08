using MiniProyecto.CLASES;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MiniProyecto
{
    public partial class About : Page
    {
        Diagrama diag = new Diagrama();
        List<Image> imgs = new List<Image>();
        string urlRect = "https://e7.pngegg.com/pngimages/68/356/png-clipart-laptop-rectangle-drawing-computer-geometry-rectangulo-angle-text.png";
        string urlRomb = "https://cdn-icons-png.flaticon.com/512/32/32390.png";
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Global.signed == null)
            {
                Response.Redirect("Default.aspx");
            }
            imgs.Add(img);
            imgs.Add(img1);
            imgs.Add(img2);
            imgs.Add(img3);
            imgs.Add(img4);

           
        }

        protected void btnAddShape_Click(object sender, EventArgs e)
        {
            Forma temp;
            
            if (rbRectangulo.Checked)
            {
                temp = new Rectangulo("rectangulo");
                diag.añadirForma(temp);
                selectAndModImg(urlRect);


            }
            else if (rbRombo.Checked)
            {
                temp = new Rectangulo("rectangulo");
                diag.añadirForma(temp);
                selectAndModImg(urlRomb);

            }           
        }

        protected void selectAndModImg(string url)
        {

            foreach (Image image in imgs)
            {
                if (image.ImageUrl == "")
                {
                    image.ImageUrl = url;
                    image.Visible = true;
                    return;
                }
            }
        }
    }
}