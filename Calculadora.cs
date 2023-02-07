using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula47
{
    internal class Calculadora
    {
        public static double Pi = 3.14;
        
        public static double Circunferencia(double r)
        {
            return (r * 2 * Pi);
        }

        public static double Volume(double r)
        {
            return 4 / 3 * Pi * r * r * r;
        }
    }
}
