using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCollection.NumberGuessingGame.Model;
using GameCollection.NumberGuessingGame.Model.GameModes;

namespace GameCollection.NumberGuessingGame.Controller {
    class MultiplayerController {

        private List<Player> _playerList;
        private List<int> _lowValueList;
        private List<int> _highValueList;
        private Multiplayer _multiplayer;
        private int _id;

        public MultiplayerController() {
            _id = 1;
            _playerList = new List<Player>();
            _lowValueList = new List<int>();
            _highValueList = new List<int>();
        }

        public void addPlayer(string name, int low, int high) {
            _lowValueList.Add(low);
            _highValueList.Add(high);
            _playerList.Add(new Player(name, 1, _id));
            _id++;
        }

        public void CreateGame() {
            _multiplayer = new Multiplayer(_playerList, _lowValueList, _highValueList);
        }

        public bool UserGuessValid(int user, int guess) {
            return _multiplayer.IsGuessValid(_playerList[user], guess);
        }

        public int UserGuessPosition(int user, int guess) {
            return _multiplayer.GuessPosition(_playerList[user], guess);
        }

        public string PlayerName(int user) {
            return _playerList[user].Name;
        }

        public string UserInterval(int user) {
            return _multiplayer.IntervalToString(_playerList[user]);
        }


    }
}
