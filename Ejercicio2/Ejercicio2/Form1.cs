using Ejercicio2.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Ejercicio2
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

        private void btnRango_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(tbRangox.Text);
                int y = int.Parse(tbRangoy.Text);

                
                Rango rango = new Rango(x, y);

                
                rango.MostrarNumeros(lb);
            }
            catch (FormatException)
            {
                MessageBox.Show("Por favor ingresa números válidos en ambos campos.");
            }
        }
    }
}
