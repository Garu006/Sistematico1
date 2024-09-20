using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercio1.models
{
    internal class Operaciones
    {
        public double? Ejericio(double num1, double num2, string operacion)
        {
            double? resultado = null;

            switch (operacion)
            {
                case "Suma":
                    resultado = num1 + num2;
                    break;
                case "Resta":
                    resultado = num1 - num2;
                    break;
                case "Multiplicacion":
                    resultado = num1 * num2;
                    break;
                case "Division":
                    if (num2 != 0)
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        throw new Exception("No se puede dividir entre un 0");
                    }
                    break;
                default:
                    throw new Exception("Ingrese algo basico");
            }

            return resultado;
        }
    }
}
