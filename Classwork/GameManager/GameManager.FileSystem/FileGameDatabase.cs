using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager.FileSystem
{
    public class FileGameDatabase : GameDatabase
    {
        public FileGameDatabase( string filename )
        {
            if (filename == null)
                throw new ArgumentNullException(nameof(filename));
            if (filename == "")
                throw new ArgumentException("Filename cannot be empty.", nameof(filename));

            _filename = filename;
        }

        private readonly string _filename;

        protected override Game AddCore( Game game )
        {
            //Load existing games
            var games = GetAllCore().ToList();

            //Find the largest Id and increment by 1
            if (games.Any())
                game.Id = games.Max(x => x.Id) + 1;
            else
                game.Id = 1;

            //Add to list
            games.Add(game);

            //Save the games
            SaveGames(games);

            return game;
        }

        protected override void DeleteCore( int id )
        {
            var games = GetAllCore().ToList();

            var game = games.FirstOrDefault(x => x.Id == id);
            if (game != null)
            {
                games.Remove(game);
                SaveGames(games);
            };
        }

        protected override IEnumerable<Game> GetAllCore()
        {
            if (File.Exists(_filename))
            {
                //Read all at once
                foreach (var line in File.ReadAllLines(_filename))
                {
                    var game = LoadGame(line);
                    if (game != null)
                        yield return game;
                };
            };
        }

        protected override Game GetCore( int id )
        {
            if (!File.Exists(_filename))
                return null;

            //Streams are very low level
            //var stream = File.Open();
            
            //Must clean up streams and reader/writers
            //Use a reader/writer - text stream
            using (StreamReader reader = File.OpenText(_filename))
            {                
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    var game = LoadGame(line);
                    if (game.Id == id)
                        return game;
                };

                //NEVER do this
                //var x = 10l;
                //reader.Close();
                //reader.Close();
                //reader.Dispose();

                return null;
            };

            #region The Long way
            //StreamReader reader = null;
            //try
            //{
            //    reader = File.OpenText(_filename);
            //    while (!reader.EndOfStream)
            //    {
            //        var line = reader.ReadLine();
            //        var game = LoadGame(line);
            //        if (game.Id == id)
            //            return game;
            //    };

            //    return null;
            //} finally
            //{
            //    reader?.Close();
            //}            
            #endregion
        }

        protected override Game UpdateCore( int id, Game newGame )
        {
            var games = GetAllCore().ToList();

            //Replace old game with new one
            var existing = games.FirstOrDefault(x => x.Id == id);
            if (existing != null)
            {
                games.Remove(existing);
                newGame.Id = id;
                games.Add(newGame);

                SaveGames(games);
            };

            return newGame;
        }

        private Game LoadGame( string line )
        {
            if (String.IsNullOrEmpty(line))
                return null;

            var fields = line.Split(',');
            if (fields.Length != 6)
                return null;

            return new Game {
                Id = Int32.Parse(fields[0]),
                Name = fields[1],
                Description = fields[2],
                Price = Decimal.Parse(fields[3]),
                Owned = Boolean.Parse(fields[4]),
                Completed = Boolean.Parse(fields[5])
            };
        }

        private string SaveGame( Game game )
        {
            return String.Join(",", game.Id, game.Name, game.Description, game.Price, game.Owned, game.Completed);
        }

        private void SaveGames( IEnumerable<Game> games )
        {
            //Use LINQ Luke
            var lines = from game in games
                        select SaveGame(game);

            File.WriteAllLines(_filename, lines);
        }
    }
}
