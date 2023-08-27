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
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
        }

        private void bttaceptarR_Click(object sender, EventArgs e)
        {
            if(txtnombre.Text == "" || txtedad.Text == "" || txtgrado.Text=="")
            {
                lblRegistro.Text = " Ingrese los datos del estudiante completo "; 
            }
            else
            {
                claseRe CR = new claseRe();
                CR.Nombre = txtnombre.Text;
                CR.Edad= double.Parse(txtedad.Text);
                CR.Grado = txtgrado.Text;
                lblRegistro.Text = "El estudiante se llama: "+ (CR.Nombre) + " y su edad es: "+ (CR.Edad) + 
                    " y el grado es: " + (CR.Grado);

            }
        }

        private void bttcerrar2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
