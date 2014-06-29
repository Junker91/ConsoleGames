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
            _player = new Player(name, lives);
        }

        public void CreateGame(int lowestNumber, int highestNumer) {
            _singleplayer = new SinglePlayer(_player, lowestNumber, highestNumer);
        }

        public bool UserGuess(int guess) {
            _singleplayer.Guess(guess);
        }

        public bool UserIsStillAlive() {
            _singleplayer.PlayerIsAlive();
        }
    }
}
