namespace Agosto22class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //menu para seleccionar el programa a ejecutar
            Console.WriteLine("****************BIENVENIDO****************");
            Console.WriteLine("************Seleccione una opcion*****");
            Console.WriteLine("1. Promedio de 3 números");
            Console.WriteLine("2. Área y perímetro de un rectángulo");
            Console.WriteLine("3. Volumen de un cilindro");
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
                    Console.WriteLine("VOLUMEN DE UN CILINDRO");
                    exercise3.ExecuteExercise3();
                    break;

                    case 4:
                    Console.WriteLine("numero inválido, ingrese una opción del 1-3");
                    break;

            }
            
        }
    }
}