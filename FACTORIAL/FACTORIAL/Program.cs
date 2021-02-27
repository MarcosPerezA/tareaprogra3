using System;

namespace FACTORIAL
{
    class Program
    {
        static void Main(string[] args)
        {
			int num, i;
			int result = 1;
			
			Console.Write("Introduce un numero : ");
			num = int.Parse(Console.ReadLine());
			
			for (i = 2; i <= num; i++)
			{
				result = result * i;
			}
			Console.WriteLine($"El factorial de "+ num+ " es " + result);

			
		}
    }
}
