using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO02
{
    public static class ArithmeticExceptionExtensions
    {
        public static void ThrowCustomeException()
        {
            throw new CustomeException();
        }

        public static void Division(this int dividendo, int divisor)
        {   
              try
               {
                   int resultado;
                   resultado = dividendo / divisor;
                   Console.WriteLine("Tu Division da como resultado {0}", resultado);
               }
               catch (DivideByZeroException) 
               { 
                   Console.WriteLine("No se puede dividir por cero. Solo Chuck Norris puede hacerlo!");
                   /*si bien dividir en int no da resultados exactos, al dividir en float/double no me arroja este Console sino que me da
                   resultado infinito, y preferí respetar la consigna de que arroje dicho mensaje en vez de ser preciso con la división
                   ya que no se solicitó eso.*/
               } 
        }
    }
}