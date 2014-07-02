using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCollection.NumberGuessingGame.Controller

namespace GameCollection.NumberGuessingGame.View {
    class VersusAIView {

        private VersusAIController _controller;
        private bool _shareInterval;

        public VersusAIView() {

            _controller = new VersusAIController();

            VersusAIMenu();
            VersusAIGame();
        }

        private void VersusAIMenu() {
            string name;
            bool checkLow, checkHigh;
            int lowestNumber = 0, highestNumber = 0;

            Console.Clear();
            Console.WriteLine("\nWelcome to the Number Guessing Game!\n" + "\t-Versus AI Mode\n");
            Console.WriteLine("Enter the name of your caracter.\n");
            Console.Write("Name input > ");
            name = Console.ReadLine();

            Console.WriteLine("Shall both players share the same number interval? (y/n)\n");
            Console.Write("Input > ");
            string input = Console.ReadLine();

            if (input == "y" || input == "yes" || input == "Y" || input == "Yes")
                _shareInterval = true;
            else
                _shareInterval = false;

            for (int i = 0; i < 2; i++) {

            }


            if (_shareInterval) {
                do {
                    Console.WriteLine("\nEnter the lowest and higehst possible number for your game seperated by enter.");
                    Console.Write("Lowest input > ");
                    checkLow = TryCatchIntInput(ref lowestNumber);
                    Console.Write("Highest input > ");
                    checkHigh = TryCatchIntInput(ref highestNumber);
                } while (!checkLow || !checkHigh);
            }
            else {
                for (int i = 0; i < 2; i++) {

                }
            }
        }

        private void VersusAIGame() {

        }
    }
}
