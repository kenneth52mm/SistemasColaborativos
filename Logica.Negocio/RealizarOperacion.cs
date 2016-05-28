using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica.Negocio
{
    public class RealizarOperacion
    {
        double Calcular(double operandoUno, double operandoDos,
                        string operador)
        {
            double elResultado = 0.0;

            switch (operador)
            {
                case "+":
                    
                    elResultado = new Suma().Operar(operandoUno, operandoDos);
                    break;


                case "-":
                    elResultado = new Resta().Operar(operandoUno, operandoDos);
                    break;

                case "*":
                    elResultado = new  Multiplicacion().Operar(operandoUno, operandoDos);
                    break;

                case "/":
                    elResultado = new Division().Operar(operandoUno, operandoDos);
                    break;

            }
            return (elResultado);
        }
    }
}
