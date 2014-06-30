using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCollection.NumberGuessingGame.Model.GameModes {
    class Multiplayer : GameMode {

        public Multiplayer(List<Player> players, List<int> minimumValues, List<int> maximumValues) {

            for (int i = 0; i < players.Count; i++) {
                PlayerInterval temp;
                temp.lowValue = minimumValues[i];
                temp.highValue = maximumValues[i];

                base._playerIntervalDic.Add(players[i].ID, temp);
            }

            Random randNum = new Random();

            for (int i = 0; i < players.Count; i++) {
                base._correctValueDic.Add(players[i].ID, randNum.Next(minimumValues[i], maximumValues[i]));
            }
        }
    }
}
