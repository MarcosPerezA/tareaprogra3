using System;

namespace T3
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int d;

            Console.Write("Ingrese un NUMERO DEL 1 AL 7   ");
            d = int.Parse(Console.ReadLine());

            switch (d)
            {
                case 1:
                    Console.WriteLine("EL DIA ES LUNES");
                    break;
                case 2:
                    Console.WriteLine("EL DIA ES MARTES");
                    break;
                case 3:
                    Console.WriteLine("EL DIA ES MIERCOLES");
                    break;
                case 4:
                    Console.WriteLine("EL DIA ES JUEVES");
                    break;
                case 5:
                    Console.WriteLine("EL DIA ES VIERNES");
                    break;
                case 6:
                    Console.WriteLine("EL DIA ES SABADO");
                    break;
                case 7:
                    Console.WriteLine("EL DIA ES DOMINGO");
                    break;
            }


        }
    }
}
