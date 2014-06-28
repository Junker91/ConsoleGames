using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection.NumberGuessingGame.Model.GameModes {
    public class SinglePlayer : GameMode {

        private int _minimunValue;
        private int _maximunValue;
        

        /// <param name="player">The name of the player </param>
        /// <param name="minimunValue">The minimum value of the interval that should be guessed in</param>
        /// <param name="maximunValue">The maximum value of the interval that should be guessed in</param>
        public SinglePlayer(List<Player> player, int minimunValue, int maximunValue) {
            this._minimunValue = minimunValue;
            this._maximunValue = maximunValue;
            base._playerDic.Add(player[0].Name, player[0]);

            Random randNum = new Random();
            //Adds a value (the number that should be found) in the dictionary on the players space. Becomes more useful in multiplayer game.
            base._correctValueDic.Add(player[0].Name, randNum.Next(_minimunValue, _maximunValue));

            StartGame(player[0]);
        }

        //Method that plays out the singleplayer game. For each try it removes a life, until there are no more lives.
        public void StartGame(Player gamer) {
            bool gameWon = false;
            int input;
            Player player = base._playerDic[gamer.Name];


            int correctValue = base._correctValueDic[gamer.Name];

            Console.WriteLine("Welcome to the guessing game!");
            Console.WriteLine("You have {0} tries to find the right number between {1} and {2}", player.Lives, _maximunValue, _maximunValue);

            //Keeps running until the player either wins or loses the game
            do{
                Console.WriteLine("Take a guess");
                input = int.Parse(Console.ReadLine());

                if (input < correctValue) {
                    Console.WriteLine("The value must be higher!");
                    player.Lives -= 1;
                }
                else if (input > correctValue) {
                    Console.WriteLine("The value must be smaller");
                    player.Lives -= 1;
                }
                else {
                    gameWon = true;
                }



            } while (!gameWon && player.Lives > 0);

            if(player.Lives <= 0){
                Console.WriteLine("You did not find the number within the timeline. The number was {0}, better luck next time\n" +
                                  "Press any key to continue.", correctValue);
            }
            else {
                Console.WriteLine("Congratulations you found the number {0} and won the game!\n" +
                                  "Press any key to continue", correctValue);
            }
            Console.ReadKey();
                

        }
    }
}
