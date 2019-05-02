using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameManager
{
    public static class SeedDatabase
    {
        public static void Seed ( this IGameDatabase source )
        {
            //Collection initializer
            var games = new[]
                {
                    new Game() { Name = "DOOM", Description = "Space Marine", Price = 49.99M },
                    new Game() { Name = "Oblivion", Description = "Medieval", Price = 89.99M },
                    new Game() { Name = "Fallout 76", Description = "Failed MMO", Price = 0.01M }
                };

            foreach (var game in games)
                source.Add(game);            
        }

        //public static int ToInt ( this object source )
        //{
        //    return 0;
        //}
    }
}
