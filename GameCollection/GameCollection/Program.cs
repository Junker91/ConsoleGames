using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection {
    class Program {
        static void Main(string[] args) {

            int input;

            do {
                Console.WriteLine("\nWelcome to the ConsoleGameCollection!");
                Console.WriteLine("\t-By Junker and Thuesen\n");
                Console.WriteLine("Chosse an option below:");
                Console.WriteLine("1. SomeGame");
                Console.WriteLine("2. SomeOtherGame");
                Console.WriteLine("3. SomeOtherThirdGame");
                Console.WriteLine("0. Exit\n");
                Console.Write("input > ");
                input = int.Parse(Console.ReadLine());

                /* As more games is created, just add them to the switch.
                 */
                switch (input) {
                    case 1:
                        new NumberGuessingGame.Main();
                        break;
                    default:
                        Console.WriteLine("Invalid input. Press any key to try again.");
                        Console.ReadKey();
                        break;
                }

            } while (input != 0);
        }
    }
}
