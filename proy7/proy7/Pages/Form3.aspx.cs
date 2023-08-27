using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proy7.Pages
{
    public partial class Form3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bttAceptar3_Click(object sender, EventArgs e)
        {

            try
            {
                double num3;
                int contador = 0;
                num3=double.Parse(txtNumero3.Text);
                if (num3>1)
                {
                    int divisor = 1;
                    while (divisor<=num3)
                    {
                        if (num3 % divisor == 0)
                        {
                            contador++;
                        }
                        divisor++;
                    }
                    if (contador==2)
                    {
                        lblR.Text= "El numero "+ num3 + " es un numero primo";
                    }
                    else
                    {
                        lblR.Text= "El numero "+ num3 + " no es un numero primo";
                    }


                }
                else
                {
                    lblR.Text= "El dato es menor a 1 ingrese otro dato mayor a 1";

                }
            }
            catch (FormatException) { lblR.Text = "El valor ingresado es incorrecto "; }
        }
    }
}