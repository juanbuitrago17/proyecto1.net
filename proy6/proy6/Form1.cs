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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bttAceptar1_Click(object sender, EventArgs e)
        {
            
            try {
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
            catch(FormatException) { lblresultado1.Text= " El valor ingresado es incorrecto "; }
        }

        private void bttCerrar1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtNumero1.Text= "";
            lblresultado1.Text= "";
        }
    }
}
