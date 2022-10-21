using System;

namespace L13_ABLG_1155622
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] EDAD = new int[5];
            string[] NOMBRES = new string[5];

            Console.WriteLine("Ingresa el nombre de 5 personas");

            for (int i=0; i<5; ++i)
            {
               
               
                Console.WriteLine("Ingresa el nombre: ");
                NOMBRES[i] = Console.ReadLine();
                Console.WriteLine("Ingresa la edad: "); 
               
                EDAD[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < 5; i++)
            {
                if (EDAD[i]>18)
                {
                    Console.WriteLine("El nombre es: " + NOMBRES[i]);
                }
            }

        }
    }
}
