using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection.NumberGuessingGame.Model.GameModes {
    public class SinglePlayer : GameMode {

        /// <param name="player">The name of the player </param>
        /// <param name="minimunValue">The minimum value of the interval that should be guessed in</param>
        /// <param name="maximunValue">The maximum value of the interval that should be guessed in</param>
        public SinglePlayer(Player player, int minimunValue, int maximunValue) {
            
            //Adds a value (the number that should be found) in the dictionary on the players space. Becomes more useful in multiplayer game.
            Random randNum = new Random();
            base._correctValueDic.Add(player.ID, randNum.Next(minimunValue, maximunValue));

            PlayerInterval temp;
            temp.lowValue = minimunValue;
            temp.highValue = maximunValue;

            base._playerIntervalDic.Add(player.ID, temp);
        }
    }
}
