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
    public partial class Area : Form
    {
        public Area()
        {
            InitializeComponent();
        }

        private void bttaceptarA_Click(object sender, EventArgs e)
        {
            if (txtRadio.Text == "")
            {
                lblRegistro3.Text = "INGRESE EL RADIO DEL CIRCULO";
            }
            else
            {
                claseAr CA = new claseAr();
                CA.Radio = double.Parse(txtRadio.Text);
                lblRegistro3.Text = "El area del circulo es: " + (CA.Area);
                lblRegistro4.Text = "El perimetro del circulo es: "+ (CA.Peri);
            }
        }

        private void bttcerrar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
