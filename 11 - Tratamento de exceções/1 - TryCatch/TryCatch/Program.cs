using System;

namespace TryCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA DE DIVISAO DE NUMEROS INTEIROS");
            Console.WriteLine();

            try
            {
                int n1 = int.Parse(Console.ReadLine());
                int n2 = int.Parse(Console.ReadLine());

                int result = n1 / n2;
                Console.WriteLine(result);
            }
            catch (DivideByZeroException) 
            { 
                Console.WriteLine("Erro! Division by zero is not allowed"); 
            }
            catch (FormatException e ) { Console.WriteLine("Erro! " + e.Message); }
        }
    }
}
