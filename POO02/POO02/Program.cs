using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO02
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {
                Console.WriteLine("Ingresa tu dividendo");
                int dividendoInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingresa tu divisor");
                int divisorInt = Convert.ToInt32(Console.ReadLine());
                dividendoInt.Division(divisorInt);
            }
            catch (DivideByZeroException) //ejercicio 1 y parte del ejercicio 2
            {
                Console.WriteLine("No se puede dividir por cero. Solo Chuck Norris puede hacerlo!");
            }
            catch (Exception)
            {
                Console.WriteLine("Seguro Ingresó una letra o no ingresó nada!");
            }
            finally
            {
                Console.WriteLine("La operación ha finalizado.");
            }
 



            try
            {
             Logic.Nombre();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Logic Exception Catched! {ex.Message}");
                Console.WriteLine($"StackTrace Warning! {ex.StackTrace}");
            }


            

            try
            {
                ArithmeticExceptionExtensions.ThrowCustomeException();
            }
            catch (CustomeException ex)
            {
                Console.WriteLine($"Custome Exception Catched! {ex.Message}");
                Console.WriteLine($"StackTrace Warning! {ex.StackTrace}");
            }
            finally
            {
                Console.WriteLine("Finally Check.");
            }

            Console.WriteLine("End.");
            Console.ReadLine();
        } 
    } 
}
