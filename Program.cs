using System;
class Program
{
    static void Main(string[] args)
    {

        Console.Write("Introduce el primer número: ");
        int num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Introduce el segundo número: ");
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"\nComparaciones entre {num1} y {num2}:");
        Console.WriteLine($"¿{num1} es mayor que {num2}? {num1 > num2}");
        Console.WriteLine($"¿{num1} es menor que {num2}? {num1 < num2}");
        Console.WriteLine($"¿{num1} es igual a {num2}? {num1 == num2}");

        bool andResult = (num1 > 0 && num2 > 0);
        bool orResult = (num1 > 0 || num2 > 0);

        Console.WriteLine($"\n¿Ambos números son mayores que cero? {andResult}");
        Console.WriteLine($"¿Al menos uno de los números es mayor que cero? {orResult}");
    }
}

