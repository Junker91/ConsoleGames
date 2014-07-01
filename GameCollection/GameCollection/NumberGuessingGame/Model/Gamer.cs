using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection.NumberGuessingGame.Model {
    public abstract class Gamer {

        protected string _name;
        protected int _score;
        protected int _id;

        public abstract int Score { get; set; }
        public abstract int ID { get; protected set; }

    }
}
