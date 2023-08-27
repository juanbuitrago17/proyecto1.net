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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void bttCerrar3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttlimpiar3_Click(object sender, EventArgs e)
        {
            txtNumero3.Text ="";
            lblR.Text="";
        }

        private void bttAceptar3_Click(object sender, EventArgs e)
        {
            
            try
            {
                double num3;
                int contador=0;
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
                    if(contador==2)
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

