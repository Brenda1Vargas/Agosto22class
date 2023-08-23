using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agosto22class
{
    internal class exercice1
    {
        public static void ExecuteExercise1()
        {
            int a = 0, b = 0, c= 0;
            Console.WriteLine("ingrese 3 numeros enteros");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            int promedio = (a + b + c) / 3;
            Console.WriteLine("el promedio de los tres números es: " + promedio);
        }
    }
}
