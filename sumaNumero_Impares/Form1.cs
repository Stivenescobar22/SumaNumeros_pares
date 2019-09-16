using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sumaNumero_Impares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtnumero_KeyPress(object sender, KeyPressEventArgs e)
        {

            //if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            //{
            //    MessageBox.Show("Solo se permiten numeros"
            //        , "Advertencia"
            //        , MessageBoxButtons.OK
            //        , MessageBoxIcon.Exclamation);
            //    e.Handled = true;
            //    return;
            //}


            if (char.IsNumber(e.KeyChar))
            {

                e.Handled = false;


            }
            else if (char.IsControl(e.KeyChar))
            {

                e.Handled = false;

            }
            else if (char.IsSeparator(e.KeyChar))
            {

                e.Handled = false;

            }
            else
            {
                MessageBox.Show("Solo se permiten numeros"
                  , "Advertencia"
                  , MessageBoxButtons.OK
                  , MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
                
            }
        }

        private void btncalcular_Click(object sender, EventArgs e)
        {
            string cantidad = txtnumero.Text;
            int cant = int.Parse(cantidad);
            int suma = 0, cont = 0;


            for (int i = 0; i < cant ; i++)
            {

                if (i % 2 == 1)
                {

                    //Font fo = new Font(lblimparessuma.Text);

                    lblimparessuma.Font = new Font("", emSize: 14, style: FontStyle.Bold);
                    suma = suma + i;
                    lblimparessuma.Text = suma.ToString();
                    lblimparessuma.Visible = true;

                }

                txtnumero.Text = "";
                txtnumero.Focus();
                cont++;
            }
        }
    }
}
