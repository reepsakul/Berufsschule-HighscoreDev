using HighscoreBL.Repositories;
using HighscoreDAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HighscoreBL
{
    internal class UnitOfWork
    {
        private PlayersRep? _playersRep;
        private readonly HsDal _dal = new HsDal();
        public PlayersRep? Players {
            get {
                return _playersRep ??= new PlayersRep(_dal);
            }}

        public int Commit() {
            return _dal.Save();
        }

        public void Rollback() {

        }
        private GamesRep? _gamesRep;
        public GamesRep? Games {
            get {
                return _gamesRep ??= new GamesRep(_dal);
            }}
    }
}
