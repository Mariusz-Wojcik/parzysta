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
            Console.WriteLine("Podaj liczbe a powiem Ci czy jest parzysta czy nieparzysta:");
            var number = GetData();

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
