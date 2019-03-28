/*
 * ITSE 1430
 * 
 * Provides a sample implementation of a game database.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    public class MemoryGameDatabase : GameDatabase
    {
        protected override Game AddCore( Game game )
        {
            game.Id = ++_nextId;
            _items.Add(Clone(game));

            return game;
        }

        protected override void DeleteCore( int id )
        {
            var index = GetIndex(id);
            if (index >= 0)
                _items.RemoveAt(index);
        }

        protected override Game GetCore( int id )
        {
            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
        }

        //public Game[] GetAll()
        protected override IEnumerable<Game> GetAllCore()
        {
            //Use iterator
            foreach (var item in _items)
                yield return Clone(item);
        }

        protected override Game UpdateCore( int id, Game game )
        {
            var index = GetIndex(id);

            game.Id = id;
            var existing = _items[index];
            Clone(existing, game);

            return game;
        }

        private Game Clone( Game game )
        {
            var newGame = new Game();
            Clone(newGame, game);

            return newGame;
        }

        private void Clone( Game target, Game source )
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Description = source.Description;
            target.Price = source.Price;
            target.Owned = source.Owned;
            target.Completed = source.Completed;
        }

        private int GetIndex( int id )
        {
            for (var index = 0; index < _items.Count; ++index)
                if (_items[index]?.Id == id)
                    return index;

            return -1;
        }

        //Arrays are so 90s
        //private readonly Game[] _items = new Game[100];

        //ArrayLists are so 00s
        //private readonly ArrayList _items = new ArrayList();

        private readonly List<Game> _items = new List<Game>();

        private int _nextId = 0;
    }
}
