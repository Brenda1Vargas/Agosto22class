namespace Agosto22class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //menu para seleccionar el programa a ejecutar
            int op;
            op = int.Parse(Console.ReadLine());

            switch (op)
            {
                case 1:
                    Console.WriteLine("PROMEDIO DE 3 NÚMEROS");
                    exercice1.ExecuteExercise1();
                    break;
                    case 2:
                    Console.WriteLine("ÁREA Y PERÍMETRO DE UN RECTÁNGULO");
                    exercise2.ExecuteExercise2();
                    break;
                case 3:
                    Console.WriteLine("CASO 3");
                    break;

            }
            
        }
    }
}