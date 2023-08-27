using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace proy7.Pages
{
    public partial class Form4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void bttAceptar4_Click(object sender, EventArgs e)
        {
            try
            {
                int numero = int.Parse(txtNumero4.Text);
                sbyte numeroSbyte = ConvertToSByte(numero);
                lblResultado4.Text="Conversion exitosa a sbyte: "+ numeroSbyte;
                txtNumero4.Text="";
            }
            catch (FormatException)
            {
                lblResultado4.Text="Valor no valido, ingrese otro dato";
                lblResultado4.Text="";

            }
            catch (OverflowException)
            {
                lblResultado4.Text="El valor es demaciado grande y no se puede convertir a sbyte";
                txtNumero4.Text="";

            }
        }
        private sbyte ConvertToSByte(int value)
        {
            if (value >= sbyte.MinValue && value <= sbyte.MaxValue)
            {
                return (sbyte)value;
            }
            else
            {
                throw new OverflowException("El valor esta fuera del rango valido para sbyte,intente nuevamente");
            }
        }
    }
}