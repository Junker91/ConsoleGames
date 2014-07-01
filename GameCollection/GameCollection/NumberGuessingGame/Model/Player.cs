using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection.NumberGuessingGame.Model {
    public class Player : Gamer{

        protected int _lives;

        public Player(string name, int lives, int id) {
            this.Name = name;
            this.Lives = lives;
            this.ID = id;
        }

        public string Name {
            get {
                return _name;
            }
            protected set {
                if (string.IsNullOrEmpty(value))
                    throw new ArgumentNullException("name string is null or empty");
                else
                    _name = value;
            }
        }

        public override int Score {
            get {
                return _score;
            }

            set {
                _score = value;
            }
        }

        public int Lives {
            get {
                return _lives;
            }

            set {
                _lives = value;
            }
        }

        public override int ID {
            get { return _id; }
            protected set { _id = value; }
        }
    }
}
