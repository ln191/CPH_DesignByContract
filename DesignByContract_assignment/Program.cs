using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignByContract_assignment
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.Title = "Your account";
            Account account = new Account();
            bool running = true;
            Console.WriteLine("To deposit a amount press d and then enter the amount and press Enter");
            Console.WriteLine("To withdraw an amount press w and then enter the amount and press Enter");
            Console.WriteLine("To Exit program press e");
            Console.WriteLine("Your current balance is: {0}", account.Balance);
            while (running)
            {
                Console.WriteLine("Ready for Command:");
                ConsoleKey key = Console.ReadKey().Key;
                if (key == ConsoleKey.D)
                {
                    Console.WriteLine();
                    Console.WriteLine("How must would you like to deposit:");
                    string input = Console.ReadLine();
                    double value;
                    if (double.TryParse(input, out value))
                    {
                        account.Deposit(value);
                    }
                    else
                    {
                        Console.WriteLine("Error you input is not valet, your amount must consist of numbers");
                    }
                }
                else if (key == ConsoleKey.W)
                {
                    Console.WriteLine();
                    Console.WriteLine("How must would you like to withdraw:");
                    string input = Console.ReadLine();
                    double value;
                    if (double.TryParse(input, out value))
                    {
                        account.Withdraw(value);
                    }
                    else
                    {
                        Console.WriteLine("Error you input is not valet, your amount must consist of numbers");
                    }
                }
                else if (key == ConsoleKey.E)
                {
                    running = false;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Error: not a valet input");
                }
            }
        }
    }
}