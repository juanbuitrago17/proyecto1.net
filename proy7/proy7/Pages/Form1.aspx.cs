using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proy7.Pages
{
    public partial class Form1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void bttAceptar1_Click(object sender, EventArgs e)
        {
            try
            {
                double num;
                num=double.Parse(txtNumero1.Text);
                if (num>0)
                {
                    lblresultado1.Text= "EL " +num + " es positivo ";
                }
                else if (num<0)
                {
                    lblresultado1.Text= "EL " +num + " es negativa ";
                }
                else { lblresultado1.Text= "EL " +num + " es cero "; }
            }
            catch (FormatException) { lblresultado1.Text= " El valor ingresado es incorrecto "; }
        }
    }
}