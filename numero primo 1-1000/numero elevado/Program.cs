using System;

namespace numero_elevado
{
    class Program
    {
        static void Main(string[] args)
        {
            int c=0,i,j = 0;
            for ( i = 2; i <= 1000; i++)
            {
                for ( j = 1; j <= i; j++)
                {

                    if (i % j == 0)
                    {
                        c = c + 1;
                    }
                }


                if (c <= 2)
                {
                    Console.WriteLine(i);
                }
                c = 0;


            }









            Console.ReadKey();


        }
    }
}
