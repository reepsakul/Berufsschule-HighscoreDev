using HighscoreDAL;
using HighscoreModels;
using HighscoreModels.ViewModels;

namespace HighscoreBL.Repositories
{
    public class GamesRep : IGamesRep
    {
        private HsDal _dal;
        public GamesRep(HsDal hsdal)
        {
            _dal = hsdal;
        }

        public Game? getGame(int gameID)
        {
            throw new NotImplementedException();
        }

        public List<GamesPerPlayer> getGames(int playerID)
        {
            var games = from g in _dal.Games
                          orderby g.Title
                          select new GamesPerPlayer
                          {
                              GameID = g.GameID,
                              Publisher = g.Publisher
                          };
            return games.ToList();
        }
    }
}
