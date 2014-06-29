using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection.NumberGuessingGame.Model.GameModes {
    public abstract class GameMode {
        protected Dictionary<int, Player> _playerDic = new Dictionary<int, Player>();
        protected Dictionary<string, int> _correctValueDic = new Dictionary<string, int>();
    }
}
