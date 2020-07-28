using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parzysta
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Podaj liczbe a powiem Ci czy jest parzysta czy nieparzysta:");
                var number = GetData();

                if (number % 2 == 0)
                {
                    Console.WriteLine("Twoja liczba jest parzysta");
                }
                else
                    Console.WriteLine("Twoja liczba jest nieparzysta");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private static int GetData()
        {
            if (!int.TryParse(Console.ReadLine(), out int data))
            {
                throw new Exception("Podana wartość jest nieprawidłowa.");
            }
            return data;
        }
    }
    
}
