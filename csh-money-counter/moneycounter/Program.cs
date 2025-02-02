﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace moneycounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many pennies do you have? ");
            int AmountOfPennies = (int)Convert.ToInt64(Console.ReadLine());
            int dollars = AmountOfPennies / 100;
            AmountOfPennies %= 100;
            Console.WriteLine($"You have {dollars} dollars");
            int quarters = AmountOfPennies / 25;
            AmountOfPennies %= 25;
            Console.WriteLine($"You have {quarters} quarters");
            int dimes = AmountOfPennies / 10;
            AmountOfPennies %= 10;
            Console.WriteLine($"You have {dimes} dimes");
            int nickels = AmountOfPennies / 5;
            AmountOfPennies %= 5;
            Console.WriteLine($"You have {nickels} nickels");
            int pennies = AmountOfPennies / 1;
            AmountOfPennies %= 1;
            Console.WriteLine($"You have {pennies} pennies");
            Console.ReadLine();
        }
    }
}
