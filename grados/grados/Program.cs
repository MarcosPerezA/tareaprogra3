using System;

namespace grados
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, r, g;
            Console.WriteLine("eliga que operacion desea hacer");
            Console.WriteLine("1.GRADOS A RADIANES");
            Console.WriteLine("2.RADIANES A GRADOS");
            a = Convert.ToDouble(Console.ReadLine());

            if (a == 1)
            {
                Console.WriteLine("ingrese los grados  ");
                g = double.Parse(Console.ReadLine());
                r = (3.1416 / 180) * g;
                Console.WriteLine("la cantidad en radianes es  " + r);
            }
            else
            {

                Console.WriteLine("ingrese los radianes ");
                r = Convert.ToDouble(Console.ReadLine());
                g = (180 / 3.1416);
                Console.WriteLine("la cantidad en grados es " + g);
            }
        }
    }
}
