using HighscoreModels;
using HighscoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreBL.Repositories
{
    public interface IPlayersRep
    {
        public Player? getPlayer(int playerID);
        public List<PlayerPerGame> GetAllPlayers();
        public List<Player> getPlayers(int gameID);
    }
}
