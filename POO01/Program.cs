using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Transporte> transportes = new List<Transporte>{};

            Random random = new Random();

            for (int i = 1; i < 6; i++)
            {
                transportes.Add(new Avion(random.Next(300, 500), $"Avión {i}"));
                transportes.Add(new Automovil(random.Next(2, 5), $"Automóvil {i}"));
            }

           foreach (var item in transportes)
            {
                Console.WriteLine(item.Avanzar());
                Console.WriteLine(item.Detenerse());
            }
            Console.ReadLine();
        }
    }
}
