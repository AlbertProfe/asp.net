using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int j;
            int suma;
            int resta;
            int mult;

            Console.Write("Escribe un numero por favor .........");

            i = int.Parse(Console.ReadLine());
            Console.Write("Escribe un numero por favor .........");

            j = int.Parse(Console.ReadLine());

            suma = i + j;
            resta = i - j;
            mult = i * j;

            Console.WriteLine("Las variables introducidas son y su suma es: " +  i +"  " + "   " + j  + "   " + suma);
            Console.WriteLine("Las variables introducidas son y su resta es: " + i + "  " + "   " + j + "   " + resta);
            Console.WriteLine("Las variables introducidas son y su multoplicacion es: " + i + "  " + "   " + j + "   " + mult);
           




        }
    }
}
