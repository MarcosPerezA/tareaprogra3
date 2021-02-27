using System;

namespace elevar_numero
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, p, i, r = 1;

            Console.WriteLine("Ingrese el numero base ");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el exponente al que desea elevar el numero base ");
            p = int.Parse(Console.ReadLine());

            for (i = 1; i<= p; i++)
            {

                r = r * n;

               
            }
            Console.WriteLine("su resultado es " + r);
        }
    }
}
