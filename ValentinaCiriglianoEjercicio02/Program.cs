using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValentinaCiriglianoEjercicio02
{
    class Program
    {
        static void Main(string[] args)
        {
            double ladoA = 0, ladoB = 0, ladoC = 0;


            Console.Write("Ingrese el valor del primer lado del triángulo: ");
            ladoA = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el valor del segundo lado del triángulo: ");
            ladoB = Convert.ToDouble(Console.ReadLine());
            Console.Write("Ingrese el valor del tercer lado del triángulo: ");
            ladoC = Convert.ToDouble(Console.ReadLine());

            if (ladoA == ladoB && ladoB == ladoC)
            {
                Console.WriteLine("El triángulo es equilátero;");

            }
            else
            {
                if (ladoA != ladoB && ladoB != ladoC)
                {
                    Console.WriteLine("El triángulo es escaleno");

                }
                else
                {
                    Console.WriteLine("El triángulo es isósceles");
                }
            }
            if (ladoA + ladoB > ladoC && ladoB + ladoC > ladoA && ladoA + ladoC > ladoB)
            {
                Console.WriteLine("");

            }
            else
            {
                Console.WriteLine("ERROR. Números no correspondientes a un triángulo");

            }


            Console.ReadLine();
        }
    }
}
