using HighscoreDAL;
using HighscoreModels;
using HighscoreModels.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreBL.Repositories
{
    public class PlayersRep : IPlayersRep
    {
        private HsDal _dal;
        public PlayersRep(HsDal hsdal) {
            _dal = hsdal;
        }

        public List<Player> getPlayers(int gameID)
        {
            _dal.HighScores.Where(x => x.GameID == gameID).ToList();
            throw new NotImplementedException();
        }

        public List<PlayerPerGame> GetAllPlayers() {
            var players = from p in _dal.Players
                          orderby p.NickName
                          select new PlayerPerGame {
                              PlayerID = p.PlayerID,
                              Email = p.Email,
                              NickName = p.NickName
                          };
            return players.ToList();
        }

        public Player? getPlayer(int playerID)
        {
            return _dal.Players.FirstOrDefault( w => w.PlayerID == playerID );
        }
    }
}
