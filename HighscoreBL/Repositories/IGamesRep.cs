using HighscoreModels;
using HighscoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreBL.Repositories
{
    public interface IGamesRep
    {
        public Game? getGame(int gameID);
        public List<GamesPerPlayer> getGames(int playerID);
    }
}
