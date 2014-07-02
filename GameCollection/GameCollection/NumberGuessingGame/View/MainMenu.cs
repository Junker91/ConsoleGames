using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection.NumberGuessingGame.View {
    class MainMenu {

        public MainMenu() {
            Menu();
        }

        public void Menu() {
            int input;

            do {
                Console.Clear();
                Console.WriteLine("\nWelcome to the Number Guessing Game!\n");
                Console.WriteLine("Choose a number from the options below.");
                Console.WriteLine("1. Single player mode");
                Console.WriteLine("2. Multiplayer mode");
                Console.WriteLine("3. Against AI");
                Console.WriteLine("0. Back to main menu\n");
                Console.Write("Input > ");
                input = int.Parse(Console.ReadLine());

                switch (input) {
                    case 1:
                        new SinglePlayerView();
                        break;
                    case 2:
                        new MultiplayerView();
                        break;
                    case 3:
                        new VersusAIView();
                        break;
                    case 0:
                        break;
                    default:
                        Console.WriteLine("Invalid input, press Enter to try again. ");
                        Console.ReadKey();
                        break;
                }
            } while (input != 0);
        }
    }
}
