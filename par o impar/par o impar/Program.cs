using System;

namespace par_o_impar
{
    class Program
    {
        static void Main(string[] args)
        {

            int n;
            Console.WriteLine("INGRESE UN NUMERO");
            n = int.Parse(Console.ReadLine());
            if ((n % 2) == 0)
            {
                Console.WriteLine("EL NUMERO ES PAR");
            }
            else
            {
                Console.WriteLine("EL NUMERO ES IMPAR");
            }
        }
    }
}
