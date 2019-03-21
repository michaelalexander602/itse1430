using System.Collections.Generic;

namespace GameManager
{
    public interface IGameDatabase
    {
        Game Add( Game game );
        void Delete( int id );
        Game Get( int id );
        IEnumerable<Game> GetAll();
        Game Update( int id, Game game );
    }
}