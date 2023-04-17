using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora.Operacoes
{
    public class Divisao
    {
        public double Calcular(double num1, double num2)
        {
            if (num2 == 0)
            {
                return 0;
            }

            return num1 / num2;
        }
    }
}
