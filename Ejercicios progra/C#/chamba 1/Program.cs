using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chamba_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            string apellido;
            int[] ventas = new int[30];

            Console.WriteLine("Ingrese su nombre :");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Su nombre es: {nombre}");

            Console.WriteLine("Ingrese su apellido :");
            apellido = Convert.ToString(Console.ReadLine());
            Console.WriteLine($"Su apellido es: {apellido}");

            for (int i = 0;i <30; i++)
            {
                Console.WriteLine("Ingrese las ventas");
                ventas[i] = Convert.ToInt64()

            }
















            Console.ReadKey();
               {

            }



        }
    }
}
