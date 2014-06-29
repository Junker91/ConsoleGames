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

            Console.WriteLine("Welcome to single player mode");
            Console.WriteLine("First you have to choose a name, amount of lives and interval for the game");
            Console.WriteLine("Enter the name of your caracter: ");
            name = Console.ReadLine();
            
            do{
                Console.WriteLine("Enter the lowest and higehst possible number for your game seperated by enter: ");
                checkLow = TryCatch(ref lowestNumber);
                checkHigh = TryCatch(ref highestNumber);
            }while(!checkLow || !checkHigh);  

            do{
                Console.WriteLine("Enter the amount of tries you want to have");
                checkLives = TryCatch(ref lives);
            }while(!checkLives);

            _controller.CreatePlayer(name, lives);
            _controller.CreateGame(lowestNumber, highestNumber);
        }

        private void SinglePlayerGame() {
            int guess;

            Console.WriteLine("Let the game begin!!. {2} have {0} lives to guess the number and an interval {1} ", _controller.PlayerLives(), _controller.UserInterval(), _controller.PlayerName());

            do {
                Console.WriteLine("Take a guess:");
                guess = int.Parse(Console.ReadLine());

                do{
                    if (!_controller.UserGuessValid(guess))
                        Console.WriteLine("Invalid number");

                }while(!_controller.UserGuessValid(guess));

                if(_controller.UserGuessPosition(guess) != 0) {
                    _controller.PunishPlayer();
                    if (_controller.UserGuessPosition(guess) == 1)
                        Console.WriteLine("Guess must be smaller than {0}", guess);

                    else if (_controller.UserGuessPosition(guess) == -1)
                        Console.WriteLine("Guess must be higher than {0}", guess);

                    Console.WriteLine("{1} have {0} lives left", _controller.PlayerLives(), _controller.PlayerName());
                }
                

            } while (_controller.IsUserStillAlive() && _controller.UserGuessPosition(guess) != 0);

            if (_controller.IsUserStillAlive())
                Console.WriteLine("{0} won the game!", _controller.PlayerName());
            else
                Console.WriteLine("{0} lost. Better luck next time", _controller.PlayerName());


            Console.WriteLine("Press any key to return to main menu");
            Console.ReadKey();
        }

        private bool TryCatch(ref int number) {
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
