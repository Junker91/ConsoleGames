﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection.NumberGuessingGame.View {
    class MainMenu {

        public MainMenu() {

        }

        public void Menu() {
            int input;

            do {
                Console.Clear();
                Console.WriteLine("Welcome to the guessing game\n");
                Console.WriteLine("Chose a number from the options below.");
                Console.WriteLine("1. Single player mode");
                Console.WriteLine("2. Multiplayer mode");
                Console.WriteLine("3. Against AI");
                Console.WriteLine("0. Back to main menu");
                input = int.Parse(Console.ReadLine());

                switch (input) {
                    case 1:

                }




            } while (input != 0);
        }
    }
}
