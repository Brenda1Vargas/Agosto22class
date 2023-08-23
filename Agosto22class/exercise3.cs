using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agosto22class
{
    internal class exercise3
    {
        public static void ExecuteExercise3()
        {
            Console.WriteLine("ingrese el radio del cilindro");
            int rad = 0;
            rad = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese la altura del cilindro");
            int alt = 0;
            alt = int.Parse(Console.ReadLine());

            if (rad < 0)
            {
                Console.WriteLine("numero negativo, por favor ingrese un entero positivo");
            } else
            {
                double Vo = 0;
                double k = 3.14 ;
                Vo = (k * ((rad) ^ 2 )* alt);
                Console.WriteLine("el volumen del cilindro es: "+ Vo);
            }
        }
    }
}
