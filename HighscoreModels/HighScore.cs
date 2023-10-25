using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreModels
{
    public class HighScore
    {
        public int PlayerID { get; set; }
        public int GameID { get; set; }
        public DateTime ScoreDate { get; set; }
        public int Score { get; set; }

        public override string ToString()
        {
            return $"{PlayerID},{GameID},{ScoreDate},{Score}";
        }
    }
}
