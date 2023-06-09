﻿namespace TratandoTiposExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Soma: ");
                var soma = Convert.ToDecimal(Console.ReadLine());
                Console.Write("Quantidade: ");
                var quantidade = Convert.ToDecimal(Console.ReadLine());
                var media = soma / quantidade;
                Console.WriteLine("Média calculada: " + media);
            }
            catch (FormatException)
            {
                Console.WriteLine("O valor digitado não é um número válido.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("O valor digitado excede os limites suportados.");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Não é possível dividir por zero.");
            }
        }
    }
}