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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Grados G = new Grados();
            G.Show();
        }

        private void registro_Click(object sender, EventArgs e)
        {
            Registro R = new Registro();
            R.Show();
        }

        private void area_Click(object sender, EventArgs e)
        {
            Area A = new Area();
            A.Show();
        }

        private void cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
