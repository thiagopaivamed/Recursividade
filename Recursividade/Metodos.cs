using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursividade
{
    public class Metodos
    {
        public Metodos()
        {

        }

        public int CalcularPotencia(int numeroBase, int expoente, int resultado)
        {
            if (expoente == 0)
                return resultado;
            else if (expoente > 0)
                return CalcularPotencia(numeroBase, expoente - 1, resultado * numeroBase);
            else
                return resultado;
        }        

        public int CalcularFatorial(int numero)
        {
            if (numero == 0 || numero == 1)
                return 1;
            else
                return numero * CalcularFatorial(numero - 1);
        }
    }
}
