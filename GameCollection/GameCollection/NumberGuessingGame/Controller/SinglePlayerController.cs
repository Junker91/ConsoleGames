using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GameCollection.NumberGuessingGame.Model;
using GameCollection.NumberGuessingGame.Model.GameModes;

namespace GameCollection.NumberGuessingGame.Controller {
    public class SinglePlayerController {

        private Player _player;
        private SinglePlayer _singleplayer;

        public void CreatePlayer(string name, int lives) {
            _player = new Player(name, lives, 1);
        }

        public void CreateGame(int lowestNumber, int highestNumer) {
            _singleplayer = new SinglePlayer(_player, lowestNumber, highestNumer);
        }

        public bool UserGuessValid(int guess) {
            return _singleplayer.IsGuessValid(guess);
        }

        public int UserGuessPosition(int guess) {
            return _singleplayer.GuessPosition(guess);
        }

        public bool IsUserStillAlive() {
            if (_player.Lives != 0)
                return true;
            else
                return false;
        }

        public string PlayerName() {
            return _player.Name;
        }

        public int PlayerLives() {
            return _player.Lives;
        }

        public string UserInterval() {
            return _singleplayer.Interval();
        }
    }
}
