using System.Diagnostics.CodeAnalysis;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte op;
            int num1, num2, suma, resta, multiplicacion, division;

            Console.WriteLine("Bienvenido a la calculadora");
            Console.WriteLine("Elija una opcion");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicaciom");
            Console.WriteLine("4. Division");
            op = Convert.ToByte(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Ingrese su numero");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());

                suma = num1 + num2;
                Console.WriteLine("La suma de "+num1+" + "+num2+" es igual a "+suma);
                //p
            }
            
        }
    }
}