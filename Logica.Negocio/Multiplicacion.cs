using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Logica.Negocio
{
    class Multiplicacion
    {
        public double Operar(double operandoUno, double operandoDos)
        {
            double elResultado;
            elResultado = operandoUno * operandoDos;
            return (elResultado);
        }
    }
}
