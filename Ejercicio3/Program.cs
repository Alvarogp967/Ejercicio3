using System;

namespace Ejercicio3
{
    class Program
    {
        static void Main()
        {
            int x = 54;
            int y = 51;
            double n = 29.46;
            double m = 27.33;
            int result;
            double result1;


            Console.WriteLine($"El valor de x es {x} , el valor de y es {y} , el valor de n es {n}, y el valor de m es {m}");
            result = x + y;
            Console.WriteLine($" La suma de x + y es {result}");
            result = x - y;
            Console.WriteLine($"La resta de x - y es {result}");
            result = x * y;
            Console.WriteLine($"El Producto de x * y es {result}");
            result = x / y;
            Console.WriteLine($"La division  de x / y es {result}");
            result = x % y;
            Console.WriteLine($"El Resto de x e y es {result}");

            result1 = n + m;
            Console.WriteLine($" La suma de n  + m es {result1}");
            result1 = n - m;
            Console.WriteLine($"La resta de n - m es {result1}");
            result1 = n * m;
            Console.WriteLine($"El Producto de n * m es {result1}");
            result1 = n / m;
            Console.WriteLine($"La division  de n / m es {result1}");
            result1 = n % m;
            Console.WriteLine($"El Resto de n y m es {result1}");
            x = x * 2;
            y = y * 2;
            n = n * 2;
            m = m * 2;
            Console.WriteLine($"El valor de x es {x} , el valor de y es {y} , el valor de n es {n}, y el valor de m es {m}");
            x = x / 2;
            y = y / 2;
            n = n / 2;
            m = m / 2;
            int suma = x + y + (int) n +(int) m;
            Console.WriteLine($" La suma de todas las variables {suma}");
            int producto = x * y * (int)n * (int)m;
            Console.WriteLine($" El producto de todas las variables es  {producto}");


        }
    }
}
