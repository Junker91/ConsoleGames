using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection.NumberGuessingGame.Model {
    class AI : Gamer{

        public AI(int id) {
            this.ID = id;
        }

        public string Name {
            get { return "AI"; }
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
