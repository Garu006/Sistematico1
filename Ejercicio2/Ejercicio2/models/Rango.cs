using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2.models
{
    internal class Rango
    {
        public int y;
        public int x;

        public Rango(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public void MostrarNumeros(ListBox lb)
        {
            lb.Items.Clear();

            if (x < y)
            {
                for (int i = x; i <= y; i++) 
                {
                    lb.Items.Add(i);
                }
            }
            else
            {
                for (int i = x; i >= y; i--)
                {
                    lb.Items.Add(i);
                }
            }
        }
    }
}
