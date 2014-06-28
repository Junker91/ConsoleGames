using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection.NumberGuessingGame.Model.GameModes {
    public abstract class GameMode {
        protected Dictionary<String, Player> _playerDic = new Dictionary<string, Player>();
        protected Dictionary<string, int> _correctValueDic = new Dictionary<string, int>();
    }
}
