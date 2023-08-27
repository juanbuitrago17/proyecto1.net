using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proy6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void bttCerrar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttlimpiar2_Click(object sender, EventArgs e)
        {
            txtNumero2.Text="";
            lblResultado2.Text="";
        }

        private void bttAceptar2_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                double num2;
                num2=double.Parse(txtNumero2.Text);
                if (num2<=12)
                {
                    string Resultado;
                    switch (num2)
                    {
                        case 1: Resultado=" hace referencia al mes de Enero"; break;
                        case 2: Resultado = " hace referencia al mes de Febrero"; break;
                        case 3: Resultado = " hace referencia al mes de Marzo"; break;
                        case 4: Resultado = " hace referencia al mes de Abril"; break;
                        case 5: Resultado = " hace referencia al mes de Mayo"; break;
                        case 6: Resultado = " hace referencia al mes de Junio"; break;
                        case 7: Resultado = " hace referencia al mes de Julio"; break;
                        case 8: Resultado = " hace referencia al mes de Agosto"; break;
                        case 9: Resultado = " hace referencia al mes de Septiembre"; break;
                        case 10: Resultado = " hace referencia al mes de Octubre"; break;
                        case 11: Resultado = " hace referencia al mes de Noviembre"; break;
                        case 12: Resultado = " hace referencia al mes de Diciembre"; break;
                        default: throw new Exception(Resultado = " ingresado es incorrecto");
                    }
                    lblResultado2.Text="El " + num2+"" +Resultado+".";
                }
                else { lblResultado2.Text="El " + num2+" ingresado es incorrecto "; }
            }
            catch (FormatException) { lblResultado2.Text= " El valor ingresado es incorrecto "; }
        }
    }
}
