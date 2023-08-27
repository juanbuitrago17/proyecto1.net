using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro5
{
    public partial class Grados : Form
    {
        public Grados()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bttaceptarC_Click(object sender, EventArgs e)
        {
            if(txtcelcius.Text == "") {
                lblRegistro2.Text = "Ingrese los gradoa celcius a convertir en gragos fahrenheit";
            } 
            else
            {
                claseGr CG = new claseGr();
                CG.Celcius = double.Parse(txtcelcius.Text);
                lblRegistro2.Text= "los grados celcius que usted inserto convertidos a grados fahrenheit son: "+(CG.Fahre);
            }
        }

        private void bttcerrar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
