using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection.NumberGuessingGame.Model {
    class AI : Gamer{

        public AI(int id) : this("AIOpponent", id) { }

        public AI(string name, int id) {
            this.Name = name;
            this.ID = id;
        }

        public override string Name {
            get {
                return _name;
            }
            protected set {
                if(!string.IsNullOrEmpty(value))
                    _name = value;
                else
                    throw new ArgumentNullException("name string is null or empty");
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

        public override int ID {
            get {
                return _id;
            }
            protected set {
                _id = value;
            }
        }
    }
}
