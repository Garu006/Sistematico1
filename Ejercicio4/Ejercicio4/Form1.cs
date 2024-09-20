using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio4
{
    public partial class Form1 : Form
    {
        private int intentos = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void LimpiarCampos()
        {
            tbUsuario.Clear();
            tbPassword.Clear();
        }

        private void btnRegistro_Click(object sender, EventArgs e)
        {
            if (int.TryParse(tbUsuario.Text, out int usuario) && int.TryParse(tbPassword.Text, out int password))
            {
                intentos++;

                if (usuario == 12 && password == 1234)
                {
                    MessageBox.Show("Inicio de sesión exitoso", "Acceso Permitido", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimpiarCampos();
                    intentos = 0;
                }
                else
                {
                    if (intentos < 3)
                    {
                        MessageBox.Show($"Usuario o contraseña incorrectos. Intentos restantes: {3 - intentos}", "Error de acceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        MessageBox.Show("Se ha alcanzado el número máximo de intentos. Acceso bloqueado.", "Acceso Denegado", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        btnRegistro.Enabled = false;
                    }
                }
            }
            else
            {
                MessageBox.Show("Debe ingresar valores numéricos en ambos campos", "Entrada Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
