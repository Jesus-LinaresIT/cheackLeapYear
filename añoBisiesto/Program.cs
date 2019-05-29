using System;

namespace añoBisiesto
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;

            Console.WriteLine("Digite un año por favor:");
            a = Convert.ToInt16(Console.ReadLine());

            if (a > 0)
            {
                if (a % 4 == 0)
                {
                    if (a % 100 == 0)
                    {
                        if (a % 400 == 0)
                        {
                            Console.WriteLine("Año bisiesto");
                        }
                        else
                        {
                            Console.WriteLine("Año no bisiesto");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Año bisiesto");
                    }
                }
                else
                {
                    Console.WriteLine("Año no bisiesto");
                }
            }
            else
            {
                Console.WriteLine("Año no valido");
            }

        Console.Write("Disgite Cualquier letra para continuar...");
            Console.ReadKey();

        }
    }
}
