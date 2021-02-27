using System;

namespace promedio
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, ed=0,i, may=0,men=0;
            double prom=0,prom2=0;

            Console.WriteLine("Cuantas edades desea ingresar ");
            a = int.Parse(Console.ReadLine());

            for (i = 1; i <= a; i++)
            {
                Console.WriteLine("INGRESE LA EDAD DE LA PERSONA ");
                ed = int.Parse(Console.ReadLine());

                prom = prom + ed;
                prom2 = prom / a;
               
                if (ed > may)
                {
                    may = ed;
                }
                if (ed < may)
                {
                    men = ed;
                }



            }

            Console.WriteLine("El promedio es " + prom2 );
            Console.WriteLine("El mayor es " + may);
            Console.WriteLine("El menor es " + men);








        }
    }
}
