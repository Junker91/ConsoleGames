using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCollection.NumberGuessingGame.Controller;

namespace GameCollection.NumberGuessingGame.View {
    public class SinglePlayerView {

        private SinglePlayerController _controller;
        
        
        public SinglePlayerView() {
            _controller = new SinglePlayerController();

            SinglePlayerMenu();
            SinglePlayerGame();

        }

        private void SinglePlayerMenu() {
            string name;
            int lowestNumber = 0, highestNumber = 0, lives = 0;
            bool checkLow, checkHigh, checkLives;

            Console.Clear();
            Console.WriteLine("\nWelcome to the Number Guessing Game!\n" + "\t-Singleplayer Mode\n");
            Console.WriteLine("First you have to choose a name, amount of lives and interval for the game");
            Console.WriteLine("Enter the name of your caracter.\n");
            Console.Write("Name input > ");
            name = Console.ReadLine();
            
            do{
                Console.WriteLine("\nEnter the lowest and higehst possible number for your game seperated by enter.");
                Console.Write("Lowest input > "); 
                checkLow = TryCatchIntInput(ref lowestNumber);
                Console.Write("Highest input > ");
                checkHigh = TryCatchIntInput(ref highestNumber);
            }while(!checkLow || !checkHigh);  

            do{
                Console.WriteLine("\nEnter the amount of tries you want to have");
                Console.Write("Input > ");
                checkLives = TryCatchIntInput(ref lives);
            }while(!checkLives);

            _controller.CreatePlayer(name, lives);
            _controller.CreateGame(lowestNumber, highestNumber);
        }

        private void SinglePlayerGame() {
            int guess;

            Console.Clear();
            Console.WriteLine("\n\tLet the game begin!!\n" + "\n{2} have {0} lives to guess the number" + 
                "\nThe interval is {1}\n", _controller.PlayerLives(), _controller.UserInterval(), _controller.PlayerName());

            do {
                Console.WriteLine("Take a guess:");
                guess = int.Parse(Console.ReadLine()); //Error here!

                do{
                    if (!_controller.UserGuessValid(guess))
                        Console.WriteLine("Invalid number");

                }while(!_controller.UserGuessValid(guess));

                if(_controller.UserGuessPosition(guess) != 0) {
                    _controller.PunishPlayer();
                    Console.Write("The number is ");
                    if (_controller.UserGuessPosition(guess) == 1)
                        Console.WriteLine("smaller than {0}", guess);

                    else
                        Console.WriteLine("higher than {0}", guess);

                    Console.WriteLine("{1} have {0} lives left", _controller.PlayerLives(), _controller.PlayerName());
                }
                

            } while (_controller.IsUserStillAlive() && _controller.UserGuessPosition(guess) != 0);

            if (_controller.IsUserStillAlive())
                Console.WriteLine("\n{0} won the game! Congratulations!", _controller.PlayerName());
            else {
                Console.WriteLine("\n{0} lost. The correct number was {1}\nBetter luck next time", _controller.PlayerName(), _controller.GetCorrectValue());
            }
            
            Console.WriteLine("Press Enter to return to the game menu");
            Console.ReadKey();
        }

        private bool TryCatchIntInput(ref int number) {
            try {
                number = int.Parse(Console.ReadLine());
            }
            catch (FormatException) {
                return false;
            }
            return true;
        }

    }
}
