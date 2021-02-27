using System;

namespace serie
{
    class Program
    {
        static void Main(string[] args)
        {
			int c;
			int a = 0;
			int b = 1;
			int au = 0;
			int i;
			Console.WriteLine("ingrese un numero ");
			c = int.Parse(Console.ReadLine());

			for ( i = 0; i < c; i++)
			{
				if (i == 0)
				{
					Console.Write("la serie del numero es "+ a);
				}
				else
				{
					au = a;
					a = b;
					b = au + a;
					Console.Write(", {0}", a);
				}
			}
			Console.WriteLine();
		}
    }
}
