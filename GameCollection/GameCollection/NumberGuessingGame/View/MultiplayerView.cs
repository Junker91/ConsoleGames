using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCollection.NumberGuessingGame.Controller;

namespace GameCollection.NumberGuessingGame.View {
    class MultiplayerView {

        private MultiplayerController _controller;
        private bool _shareInterval;

        public MultiplayerView() {
            _controller = new MultiplayerController();

            MultiPlayerMenu();
            MultiPlayerGame();
        }

        private void MultiPlayerMenu() {
            
            int numerOfPlayers = 0;
            bool pass;

            Console.Clear();
            Console.WriteLine("\nWelcome to the Number Guessing Game!\n" + "\t-Multiplayer Mode\n");
            Console.WriteLine("How many is playing?\n");
            
            do {
                Console.Write("Input > ");
                pass = TryCatchIntInput(ref numerOfPlayers);
            } while (!pass);

            Console.WriteLine("Shall all players share the same number interval? (y/n)\n");
            Console.Write("Input > ");
            string input = Console.ReadLine();

            if (input == "y" || input == "yes" || input == "Y" || input == "Yes")
                _shareInterval = true;
            else 
                _shareInterval = false;
            
            MultiPlayerCharacterCreation(numerOfPlayers);
        }

        private void MultiPlayerCharacterCreation(int numerOfPlayers) {
            string name;
            int lowestNumber = 0, highestNumber = 0;
            

            if(_shareInterval)
                EnterInterval(ref lowestNumber, ref highestNumber);

            for (int i = 0; i < numerOfPlayers; i++) {
                Console.WriteLine("Enter the name of player {0}", i + 1);
                Console.Write("Name input > ");
                name = Console.ReadLine();

                if (!_shareInterval)
                    EnterInterval(ref lowestNumber, ref highestNumber);

                _controller.addPlayer(name, lowestNumber, highestNumber);
            }
            _controller.CreateGame();
        }

        private void MultiPlayerGame() {
            int player = 0, guess;
            bool haveWon = false;
            int turn;

            Console.Clear();
            Console.WriteLine("\n\tLet the game begin!!\n");

            do{
                turn = player % _controller.GetPlayerNumber();
                Console.WriteLine("{0}, it's your turn. Take a guess", _controller.GetPlayerName(turn));
                

                do {
                    guess = int.Parse(Console.ReadLine());
                    if (!_controller.UserGuessValid(turn, guess))
                        Console.WriteLine("Invalid number");

                } while (!_controller.UserGuessValid(turn, guess));

                if (_controller.UserGuessPosition(turn, guess) != 0) {
                    Console.Write("Sorry {0}! Your number is ", _controller.GetPlayerName(turn));
                    if (_controller.UserGuessPosition(turn, guess) == 1)
                        Console.WriteLine("lower than {0}", guess);
                    else
                        Console.WriteLine("higher than {0}", guess);
                    
                    player++;
                }
                else
                    haveWon = true;
                
            } while(!haveWon);

            Console.WriteLine("\n{0} won the game! Congratulations!", _controller.GetPlayerName(turn));

            Console.WriteLine("Press Enter to return to the game menu");
            Console.ReadKey();

        }

        private void EnterInterval(ref int low, ref int high) {
            bool checkLow, checkHigh;
            do {
                Console.WriteLine("\nEnter the lowest and higehst possible number for the game seperated by enter.");
                Console.Write("Lowest input > ");
                checkLow = TryCatchIntInput(ref low);
                Console.Write("Highest input > ");
                checkHigh = TryCatchIntInput(ref high);
            } while (!checkLow || !checkHigh); 
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

        private bool TryCatchBoolInput(ref bool value) {
            try {
                value = bool.Parse(Console.ReadLine());
            }
            catch (FormatException) {
                return false;
            }
            return true;
        }
    }
}
