using ejercio1.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejercio1
{
    public partial class Form1 : Form
    {
        //creo instancia :3
        Operaciones oper = new Operaciones();
        public Form1()
        {
            InitializeComponent();
        }



        private void tbNum2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbNum1_TextChanged(object sender, EventArgs e)
        {

        }

        private void rbDivision_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbMultiplicacion_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbResta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbSuma_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }

        private void btnAregar_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = double.Parse(tbNum1.Text);
                double numero2 = double.Parse(tbNum2.Text);


                string operacion = "";


                if (rbSuma.Checked)
                    operacion = "Suma";
                else if (rbResta.Checked)
                    operacion = "Resta";
                else if (rbMultiplicacion.Checked)
                    operacion = "Multiplicacion";
                else if (rbDivision.Checked)
                    operacion = "Division";


                double? resultado = oper.Ejericio(numero1, numero2, operacion);


                lblResultado.Text = "Resultado: " + resultado;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ingrese un numero Valid0");
            }
            {

            }
        }
    }
}
