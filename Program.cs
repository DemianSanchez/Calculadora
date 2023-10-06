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
            Console.WriteLine("3. Multiplicacion");
            Console.WriteLine("4. Division");
            op = Convert.ToByte(Console.ReadLine());

            if (op == 1)
            {
                Console.WriteLine("Ingrese su numero");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());

                suma = num1 + num2;
                Console.WriteLine("La suma de " + num1 + " + " + num2 + " es igual a " + suma);


            }
            if (op == 2)
            {
                Console.WriteLine("Ingrese su numero");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());

                resta= num1 - num2;
                Console.WriteLine("La resta de " + num1 + " + " + num2 + " es igual a " + resta);


            }
            if (op == 3)
            {
                Console.WriteLine("Ingrese su numero");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese su segundo numero");
                num2 = Convert.ToInt32(Console.ReadLine());
                
                multiplicacion = num1 * num2;
                Console.WriteLine("La multiplicación de " + num1 + " * " + num2 + " es igual a " + multiplicacion);


            }
            if (op == 4);
            {

                Console.WriteLine("dame el numero a dividir");
                num1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("dame el divisor");
                num2 = Convert.ToInt32(Console.ReadLine());
                
                division = (num1 / num2);
                Console.WriteLine(" la division de " + num1 + " y " + num2 + " es igual a " + division );

            }
            //Hecho por: Demian Sanchez, Erika Guerra, Victor Lucho, Fabian Salazar
        }
    }
}