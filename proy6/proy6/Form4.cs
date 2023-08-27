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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bttCerrar4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bttAceptar4_Click(object sender, EventArgs e)
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
        private sbyte ConvertToSByte(int value) {
            if (value >= sbyte.MinValue && value <= sbyte.MaxValue) {
                return (sbyte)value;
            }
            else {
                throw new OverflowException("El valor esta fuera del rango valido para sbyte,intente nuevamente");
            }
        }
    }
}
