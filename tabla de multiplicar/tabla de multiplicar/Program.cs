using System;

namespace tabla_de_multiplicar
{
    class Program
    {
        static void Main(string[] args)
        {
           
           
                int a, b, c;

                Console.WriteLine("Ingrese un numero para mostrar su tabla de multiplicar ");
                a = int.Parse(Console.ReadLine());

                for (c = 1; c <= 10; c++)
                {

                    b = c * a;
                    Console.WriteLine(" " + a + "* " + c + "= " + b);
                }
            

        }
    }
}
