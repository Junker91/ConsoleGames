using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection.NumberGuessingGame.Model.GameModes {
    public abstract class GameMode {
        protected Dictionary<int, int> _correctValueDic = new Dictionary<int, int>();
        protected Dictionary<int, PlayerInterval> _playerIntervalDic = new Dictionary<int,PlayerInterval>();

        public bool IsGuessValid(Player player, int guess) {
            if (guess >= _playerIntervalDic[player.ID].lowValue &&
                guess <= _playerIntervalDic[player.ID].highValue)
                return true;
            else
                return false;
        }

        public int GuessPosition(Gamer player, int guess) {
            if (guess > _correctValueDic[player.ID])
                return 1;
            else if (guess < _correctValueDic[player.ID])
                return -1;
            else
                return 0;
        }

        public int GetCorrectUserValue(Player player) {
            return _correctValueDic[player.ID];
        }

        public string IntervalToString(Player player) {
            int low = _playerIntervalDic[player.ID].lowValue;
            int high = _playerIntervalDic[player.ID].highValue;
            return "from " + low + " to " + high;
        }

        protected struct PlayerInterval {
            public int lowValue;
            public int highValue;
        }
    }
}
