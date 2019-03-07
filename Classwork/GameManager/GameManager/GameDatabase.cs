using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    public class GameDatabase
    {
        public GameDatabase()
        {
            var game = new Game();
            game.Name = "DOOM";
            game.Description = "Space Marine";
            game.Price = 49.99M;
            Add(game);

            game = new Game();
            game.Name = "Oblivion";
            game.Description = "Medieval";
            game.Price = 89.99M;
            Add(game);

            game = new Game();
            game.Name = "Fallout 76";
            game.Description = "Failed MMO";
            game.Price = 0.01M;
            Add(game);
        }
        public Game Add( Game game )
        {
            //validate input
            if (game == null)
                throw new ArgumentNullException(nameof(game));
            
            // game must be valid
            if (!game.Validate())
                throw new Exception("Game is invalid");

            // game names must be unique
            var existing = GetIndex(game.Name);
            if (existing >= 0)
                throw new Exception("Game must be unique.");

            //Dummy test
            if (String.Compare(game.Name, "Anthem", true) == 0)
                throw new InvalidOperationException("Only good games are allowed here.");
            if (game.Price > 1000)
                throw new NotImplementedException();


            for (var index = 0; index < _items.Length; ++index)
            {
                if (_items[index] == null)
                {
                    game.Id = ++_nextId;
                    _items[index] = Clone(game);
                    break;
                };
            };
            return game;
        }

        public Game Update( int id, Game game )
        {
            //Validate
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");
            if (game == null)
                throw new ArgumentNullException(nameof(game));
            if (!game.Validate())
                throw new Exception("Game is invalid.");

            var index = GetIndex(id);
            if (index < 0)
                throw new Exception("Game does not exist.");

            //Game names must be unique            
            var existingIndex = GetIndex(game.Name);
            if (existingIndex >= 0 && existingIndex != index)
                throw new Exception("Game must be unique.");

            game.Id = id;
            var existing = _items[index];
            Clone(existing, game);

            return game;
        }

        public Game[] GetAll()
        {
            // how many games
            int count = 0;
            foreach (var item in _items)
                if (item != null)
                    ++count;

            var tempIndex = 0;
            var temp = new Game[count];
            for (var index = 0; index < _items.Length; ++index)
                if (_items[index] != null)
                    temp[tempIndex++] = Clone(_items[index]);

            return temp;
        }

        public void Delete(int id)
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be > 0");

            var index = GetIndex(id);
            if (index >= 0)
                _items[index] = null;
        }

        public Game Get( int id )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "ID must be > 0");

            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
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

        private int GetIndex (int id)
        {
            for (var index = 0; index < _items.Length; ++index)
                if (_items[index]?.Id == id)
                    return index;

            return -1;
        }

        private int GetIndex(string name)
        {
            for (var index = 0; index < _items.Length; ++index)
                if (String.Compare(_items[index]?.Name, name, true) == 0)
                    return index;

            return -1;
        }

        private readonly Game[] _items = new Game[100];
        private int _nextId = 0;
    }
}
