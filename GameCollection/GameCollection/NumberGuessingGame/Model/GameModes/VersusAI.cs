using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection.NumberGuessingGame.Model.GameModes {
    class VersusAI {

        private AI _ai;
        private int _aiLowGuess;
        private int _aiHighGuess;
        private int _guess;

        public VersusAI(Player player, List<int> lowInterval, List<int> highInterval) {
            _ai = new AI(2);
            Random randNum = new Random();

            for (int i = 0; i < 2; i++) {
                PlayerInterval temp;
                temp.lowValue = lowInterval[i];
                temp.highValue = highInterval[i];

                base._playerIntervalDic.Add(i + 1, temp);

                base._correctValueDic.Add(i + 1, randNum.Next(lowInterval[i], highInterval[i]));
            }

            _aiLowGuess = lowInterval[1];
            _aiHighGuess = highInterval[1];

        }

        public int AIGuess() {
            Random randGuess = new Random();
            _guess = GuessPosition(_ai, randGuess.Next(_aiLowGuess, _aiHighGuess));

            if (_guess == 1)
                _aiHighGuess = _guess;
            else if (_guess == -1)
                _aiLowGuess = _guess;


            return _guess;
        }

        public string GuessToString() {
            return "AI guessed " + _guess;
        }
    }
}
