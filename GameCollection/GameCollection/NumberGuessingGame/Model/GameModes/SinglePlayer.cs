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
        public SinglePlayer(Player player, int minimunValue, int maximunValue) {
            this._minimunValue = minimunValue;
            this._maximunValue = maximunValue;
            base._playerDic.Add(player.ID, player);
            
            //Adds a value (the number that should be found) in the dictionary on the players space. Becomes more useful in multiplayer game.
            Random randNum = new Random();
            base._correctValueDic.Add(player.Name, randNum.Next(_minimunValue, _maximunValue));
        }

        public bool IsGuessValid(int guess) {
            if (guess >= _minimunValue && guess <= _maximunValue)
                return true;
            else
                return false;
        }

        public int GuessPosition(int guess) {
            if (guess > _correctValueDic[_playerDic[1].Name]) {
                _playerDic[1].Lives -= 1;
                return 1;
            } 
            else if (guess < _correctValueDic[_playerDic[1].Name]) {
                _playerDic[1].Lives -= 1;
                return -1;
            } 
            else {
                return 0;
            }   
        }

        public string Interval() {
            return "from " + _minimunValue + " to " + _maximunValue;
        }
    }
}
