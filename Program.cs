using OrganizeToMinorNumber.Entities;
using OrganizeToMinorNumber.Entities.Exceptions;
using System;

namespace OrganizeToMinorNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa para converter um numero inteiro para o menor possivél.");
            try
            {
                Console.Write("Entre com um numero inteiro: ");
                OrganizeNumbers organizeNumbers = new OrganizeNumbers(int.Parse(Console.ReadLine().Trim()));
                Console.WriteLine("Numero digitado: " + organizeNumbers.Number);
                Console.WriteLine("Menor numero obtido: " + organizeNumbers.MinorNumber());
            }
            catch (OrganizeExceptions e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
