using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pro4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void bttCalcular_Click(object sender, EventArgs e)
        {
            if(txtBase.Text == "" || txtAltura.Text == "") {
                MessageBox.Show("Ingrese un valor, no puede dejar casillas en blanco");
            }
            else
            {
                Triangulo T = new Triangulo();
                string BaseCalcular = txtBase.Text;
                string AlturaCalcular = txtAltura.Text;
                T.Base= double.Parse(BaseCalcular);
                T.Altura = double.Parse(AlturaCalcular);
                lblResultado.Text= "El area del triangulo es: "+ ( T.Area);


            };
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
