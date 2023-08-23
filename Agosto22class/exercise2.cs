



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agosto22class
{
    internal class exercise2
    {
        public static void ExecuteExercise2()
        {
            Console.WriteLine("ingrese la base del rectángulo");
            int bas = 0;
            bas = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la altura del rectángulo");
            int alt = 0;
            alt = int.Parse(Console.ReadLine());
            int area = bas * alt;
            Console.WriteLine("el area del rectángulo es: " + area);
            int perimetro = (2 * bas) + (2 * alt);
            Console.WriteLine("el perímetro del rectángulo es: " +  perimetro);

        }
    }
}
