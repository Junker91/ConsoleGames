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
                Console.WriteLine("Enter the lowest and higehst possible number for your game seperated by space: ");
                checkLow = TryCatch(ref lowestNumber);
                checkHigh = TryCatch(ref highestNumber);
            }while(!checkLow || !checkHigh);  

            do{
                Console.WriteLine("Enter the amount of tries you want to be");
                checkLives = TryCatch(ref lives);
            }while(!checkLives);

            _controller.CreatePlayer(name, lives);
            _controller.CreateGame(lowestNumber, highestNumber);
        }

        private void SinglePlayerGame() {

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
