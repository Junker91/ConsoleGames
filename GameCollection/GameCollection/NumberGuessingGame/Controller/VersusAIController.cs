using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCollection.NumberGuessingGame.Model;
using GameCollection.NumberGuessingGame.Model.GameModes;


namespace GameCollection.NumberGuessingGame.Controller {
    class VersusAIController {

        private Player _player;
        private List<int> _lowValueList;
        private List<int> _highValueList;
        private VersusAI _versusAI;

        public VersusAIController() {
            _lowValueList = new List<int>();
            _highValueList = new List<int>();
        }

        public void CreatePlayer(string name) {
            _player = new Player(name, 1, 1);
        }

        public void AddInterval(int low, int high) {
            _lowValueList.Add(low);
            _highValueList.Add(high);
        }

        public void CreateGame() {
            _versusAI = new VersusAI(_player, _lowValueList, _highValueList);
        }

        public int GuessForAI() {
            return _versusAI.AIGuess();
        }
    }
}
