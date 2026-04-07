namespace Aula05;

public class Program
{
    public static void Main(string[] args)
    {
        // Operadores Aritméticos

        Console.WriteLine("=======Calculadora Simples=======");

        Console.WriteLine("\n Digite um número: "); 
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("\n Digite outro número: ");
        int number2 = int.Parse(Console.ReadLine());

        Console.WriteLine("\n A soma de " + number1 + " + " + number2 + " é igual a: " + (number1 + number2));
        Console.WriteLine("\n A subtração de " + number1 + " - " + number2 + " é igual a: " + (number1 - number2));
        Console.WriteLine("\n A multiplicação de " + number1 + " * " + number2 + " é igual a: " + (number1 * number2));

        if (number2 != 0)
        {
            Console.WriteLine("\n A divisão de " + number1 + " / " + number2 + " é igual a: " + (number1 / number2));
            Console.WriteLine("\n O resto da divisão de " + number1 + " / " + number2 + " é: " + (number1 % number2));
        }
        else
        {
            Console.WriteLine("\n Não é possível dividir por zero.");
        }

        //-------------------------------//

        Console.WriteLine("\nDigite um número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("\nDigite outro número: ");
        int num2 = int.Parse(Console.ReadLine());

        int sum = num1 + num2;
        int subtraction = num1 - num2;
        int multiplication = num1 * num2;

        Console.Write("\nO valor da soma é: " + sum);
        Console.Write("\nO valor da subtração é: " + subtraction);
        Console.Write("\nO valor da multiplicação é: " + multiplication);

        if (num2 != 0)
        {
            int division = num1 / num2;
            int remainder = num1 % num2;

            Console.Write("\nO valor da divisão é: " + division);
            Console.Write("\nO resto da divisão é: " + remainder);
        }
        else
        {
            Console.WriteLine("Não é possível dividir por zero.");
        }
    }
}