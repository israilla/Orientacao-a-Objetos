using System;
using System.Collections.Generic;
using System.Text;

namespace Ex007
{
    class CotarDolar
    {
        public static double Iof = 6.0;

        public static double DolarReal(double qte, double cotacao)
        {
            double total = qte * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}
