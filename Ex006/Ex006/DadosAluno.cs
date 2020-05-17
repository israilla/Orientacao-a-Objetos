using System;
using System.Collections.Generic;
using System.Text;

namespace Ex006
{
    class DadosAluno
    {
        public string Nome;
        public double NotaPrimeiroTrimestre, NotaSegundoTrimestre, NotaTerceiroTrimestre;

        public double NotaFinal()
        {
            return NotaPrimeiroTrimestre + NotaSegundoTrimestre + NotaTerceiroTrimestre;
        }
        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double Restante()
        {
            {
                if (Aprovado())
                {
                    return 0;
                }
                else
                {
                    return 60 - NotaFinal();
                }
            }
        }
    }
}
